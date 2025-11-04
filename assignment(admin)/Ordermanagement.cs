using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace assignment_admin_
{
    public partial class Ordermanagement : Form
    {
        private ordereditor orderEditor;

        public Ordermanagement()
        {
            InitializeComponent();
            orderEditor = new ordereditor();
            LoadOrders();
        }

        // Load orders into DataGridView
        private void LoadOrders()
        {
            try
            {
                var dataTable = orderEditor.GetAllOrders();
                if (dataTable != null)
                {
                    dataGridView1.DataSource = dataTable;
                    // Format the DataGridView
                    if (dataGridView1.Columns["Id"] != null)
                        dataGridView1.Columns["Id"].Width = 50;
                    if (dataGridView1.Columns["TableNumber"] != null)
                        dataGridView1.Columns["TableNumber"].Width = 100;
                    if (dataGridView1.Columns["OrderName"] != null)
                        dataGridView1.Columns["OrderName"].Width = 150;
                    if (dataGridView1.Columns["Quantity"] != null)
                        dataGridView1.Columns["Quantity"].Width = 80;
                    if (dataGridView1.Columns["TotalPrice"] != null)
                        dataGridView1.Columns["TotalPrice"].Width = 100;
                    if (dataGridView1.Columns["OrderTime"] != null)
                        dataGridView1.Columns["OrderTime"].Width = 120;
                }
                else
                {
                    MessageBox.Show("No data available to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void maip_Click(object sender, EventArgs e)
        {
            maippanel.Show();
            maippanel.BringToFront();
            textBox1.Clear();
        }

        private void mac_Click(object sender, EventArgs e)
        {
            macpanel.Show();
            macpanel.BringToFront();
            tbmac.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chef chef = new chef();
            chef.Show();
            this.Close();
        }

        private void Ordermanagement_Load(object sender, EventArgs e)
        {
            maippanel.Hide();
            macpanel.Hide();
            orderpanel.Show();
            LoadOrders();
        }

        private void maipback_Click(object sender, EventArgs e)
        {
            orderpanel.Show();
            orderpanel.BringToFront();
        }

        private void maipdone_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int orderId))
            {
                if (orderEditor.OrderExists(orderId))
                {
                    // Highlight the row in the DataGridView (no database update needed)
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Id"].Value != null &&
                            Convert.ToInt32(row.Cells["Id"].Value) == orderId)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        }
                    }
                    MessageBox.Show("Order marked as in progress successfully!");
                    orderpanel.Show();
                    orderpanel.BringToFront();
                }
                else
                {
                    MessageBox.Show($"Order ID {orderId} not found. Please ensure the ID exists in the database.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Order ID.");
            }
        }

        private void macback_Click(object sender, EventArgs e)
        {
            orderpanel.Show();
            orderpanel.BringToFront();
        }

        private void macdone_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbmac.Text, out int orderId))
            {
                if (orderEditor.MarkAsComplete(orderId))
                {
                    LoadOrders();
                    MessageBox.Show("Order marked as complete and removed successfully!");
                    orderpanel.Show();
                    orderpanel.BringToFront();
                }
                else
                {
                    MessageBox.Show($"Order ID {orderId} not found. Please ensure the ID exists in the database.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Order ID.");
            }
        }
    }
}