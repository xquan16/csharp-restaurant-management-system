using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MongoDB.Driver.Core.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
using Amazon.Runtime.Internal;

namespace assignment_admin_
{
    public class ViewRequests
    {
        private string Requests {  get; set; }
       

        public ViewRequests(string r) 
        {
            Requests = r;     
        }

        public List<(string Id, string CustomerName, string Date, string Time, string NumPeople, string Status, string Requests)> GetConfirmedRequests()
        {
            List<(string Id, string CustomerName, string Date, string Time, string NumPeople, string Status, string Requests)> 
                confirmedRequests = new List<(string, string, string, string, string, string, string)>();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            {
                string query = @"SELECT Id, CustomerName, Date, Time, [Amount of people], Status, Requests FROM Reservation WHERE Status = 'Pending'";
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    confirmedRequests.Add((
                                Id: rd["Id"].ToString(),
                                CustomerName: rd["CustomerName"].ToString(),
                                Date: Convert.ToDateTime(rd["Date"]).ToString("yyyy-MM-dd"),
                                Time: rd["Time"].ToString(),
                                NumPeople: rd["Amount of people"].ToString(),
                                Status: rd["Status"].ToString(),
                                Requests: rd["Requests"].ToString()
                                ));
                }
            }
            connection.Close();
            return confirmedRequests;
        }




        public List<(string Id, string CustomerName, string Date, string Time, string NumPeople, string Status, string Requests)> ViewByCustomerName(string name)
        {
            List<(string Id, string CustomerName, string Date, string Time, string NumPeople, string Status, string Requests)>
                viewStatus = new List<(string, string, string, string, string, string, string)>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
            {
                string query = @"SELECT Id, CustomerName, Date, Time, [Amount of people], Status, Requests FROM Reservation WHERE CustomerName = @CustomerName";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", name);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            viewStatus.Add((
                                Id: rd["Id"].ToString(),
                                CustomerName: rd["CustomerName"].ToString(),
                                Date: rd["Date"] != DBNull.Value ? Convert.ToDateTime(rd["Date"]).ToString("yyyy-MM-dd") : "N/A",
                                Time: rd["Time"].ToString(),
                                NumPeople: rd["Amount of people"].ToString(),
                                Status: rd["Status"].ToString(),
                                Requests: rd["Requests"].ToString()
                            ));
                        }
                    }
                }
            }
            return viewStatus;
        }







        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
            {
                conn.Open();
                string query = "UPDATE Reservation SET Status = @Status WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@Id", requestId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
