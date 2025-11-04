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
    public partial class UpdateOwn: Form
    {

        private Own cU = new Own();
        string cName = Program.CurrentUsername;

        public UpdateOwn()
        {
            InitializeComponent();
        }


        //private void UpdateOwn_Load(object sender, EventArgs e)
        //{
            
        //    txtUsername.Text = adminOwn.GetUsername();
        //    txtPassword.Text = adminOwn.GetPassword();
        //}

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Username and Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cU.UpdateProfile(newUsername, newPassword);
            Program.adminform.Show();
            this.Hide();

            txtUsername.Clear();
            txtPassword.Clear();

            //bool success = adminOwn.UpdateProfile(newUsername, newPassword);
            //if (success)
            //{
            //    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Application.Exit();
            //}
            //else
            //{
            //    MessageBox.Show("Update failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void backUP_Click(object sender, EventArgs e)
        {
            Program.adminform.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btnEnter;
        }
    }
}
