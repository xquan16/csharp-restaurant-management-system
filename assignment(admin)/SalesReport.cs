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
    public partial class SalesReport: Form
    {
        private FilterReport report;
        public SalesReport()
        {
            InitializeComponent();
            report = new FilterReport();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            FilterReport report = new FilterReport();
            dgvSales.DataSource = report.FilteredData("Month");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FilterReport report = new FilterReport();
            dgvSales.DataSource = report.FilteredData("Category");
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            FilterReport report = new FilterReport();
            dgvSales.DataSource = report.FilteredData("Chef");
        }

        private void grpBoxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void backSR_Click(object sender, EventArgs e)
        {
            Program.adminform.Show();
            this.Hide();
        }
    }
}
