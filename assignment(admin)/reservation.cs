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

namespace assignment_admin_
{
    public class CreateReservation
    {
        private string name { get; set; }
        private string HallName { get; set; }
        private string PhoneNum { get; set; }
        private string date { get; set; }
        private string time { get; set; }
        private string duration { get; set; }
        private string amount { get; set; }
        private string type { get; set; }
        private string request { get; set; }
        private string status { get; set; }


        public CreateReservation(string n, string h, string p, string d, string t, string D, string a, string ty, string r, string s = "False")
        {
            name = n;
            HallName = h;
            PhoneNum = p;
            date = d;
            time = t;
            duration = D;
            amount = a;
            type = ty;
            request = r;
            status = s;
        }


        public string Adddata(string n, string p, string d, string t, string D, string a, string ty, string r)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            try
            {
                connection.Open();
                string query = "INSERT INTO Reservation (CustomerName, PhoneNumber, Date, Time, Duration, [Amount of people], ReservationType, Requests, HallName, Status) " +
                       "VALUES (@CustomerName, @PhoneNumber, @Date, @Time, @Duration, @Amount, @Type, @Requests, @HallName, @Status)"; ;
                SqlCommand cmd = new SqlCommand(query, connection);

                string hallName = HallAssignment(int.Parse(a));
                string status = "Pending";

                cmd.Parameters.AddWithValue("@CustomerName", n);
                cmd.Parameters.AddWithValue("@PhoneNumber", p);
                cmd.Parameters.AddWithValue("@Date", d);
                cmd.Parameters.AddWithValue("@Time", t);
                cmd.Parameters.AddWithValue("@Duration", D);
                cmd.Parameters.AddWithValue("@Amount", a);
                cmd.Parameters.AddWithValue("@Type", ty);
                cmd.Parameters.AddWithValue("@Requests", r);
                cmd.Parameters.AddWithValue("@HallName", hallName);
                cmd.Parameters.AddWithValue("@Status", status);


                cmd.ExecuteNonQuery();
                connection.Close();

                return "Success";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string HallAssignment(int a)
        {
            string HallName = "";

            if (a <= 8)
            {  // 1 to 8
                HallName = "Hana Kiri Suite";
            }
            else if (a <= 10)
            {  // 9 to 10
                HallName = "Yuze Dining Room";
            }
            else if (a <= 12)
            {  // 11 to 12
                HallName = "Kaze Private Dining";
            }
            else if (a <= 15)
            {  // 13 to 15
                HallName = "Takekage Room";
            }
            else
            {  // 16 to 20
                HallName = "Fujisakura Room";
            }

            return HallName;
        }

        public void UpdateReservation_Status(string HallName, string Name, string status)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            connection.Open();
            string query = "UPDATE Reservation SET Status = @Status, HallName = @HallName WHERE CustomerName = @Name";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@HallName", HallName);
            cmd.Parameters.AddWithValue("@Name", Name);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public string GetId(string Name, string date)
        {

            string id = "";

            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
                {
                    connection.Open();

                    string query = "SELECT Id FROM Reservation WHERE CustomerName = @Name AND Date = @date";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@date", date);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            id = result.ToString();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show($"Error retrieving ID: {ex.Message}");
            }

            return id;

        }

        public bool Availability(string searchValue)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            try
            {
                string query = "SELECT COUNT(*) FROM Reservation WHERE Date = @SearchValue";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0) { return true; }
                    else { return false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return true;
            }
        }

        public List<string> GetHallNamesByDate(string date)
        {
            List<string> hallNames = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
                {
                    string query = "SELECT HallName FROM Reservation WHERE Date = @date";
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@date", date);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hallName = reader["HallName"].ToString();
                                hallNames.Add(hallName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving hall names: {ex.Message}");
            }
            return hallNames;
        }
    }
}
