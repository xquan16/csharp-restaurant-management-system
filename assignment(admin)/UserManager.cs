using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment_admin_
{
    public class UserManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db"].ToString();

        private int MemberID;
        private string Username;
        private string Password;
        private string Role;

        
        public UserManager(int memberID, string username, string password, string role)
        {
            MemberID = memberID;
            Username = username;
            Password = password;
            Role = role;
        }

        public void SetMemberID(int id) => MemberID = id;
        public void SetUsername(string user) => Username = user;
        public void SetPassword(string pass) => Password = pass;
        public void SetRole(string userRole) => Role = userRole;



        public void AddUser(int memberID,string username, string password, string role)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Members (MemberID, Username, Password, Role) VALUES (@memberID, @username, @password, @role)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@memberID", memberID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditUser(int memberID, string username, string password, string role)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Members SET Username = @username, Password = @password, Role = @role WHERE MemberID = @memberID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@memberId", memberID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool DeleteUser(int memberId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
                {
                    con.Open();
                    string query = "DELETE FROM Members WHERE MemberID = @MemberID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
