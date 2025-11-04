using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Configuration;
using System.Windows.Forms;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace assignment_admin_
{
    class UserAuthentication
    {
        // Attributes
        private string Username;
        private string Password;
        private string UserRole;

        public string currentN { get => Username; set => Username = value; }

        public UserAuthentication(string username, string password)
        {
            Username = username;
            Password = password;
            UserRole = "";
        }


        public string GetUserRole()
        {
            return UserRole;
        }


        public string Login()
        {
            string status = "Incorrect username/password";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
            {
                con.Open();
                string query = "SELECT role FROM Members WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        UserRole = result.ToString().Trim();
                        return UserRole;
                    }
                }
            }
            return status;
        }
    }
}