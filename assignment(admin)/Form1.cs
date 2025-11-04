using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace assignment_admin_
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            UserAuthentication auth = new UserAuthentication(username, password);
            string result = auth.Login();

            Program.CurrentUsername = username;

            if (result == "Admin")
            {
                Program.adminform.Show();
                this.Hide();
            }
            else if (result == "Manager")
            {
                //menu menuForm = new menu(currentUser);
                Program.menuForm.Show();
                this.Hide();
            }
            else if (result == "Chef")
            {
                Program.Chef.Show();
                this.Hide();
            }
            else if (result == "Reservation Coordinator")
            {
                Program.j1.Show();
                this.Hide();
            }
            else if (result == "Customer")
            {
                Program.customer.Show();
                this.Hide();
            }
            else if (result != "Incorrect username/password")
            {
                MessageBox.Show("Login successful! User role: " + result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear input fields after login attempt
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtPassword.UseSystemPasswordChar)
                {
                    visible.Enabled = true;
                    visible.Visible = true;
                    visible.BringToFront();
                }
                else if (!txtPassword.UseSystemPasswordChar)
                {
                    invisible.Enabled = true;
                    invisible.Visible = true;
                    invisible.BringToFront();
                }
            }
            AcceptButton = btnLogin;
        }

        private void visible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            visible.Enabled = false;
            visible.Visible = false;
            visible.SendToBack();

            invisible.Enabled = true;
            invisible.Visible = true;
            invisible.BringToFront();
        }

        private void invisible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            invisible.Enabled = false;
            invisible.Visible = false;
            invisible.SendToBack();

            visible.Enabled = true;
            visible.Visible = true;
            visible.BringToFront();
        }
    }
}
