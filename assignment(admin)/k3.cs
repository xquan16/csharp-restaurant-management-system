using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Runtime.Internal;

namespace assignment_admin_
{
    public partial class k3 : Form
    {
        private CreateReservation client;
        private ViewRequests VRequests;

        public k3()
        {
            InitializeComponent();
            Hide(rP, "Reservation");
            client = new CreateReservation("", "", "", "", "", "", "", "", "");
            VRequests = new ViewRequests("");
        }


        private void Hide(Panel show, string title)
        {
            rP.Visible = false;
            requestP.Visible = false;
            statusP.Visible = false;

            show.Visible = true;
            show.BringToFront();

            rrLbl.Text = title;
            BringToFront();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            k2 form2 = new k2();
            form2.Show();
            form2.BringToFront();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide(requestP, "Reservation Request");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide(rP, "Reservation");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide(statusP, "View Reservation Status");
            lstViewR.Items.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide(rP, "Reservation");
        }




        private bool ValidateInputs()
        {
            // Add more comprehensive validation
            return !string.IsNullOrWhiteSpace(Nametxt.Text) &&
                   !string.IsNullOrWhiteSpace(txtPhoneNum.Text) &&
                   dd.Text != null &&
                   comboTime.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(duration.Text) &&
                   !string.IsNullOrWhiteSpace(AmountP.Text) &&
                   comboType.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(sTxt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate all inputs
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill in all required fields correctly.");
                return;
            }

            try
            {
                string hallName;
                string reservationId;
                //string status = "Pending";

                // Assign hall based on number of people
                hallName = client.HallAssignment(int.Parse(AmountP.Text));

                // Add reservation data with Pending status
                string addResult = client.Adddata(
                    Nametxt.Text,
                    txtPhoneNum.Text,
                    DateTime.Parse(dd.Text).ToString("yyyy-MM-dd"),
                    comboTime.SelectedItem.ToString(),
                    duration.Text,
                    AmountP.Text,
                    comboType.SelectedItem.ToString(),
                    sTxt.Text
                );

                // Get reservation ID
                reservationId = client.GetId(Nametxt.Text, DateTime.Parse(dd.Text).ToString("yyyy-MM-dd"));

                // Show appropriate message
                if (addResult == "Success")
                {
                    MessageBox.Show($"Reservation request submitted.\nYour reservation ID is: {reservationId}\nStatus: Pending");
                    Hide(rP, "Reservation");
                }
                else
                {
                    MessageBox.Show($"Error saving reservation: {addResult}");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstViewR.Items.Clear();

            //get data from database and display it in the listview
            var results = VRequests.ViewByCustomerName(txtName.Text);

            if (results != null && results.Count > 0)
            {
                foreach (var request in results)
                {
                    ListViewItem item = new ListViewItem(request.Id);
                    item.SubItems.Add(request.CustomerName);
                    item.SubItems.Add(request.Date);
                    item.SubItems.Add(request.Time);
                    item.SubItems.Add(request.NumPeople);
                    item.SubItems.Add(request.Status);
                    item.SubItems.Add(request.Requests);

                    lstViewR.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No reservations found for this customer.");
            }
            txtName.Text = "";
        }

    }
}