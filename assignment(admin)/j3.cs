using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static assignment_admin_.AddRfrm;
using static System.Windows.Forms.AxHost;
using System.Configuration;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using assignment_admin_;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment_admin_
{
    public partial class UpdatePfrm : Form
    {
        Own cU = new Own();

        public UpdatePfrm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form without Updating your profile?", "Close Form3", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                reservationfrm form1 = new reservationfrm();
                form1.Show();
                this.Close();
            }
        }


        private void UpdatePfrm_Load(object sender, EventArgs e)
        {
            var userDetails = cU.GetUserDetails(); // get user details store in tuple

            string username = userDetails.oldN;
            string password = userDetails.oldP;

            ONametxt.Text = username;
            OPwtxt.Text = password;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string newUser = uNametxt.Text;
            string newPw = uPwtxt.Text;

            if (string.IsNullOrEmpty(uNametxt.Text))
            {
                MessageBox.Show("Please enter new username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(uPwtxt.Text))
                MessageBox.Show("Please enter new password.");
            else
            {
                try
                {
                    cU.UpdateProfile(newUser, newPw);  // update new username and password into database

                    var userDetails = cU.GetUserDetails();  // renew username
                    ONametxt.Text = newUser;
                    OPwtxt.Text = newPw;

                    Program.j1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
                finally
                {
                    uNametxt.Clear();
                    uPwtxt.Clear();
                }
            }
        }
    }
    
}
