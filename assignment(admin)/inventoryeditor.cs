using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace assignment
{
    public class InventoryItem
    {
        private int id;
        private string name;
        private int quantity;
        private decimal price;
        private static string connectionString = ConfigurationManager.ConnectionStrings["db"].ToString();
        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public int Quantity { get { return quantity; } }
        public decimal Price { get { return price; } }

        public InventoryItem()
        {
        }

        public InventoryItem(string name, int quantity, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public InventoryItem(int id, string name, int quantity, decimal price)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public bool AddItem()
        {
            string query = "INSERT INTO inventory (Name, Quantity, [Price(RM)]) VALUES (@Name, @Quantity, @Price)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Price", price);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Add failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool UpdateItem()
        {
            string query = "UPDATE inventory SET Name = @Name, Quantity = @Quantity, [Price(RM)] = @Price WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Id", id);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static DataTable ViewAll()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM inventory";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable inventoryData = new DataTable();
                        adapter.Fill(inventoryData);
                        return inventoryData;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"View failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static InventoryItem ViewItemById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM inventory WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new InventoryItem(
                                    reader.GetInt32(reader.GetOrdinal("Id")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetInt32(reader.GetOrdinal("Quantity")),
                                    reader.GetDecimal(reader.GetOrdinal("price(RM)"))  // Note the column name
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it more gracefully
                MessageBox.Show($"Error retrieving item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool DeleteItem()
        {
            if (id <= 0)
            {
                MessageBox.Show("Invalid item ID for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "DELETE FROM inventory WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show($"No item found with ID {id} to delete.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        public void RefreshDGV(DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM inventory";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh table data: {ex.Message}", "Error");
                return;
            }
        }


        public void Delete(TextBox id, DataGridView dgv)
        {
            try
            {
                if (!int.TryParse(id.Text, out int ID))
                {
                    MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM inventory WHERE Id = @Id;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item deleted successfully!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDGV(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete item. Please try again.\nError: {ex.Message}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                id.Clear();
            }
        }
    }
}
    

