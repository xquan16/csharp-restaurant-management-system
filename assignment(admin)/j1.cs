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
using static assignment_admin_.UpdatePfrm;

namespace assignment_admin_
{
    public partial class reservationfrm : Form
    {

        public reservationfrm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDisplayR form4 = new frmDisplayR();
            form4.Show();
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddRfrm form2 = new AddRfrm();
            form2.Show();
            this.Hide();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdatePfrm form3 = new UpdatePfrm();
            form3.Show();
            this.Hide();
        }


        private void Viewbtn_Click(object sender, EventArgs e)
        {
            CustomerR form5 = new CustomerR();  
            form5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.loginform.Show();
            this.Hide();
        }
    }
}
