using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_admin_
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }
        private void LoadFeedbackData()
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            string query = "SELECT Id, Feedback, TableNumber, FeedbackTime FROM Feedback";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                  
                    dgvFeedback.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backF_Click(object sender, EventArgs e)
        {
            Program.adminform.Show();
            this.Hide();
        }
    }
}

