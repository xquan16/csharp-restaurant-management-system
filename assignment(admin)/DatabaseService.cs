using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace assignment_admin_
{
    public class DatabaseService
    {
        private string _connectionString;

        public DatabaseService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString; ;
        }

        public void SaveOrder(int tableNumber, List<Order> orders)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                foreach (var order in orders)
                {
                    string query = "INSERT INTO Orders (TableNumber, OrderName, Quantity, TotalPrice, OrderTime) " +
                                   "VALUES (@TableNumber, @OrderName, @Quantity, @TotalPrice, @OrderTime)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableNumber", tableNumber);
                        command.Parameters.AddWithValue("@OrderName", order.ItemName);
                        command.Parameters.AddWithValue("@Quantity", order.Quantity);
                        command.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                        command.Parameters.AddWithValue("@OrderTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void SaveFeedback(int tableNumber, string feedback)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Feedback (Feedback, TableNumber, FeedbackTime) " +
                               "VALUES (@Feedback, @TableNumber, @FeedbackTime)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Feedback", feedback);
                    command.Parameters.AddWithValue("@TableNumber", tableNumber);
                    command.Parameters.AddWithValue("@FeedbackTime", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
