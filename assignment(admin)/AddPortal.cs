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
    public partial class AddPortal: Form
    {
        private new ManageUserPortal ParentForm;  // Reference to ManageUserPortal

        public AddPortal(ManageUserPortal parent)
        {
            InitializeComponent();
            ParentForm = parent;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int memberID = int.Parse(txtMemberID.Text);
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;

            if (!int.TryParse(txtMemberID.Text, out memberID))
            {
                MessageBox.Show("Member ID must be a number.");
                return;
            }
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            UserManager userManager = new UserManager(memberID,username,password,role);
            userManager.AddUser(memberID,username, password, role);

            MessageBox.Show("User added successfully!");

            ParentForm.LoadUsers();  // Refresh the user list in ManageUserPortal
            Program.manageform.Show();
            this.Close();  // Close the AddPortal form
        }

        private void backMU_Click(object sender, EventArgs e)
        {
            Program.manageform.Show();
            this.Hide();
        }
    }
}
