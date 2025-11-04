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
    public partial class k2 : Form
    {
        Own cU = new Own();
        public k2()
        {
            InitializeComponent();
            main.Visible = true;
            main.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxOrderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            k1 frm = new k1();
            frm.Show();
            frm.BringToFront();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k3 frm = new k3();
            frm.Show();
            frm.BringToFront();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.loginform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update.Visible = true;
            update.BringToFront();

            var userDetails = cU.GetUserDetails(); // get user details store in tuple

            string username = userDetails.oldN;
            string password = userDetails.oldP;

            currentU.Text = $"Current Username: {username}";
        }

        private void Nusertxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nusertxt.Text))
            {
                NEWeLbl.Text = "Enter new username";
                NEWeLbl.BringToFront();
            }
            else
            {
                NEWeLbl.Text = "";
                NEWeLbl.SendToBack();
            }
        }

        private void Npwtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Npwtxt.Text))
            {
                NEWpLbl.Text = "Enter new password";
                NEWpLbl.BringToFront();
            }
            else
            {
                NEWpLbl.Text = "";
                NEWpLbl.SendToBack();
            }
            AcceptButton = doneBtn;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string newUser = Nusertxt.Text.Trim();
            string newPw = Npwtxt.Text.Trim();

            if (string.IsNullOrEmpty(Nusertxt.Text))
            {
                MessageBox.Show("Please enter new username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Npwtxt.Text))
                MessageBox.Show("Please enter new password.");
            else
            {
                try
                {
                    cU.UpdateProfile(newUser, newPw);  // update new username and password into database

                    var userDetails = cU.GetUserDetails();  // renew username
                    currentU.Text = $"Current Username: {userDetails.oldN}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
                finally
                {
                    Nusertxt.Clear();
                    Npwtxt.Clear();
                }
            }
        }

        private void backSR_Click(object sender, EventArgs e)
        {
            main.Visible = true;
            main.BringToFront();
        }

        private void k2_Load(object sender, EventArgs e)
        {

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
