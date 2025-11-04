using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using assignment_admin_;

namespace assignment_admin_
{
    public class MenuItem
    {
        private string tableName;
        private string item;
        private decimal price;
        private bool available;

        public string TableName { get => tableName; set => tableName = value; }
        public string Item { get => item; set => item = value; }
        public decimal Price { get => price; set => price = value; }
        public bool Available { get => available; set => available = value; }

        public MenuItem(string tableN)  // constructor
        {
            TableName = tableN;
        }

        // Database operations
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }

        private static void ExecuteNonQuery(string query, Action<SqlCommand> parameterSetter)    // for add update delete only
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        parameterSetter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Data validation methods
        public void Validate(TextBox item, TextBox price, CheckBox isAvailable)
        {
            if (string.IsNullOrEmpty(item.Text))
            {
                MessageBox.Show("Item name cannot be empty.");
                return;
            }

            if (!decimal.TryParse(price.Text, out decimal rm) || rm <= 0)
            {
                MessageBox.Show("Price must be a valid number greater than 0.");
                return;
            }
        }


        // Refresh data grid view after operations done
        public void RefreshDGV(DataGridView menudgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    string query = $"SELECT * FROM {TableName}";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    menudgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh table data: {ex.Message}", "Error");
                return;
            }
        }


        // Menu cateories management operations
        public void Add(TextBox item, TextBox price, CheckBox isAvailable)
        {
            try
            {
                Validate(item, price, isAvailable);

                string query = $"INSERT INTO {TableName} (Item, Price, IsAvailable) VALUES (@Item, @Price, @IsAvailable)";
                ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Item", item.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(price.Text));
                    cmd.Parameters.AddWithValue("@IsAvailable", isAvailable.Checked);
                });

                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                item.Clear();
                price.Clear();
                isAvailable.Checked = true;
            }
        }


        public void findEdit(int id, TextBox itemTxt, TextBox priceTxt, CheckBox avaCb)
        {
            try
            {
                string query = $"SELECT * FROM {TableName} WHERE Id = @Id";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                itemTxt.Text = reader["Item"].ToString();
                                priceTxt.Text = reader["Price"].ToString();
                                avaCb.Checked = Convert.ToBoolean(reader["IsAvailable"]);
                            }
                            else
                            {
                                MessageBox.Show("Item not found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Find operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        public void Update(TextBox id, TextBox item, TextBox price, CheckBox isAvailable, DataGridView dgv)
        {
            if (!int.TryParse(id.Text, out int ID))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Validate(item, price, isAvailable);

                string query = $"UPDATE {TableName} SET Item = @Item, Price = @Price, IsAvailable = @IsAvailable WHERE Id = @Id";
                ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@Item", item.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(price.Text));
                    cmd.Parameters.AddWithValue("@IsAvailable", isAvailable.Checked);
                });

                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK);
                RefreshDGV(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                id.Clear();
                item.Clear();
                price.Clear();
                isAvailable.Checked = false;
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

                string query = $"DELETE FROM {TableName} WHERE Id = @Id";
                ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Id", ID);
                });

                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK);
                RefreshDGV(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                id.Clear();
            }
        }


        public void Search(TextBox searchTerm, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    string query = $"SELECT * FROM {TableName} WHERE Item LIKE @SearchTerm";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                return;
            }
            finally
            {
                searchTerm.Clear();
            }
        }
    }
}



