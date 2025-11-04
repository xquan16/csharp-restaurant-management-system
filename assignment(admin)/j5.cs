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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment_admin_
{
    public partial class CustomerR : Form
    {
        private ViewRequests VRequests;
        public CustomerR()
        {
            InitializeComponent();
            VRequests = new ViewRequests("");
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            reservationfrm form1 = new reservationfrm();
            form1.Show();
            this.Close();
        }


        private void CustomerR_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstViewR.Items.Clear();

            //get data from database and display it in the listview
            var confirmedRequests = VRequests.GetConfirmedRequests();

            if (confirmedRequests != null && confirmedRequests.Count > 0)
            {
                foreach (var request in confirmedRequests)
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
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (lstViewR.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstViewR.SelectedItems[0];  // get selected row

                int requestId = int.Parse(selectedItem.SubItems[0].Text);  // extract id

                VRequests.UpdateRequestStatus(requestId, "Confirmed");  // update status in database

                selectedItem.SubItems[5].Text = "Confirmed";     // update UI

                MessageBox.Show("Request confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a request to confirm.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
