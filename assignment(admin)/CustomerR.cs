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
    public class CustomerRes
    {
        public string name { get; set; }
        public string HallName { get; set; }
        public string PhoneNum { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string duration { get; set; }
        public string amount { get; set; }
        public string type { get; set; }
        public string request { get; set; }
        public string status { get; set; }


        public CustomerRes(string n, string h, string p, string d, string T, string D, string a, string t, string r, string s)
        {
            name = n;
            HallName = h;
            PhoneNum = p;
            date = d;
            time = T;
            duration = D;
            amount = a;
            type = t;
            request = r;
            status = "False";
        }

        public bool DeleteRecord(int userId)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            {
                try
                {
                    connection.Open();
                    string query = ("DELETE FROM Reservation WHERE Id = @UserID;");
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@UserID", userId);

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    // Return true if at least one row was affected
                    return true;

                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as needed
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }


        public string AddCustomerData(string n, string h, string p, string d, string T, string D, string a, string t, string r, int id)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            try
            {
                // Parse the date string to a DateTime object
                DateTime parsedDate;
                if (!DateTime.TryParse(d, out parsedDate))
                {
                    return "Error: Invalid date format";
                }

                // Parse the time string to ensure it's in a valid format
                DateTime parsedTime;
                if (!DateTime.TryParse(T, out parsedTime))
                {
                    return "Error: Invalid time format";
                }

                connection.Open();
                string query = "UPDATE Reservation SET CustomerName = @CustomerName, HallName = @HallName, PhoneNumber = @PhoneNumber, Date = @Date, Time = @Time, Duration = @Duration, [Amount of people] = @Amount, ReservationType = @Type, Requests = @Requests WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@CustomerName", n);
                cmd.Parameters.AddWithValue("@HallName", h);
                cmd.Parameters.AddWithValue("@PhoneNumber", p);
                cmd.Parameters.AddWithValue("@Date", parsedDate.ToString("yyyy-MM-dd"));  
                cmd.Parameters.AddWithValue("@Time", parsedTime.ToString("HH:mm:ss"));  
                cmd.Parameters.AddWithValue("@Duration", D);
                cmd.Parameters.AddWithValue("@Amount", a);
                cmd.Parameters.AddWithValue("@Type", t);
                cmd.Parameters.AddWithValue("@Requests", r);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                connection.Close();

                return "Success";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }





        public bool LoadCProfile(int Id)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            try
            {
                connection.Open();
                string query = "SELECT CustomerName, HallName, PhoneNumber, Date, Time, Duration, [Amount of people], ReservationType, Requests, Status FROM Reservation WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name = reader["CustomerName"].ToString();
                    HallName = reader["HallName"].ToString();
                    PhoneNum = reader["PhoneNumber"].ToString();
                    date = reader["Date"].ToString();
                    time = reader["Time"].ToString();
                    duration = reader["Duration"].ToString();
                    amount = reader["Amount of people"].ToString();
                    type = reader["ReservationType"].ToString();
                    request = reader["Requests"].ToString();
                    status = reader["Status"].ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return false;
        }
        public bool Availability(string searchValue)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            try
            {
                string query = "SELECT COUNT(*) FROM Reservation WHERE Date = @SearchValue";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchValue", searchValue);

                    int count = (int)command.ExecuteScalar();

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
        public int counting(string searchValue)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            try
            {
                string query = "SELECT COUNT(*) FROM Reservation WHERE Date = @SearchValue";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchValue", searchValue);

                    int count = (int)command.ExecuteScalar();

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return -1;
            }
        }
    }
}
