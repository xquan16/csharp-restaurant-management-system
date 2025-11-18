using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment_admin_
{
    public class Own
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db"].ToString();

        private int MemberID;
        private string Username;
        private string Password;

        public int memberID { get => MemberID; set => MemberID = value; }
        public string username { get => Username; set => Username = value; }
        public string password { get => Password; set => Password = value; }

        public Own()
        {
        }

        public void UpdateProfile(string newUsername, string newPassword)
        {
            string query = "UPDATE Members SET Username = @NewUsername, Password = @NewPassword WHERE Username = @CurrentUsername";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@CurrentUsername", Program.CurrentUsername);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    Program.CurrentUsername = newUsername;
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        public (string oldN, string oldP) GetUserDetails()
        {
            try
            {
                string query = "SELECT Username, Password FROM Members WHERE Username = @Username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Program.CurrentUsername);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string oldName = reader["Username"].ToString();
                                string oldPw = reader["Password"].ToString();

                                return (oldName, oldPw);
                            }
                            else
                            {
                                MessageBox.Show("Member Not Found");
                                return (null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Find operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }
        }
    }
}


