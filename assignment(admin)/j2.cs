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
using System.Configuration;
using MongoDB.Driver.Core.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace assignment_admin_
{
    public partial class AddRfrm : Form
    {
        private CreateReservation client;
            
        public AddRfrm()
        {
            InitializeComponent();
            client = new CreateReservation("", "", "", "", "", "","","","");
        }

        private void Datetxt_Click(object sender, EventArgs e)
        {

        }

        private void Namelbl_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this form without saving?", "Close Form2", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                reservationfrm form1 = new reservationfrm();
                form1.Show();
                this.Close();
            }

            
        }

        private void AddRfrm_Load(object sender, EventArgs e)
        {

        }



        private bool ValidateInputs()
        {
            // Add more comprehensive validation
            return !string.IsNullOrWhiteSpace(Nametxt.Text) &&
                   !string.IsNullOrWhiteSpace(txtPhoneNum.Text) &&
                   Date.Text != null &&
                   comboBox1.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(duration.Text) &&
                   !string.IsNullOrWhiteSpace(AmountP.Text) &&
                   comboType.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(SpecialRtxt.Text);
        }

        private void Savebtn_Click(object sender, EventArgs e)
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
                string status;

                DateTime dt = DateTime.Parse(Date.Text);

                bool isDateBooked = client.Availability(dt.ToString("yyyy-MM-dd"));
                List<string> bookedHallNames = client.GetHallNamesByDate(dt.ToString("yyyy-MM-dd"));

                hallName = client.HallAssignment(int.Parse(AmountP.Text));
                bool isHallAvailable = !bookedHallNames.Contains(hallName);

                // Add reservation data
                string addResult = client.Adddata(
                    Nametxt.Text,
                    txtPhoneNum.Text,
                    dt.ToString("yyyy-MM-dd"),
                    comboBox1.SelectedItem.ToString(),
                    duration.Text,
                    AmountP.Text,
                    comboType.SelectedItem.ToString(),
                    SpecialRtxt.Text
                );

                // Get reservation ID
                reservationId = client.GetId(Nametxt.Text, dt.ToString("yyyy-MM-dd"));

                // Determine reservation status
                status = isHallAvailable ? "Confirmed" : "Pending";
                client.UpdateReservation_Status(hallName, Nametxt.Text, status);

                // Show appropriate message
                if (addResult == "Success")
                {
                    string message = status == "Confirmed"
                        ? $"Booking and Hall confirmed.\nYour reservation ID is: {reservationId}"
                        : $"Booking is Pending. Hall not available on that date.\nYour reservation ID is: {reservationId}";

                    MessageBox.Show(message);
                    reservationfrm form1 = new reservationfrm();
                    form1.Show();
                    this.Close();
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



        private void amountlbl_Click(object sender, EventArgs e)
        {

        }

        private void ASPlbl_Click(object sender, EventArgs e)
        {

        }

        private void contactlbl_Click(object sender, EventArgs e)
        {

        }

        private void Amounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
