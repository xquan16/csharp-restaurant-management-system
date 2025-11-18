using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace assignment_admin_
{
    class Reservation_Q
    {
        private int id;
        private string customerName;
        private string hallName;
        private string phoneNumber;
        private DateTime date;
        private int amountOfPeople;
        private string reservationType;
        private decimal totalSpend;
        private string status;

        public int Id { get => id; set => id = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string HallName { get => hallName; set => hallName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime Date { get => date; set => date = value; }
        public int AmountOfPeople { get => amountOfPeople; set => amountOfPeople = value; }
        public string ReservationType { get => reservationType; set => reservationType = value; }
        public decimal TotalSpend { get => totalSpend; set => totalSpend = value; }
        public string Status { get => status; set => status = value; }




        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }




        public void refreshM(DataGridView dgv, DateTimePicker datetime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    // Extract month and year from DateTimePicker safely
                    int month = datetime.Value.Month;
                    int year = datetime.Value.Year;

                    // SQL query to filter reservations by month and year
                    string query = @"SELECT Id, CustomerName, HallName, PhoneNumber, Date, [Amount of people], ReservationType, TotalSpend, Status 
                            FROM dbo.Reservation 
                            WHERE MONTH(Date) = @Month AND YEAR(Date) = @Year 
                            ORDER BY Date, Time;";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Month", month);
                    adapter.SelectCommand.Parameters.AddWithValue("@Year", year);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh report data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void reportMonth(TableLayoutPanel p, DateTimePicker dt, Label y, Label m, Label totalR, Label status)
        {
            try
            {
                p.Visible = true;
                p.BringToFront();

                // Extract month and year from DateTimePicker
                int year = dt.Value.Year;
                int month = dt.Value.Month;

                y.Text = year.ToString();
                m.Text = dt.Value.ToString("MMMM");

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    // count total spend of customer base on month and year
                    string query = @"SELECT ISNULL(SUM(TotalSpend), 0) AS TotalMonthlySpend FROM Reservation 
                                    WHERE MONTH(Date) = @Month AND YEAR(Date) = @Year;";

                    // count reservations base on status
                    string query1 = @"SELECT COUNT(*) AS CountStatus FROM Reservation 
                             WHERE MONTH(Date) = @Month AND YEAR(Date) = @Year AND Status = @Status";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Month", month);
                        cmd.Parameters.AddWithValue("@Year", year);

                        int revenue = Convert.ToInt32(cmd.ExecuteScalar());
                        totalR.Text = $"RM{revenue}";
                    }

                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@Month", month);
                        cmd1.Parameters.AddWithValue("@Year", year);

                        int confirmedCount = 0;
                        int pendingCount = 0;

                        cmd1.Parameters.AddWithValue("@Status", "Confirmed");
                        confirmedCount = Convert.ToInt32(cmd1.ExecuteScalar());

                        cmd1.Parameters["@Status"].Value = "Pending";
                        pendingCount = Convert.ToInt32(cmd1.ExecuteScalar());

                        status.Text = $"Confirmed - {confirmedCount}\nPending - {pendingCount}";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh report data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void refreshRT(DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    // SQL query to filter by reservations type
                    string query = @"SELECT Id, CustomerName, HallName, [Amount of people], ReservationType, TotalSpend, Status
                                    FROM Reservation ORDER BY ReservationType";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh report data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void reportRT(TableLayoutPanel p, Label rt, Label status, Label totalR)
        {
            try
            {
                p.Visible = true;
                p.BringToFront();

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    // count reservations by reservation type
                    string typeQuery = @"SELECT COUNT(*) FROM dbo.Reservation WHERE ReservationType = @rt";

                    // count total reservations
                    string totalQuery = @"SELECT COUNT(*) AS TotalReservations FROM dbo.Reservation";

                    // count by status
                    string statusQuery = @"SELECT COUNT(*) AS CountStatus FROM dbo.Reservation WHERE Status = @Status";

                    // get reservation types
                    using (SqlCommand typeCmd = new SqlCommand(typeQuery, conn))
                    {
                        int corporate = 0;
                        int general = 0;
                        int pe = 0;

                        typeCmd.Parameters.AddWithValue("@rt", "Corporate");
                        corporate = Convert.ToInt32(typeCmd.ExecuteScalar());

                        typeCmd.Parameters["@rt"].Value = "General";
                        general = Convert.ToInt32(typeCmd.ExecuteScalar());

                        typeCmd.Parameters["@rt"].Value = "Private Event";
                        pe = Convert.ToInt32(typeCmd.ExecuteScalar());

                        rt.Text = $"Corporate - {corporate}\nGeneral - {general}\nPrivate Event - {pe}";
                    }

                    // get total reservations
                    using (SqlCommand totalCmd = new SqlCommand(totalQuery, conn))
                    {
                        int totalReservations = Convert.ToInt32(totalCmd.ExecuteScalar());
                        totalR.Text = $"{totalReservations}";
                    }

                    // get status counts
                    using (SqlCommand statusCmd = new SqlCommand(statusQuery, conn))
                    {
                        int confirmedCount = 0;
                        int pendingCount = 0;

                        statusCmd.Parameters.AddWithValue("@Status", "Confirmed");
                        confirmedCount = Convert.ToInt32(statusCmd.ExecuteScalar());

                        statusCmd.Parameters["@Status"].Value = "Pending";
                        pendingCount = Convert.ToInt32(statusCmd.ExecuteScalar());

                        status.Text = $"Confirmed - {confirmedCount}\nPending - {pendingCount}\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to get reservation type data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}