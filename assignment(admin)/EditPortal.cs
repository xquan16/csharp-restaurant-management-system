using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_admin_
{
    public partial class EditPortal : Form
    {
        private new ManageUserPortal ParentForm;
        private int MemberID;
        public EditPortal(ManageUserPortal parent, int memberID, string username, string password, string role)
        {
            InitializeComponent();
            ParentForm = parent;
            MemberID = memberID;
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtRole.Text = role;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            int memberID = MemberID;
            string newUsername = txtUsername.Text;
            string newPassword = txtPassword.Text;
            string newRole = txtRole.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newRole))
            {
                MessageBox.Show("Username and Role cannot be empty.");
                return;
            }

            UserManager userManager = new UserManager(memberID, newUsername, newPassword, newRole);
            userManager.EditUser(memberID, newUsername, newPassword, newRole);

            MessageBox.Show("User details updated successfully!");

            ParentForm.LoadUsers(); // Refresh user list in ManageUserPortal
            Program.manageform.Show();
            this.Close();
        }

        private void backMU_Click(object sender, EventArgs e)
        {
            Program.manageform.Show();
            this.Hide();
        }
    }
}
