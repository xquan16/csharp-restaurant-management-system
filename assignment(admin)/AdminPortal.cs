using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment_admin_
{
    public partial class AdminPortal: Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private Own cU;
        public AdminPortal(Own cUser)
        {
            InitializeComponent();
            this.cU = cUser;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Program.manageform.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Program.editown.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedbackForm = new Feedback();
            feedbackForm.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport salesReportForm = new SalesReport();
            salesReportForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.loginform.Show();
            this.Hide();
        }
    }
}
