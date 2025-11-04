using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace assignment_admin_
{
    public class ordereditor
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["db"].ToString();

        // Method to get all orders
        public System.Data.DataTable GetAllOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM dbo.Orders"; // Use dbo.Orders to specify the schema
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        // Return an empty DataTable with the correct schema if no data
                        dt.Columns.Add("Id", typeof(int));
                        dt.Columns.Add("TableNumber", typeof(int));
                        dt.Columns.Add("OrderName", typeof(string));
                        dt.Columns.Add("Quantity", typeof(int));
                        dt.Columns.Add("TotalPrice", typeof(decimal));
                        dt.Columns.Add("OrderTime", typeof(DateTime));
                    }
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                    // Return an empty DataTable with schema instead of null
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("TableNumber", typeof(int));
                    dt.Columns.Add("OrderName", typeof(string));
                    dt.Columns.Add("Quantity", typeof(int));
                    dt.Columns.Add("TotalPrice", typeof(decimal));
                    dt.Columns.Add("OrderTime", typeof(DateTime));
                    return dt;
                }
            }
        }

        // Method to check if an order exists (replacing MarkAsInProgress since no Status column)
        public bool OrderExists(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM dbo.Orders WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", orderId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking order existence: " + ex.Message);
                    return false;
                }
            }
        }

        // Method to mark order as complete (delete)
        public bool MarkAsComplete(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM dbo.Orders WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", orderId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error marking as complete: " + ex.Message);
                    return false;
                }
            }
        }
    }
}