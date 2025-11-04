using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static assignment_admin_.AddRfrm;

namespace assignment_admin_
{
    public partial class frmDisplayR : Form
    {
        private CustomerRes Customerdata;
        public frmDisplayR()
        {
            InitializeComponent();
            Customerdata = new CustomerRes("", "", "", "", "", "", "", "", "", "");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            reservationfrm form1 = new reservationfrm();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Close Form4", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool status = Customerdata.DeleteRecord(int.Parse(Idtxt.Text));
                if (status == true)
                {
                    MessageBox.Show("Deletion Successful");                   
                    
                }
                else 
                {
                    MessageBox.Show("No Record found. Please enter a valid ID");
                }
                reservationfrm form1 = new reservationfrm();
                form1.Show();
                this.Close();
            }           
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && txtCPhoneNum.Text != "" && CDate.Text != "" && cbTime.SelectedItem != null && CDuration.Text != "" && CAmount.Text != "" && comboType.SelectedItem != null && txtCRequest.Text != "")
            {
                try
                {
                    // parse the date to validate
                    DateTime parsedDate;
                    if (!DateTime.TryParse(CDate.Text, out parsedDate))
                    {
                        MessageBox.Show("Invalid date format. Please select a valid date.");
                        return;
                    }

                    string hallName = Customerdata.HallAssignment(int.Parse(CAmount.Text));
                    bool dateHasReservations = Customerdata.Availability(parsedDate.ToString("yyyy-MM-dd"));  // Use consistent date format

                    // check hall is available on this date
                    bool hallAvailable = true;
                    if (dateHasReservations)
                    {
                        List<string> bookedHalls = Customerdata.GetHallNamesByDate(parsedDate.ToString("yyyy-MM-dd"));
                        foreach (string bookedHall in bookedHalls)
                        {
                            if (bookedHall == hallName)
                            {
                                hallAvailable = false;
                                break;
                            }
                        }
                    }

                    // update the reservation details
                    string updateResult = Customerdata.AddCustomerData(
                        txtCName.Text,
                        hallName,
                        txtCPhoneNum.Text,
                        CDate.Text,  // The AddCustomerData method will now handle the conversion
                        cbTime.SelectedItem.ToString(),
                        CDuration.Text,
                        CAmount.Text,
                        comboType.SelectedItem.ToString(),
                        txtCRequest.Text,
                        int.Parse(Idtxt.Text)
                    );

                    if (updateResult == "Success")
                    {
                        if (hallAvailable)
                        {
                            MessageBox.Show("Reservation details updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Reservation details updated successfully.\nNote: The selected hall may not be available on this date.");
                        }

                        reservationfrm form1 = new reservationfrm();
                        form1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update reservation: {updateResult}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating reservation: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill all the fields!");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //get data from database and display in the text box
            if (Idtxt.Text != "")
            {
                int userId = int.Parse(Idtxt.Text);
                if (Customerdata != null && Customerdata.LoadCProfile(userId))
                {
                    txtCName.Text = Customerdata.name;
                    txtCHallName.Text = Customerdata.HallName;
                    txtCPhoneNum.Text = Customerdata.PhoneNum;
                    CDate.Text = Customerdata.date;
                    cbTime.SelectedItem = DateTime.Parse(Customerdata.time).ToString("h:mm tt");
                    CDuration.Text = Customerdata.duration;
                    CAmount.Text = Customerdata.amount;
                    comboType.SelectedItem = Customerdata.type;
                    txtCRequest.Text = Customerdata.request;
                    txtCStatus.Text = Customerdata.status;

                }
                else
                {
                    MessageBox.Show("Failed to load profile information.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Customer ID. Please enter a valid ID.");
            }
        }

        private void frmDisplayR_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
