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
    public partial class crud: Form
    {
        private MenuItem tb;

        public crud(MenuItem tableName)  // get MenuItem object (tableName)
        {
            InitializeComponent();
            this.tb = tableName;  // passed tableName to the private field tb
        }


        private void crud_Load(object sender, EventArgs e)
        {
            PanelShow(ADDp, ADD); 
            this.Text = tb.TableName;   // set form title = table/categories that get from MenuItem object
        }


        // back to menu form
        private void back()
        {
            Program.menuForm.Show();
            this.Hide();
        }
       

        private void AbackBtn_Click(object sender, EventArgs e)
        {
            back();
        }

        private void EbackBtn_Click(object sender, EventArgs e)
        {
            back();
        }

        private void DbackBtn_Click(object sender, EventArgs e)
        {
            back();
        }

        private void SbackBtn_Click(object sender, EventArgs e)
        {
            back();
        }



        // show panel (add, edit, delete, show)
        public void PanelShow(Panel p, Button b)
        {
            ADDp.Visible = false;
            EDITp.Visible = false;
            DELETEp.Visible = false;
            SEARCHp.Visible = false;

            ADD.BackColor = Color.FromArgb(255, 192, 128);
            EDIT.BackColor = Color.FromArgb(255, 192, 128);
            DELETE.BackColor = Color.FromArgb(255, 192, 128);
            SEARCH.BackColor = Color.FromArgb(255, 192, 128);

            ADD.ForeColor = SystemColors.ActiveBorder;
            EDIT.ForeColor = SystemColors.ActiveBorder;
            DELETE.ForeColor = SystemColors.ActiveBorder;
            SEARCH.ForeColor = SystemColors.ActiveBorder;

            p.Visible = true;
            b.BackColor = Color.FromArgb(255, 192, 192);
            b.ForeColor = Color.Black;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            PanelShow(ADDp, ADD);
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            PanelShow(EDITp, EDIT);
            tb.RefreshDGV(editDGV);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            PanelShow(DELETEp, DELETE);
            tb.RefreshDGV(deleteDGV);
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            PanelShow(SEARCHp, SEARCH);
            tb.RefreshDGV(searchDGV);
        }

        // update into table
        private void AaddBtn_Click(object sender, EventArgs e)
        {
            tb.Add(itemTxt, priceTxt, Acheckb);
            menu m = new menu();
            m.Show();
            this.Close();
        }


        private void showBtn_Click(object sender, EventArgs e)
        {
            tb.findEdit(Convert.ToInt32(EidTxt.Text), EitemTxt, EpriceTxt, Echeckb);
        }

        private void EeditBtn_Click(object sender, EventArgs e)
        {
            tb.Update(EidTxt, EitemTxt, EpriceTxt, Echeckb, editDGV);
        }

        private void DdeleteBtn_Click(object sender, EventArgs e)
        {
            tb.Delete(DidTxt, deleteDGV);
            menu m = new menu();
            m.Show();
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            tb.Search(searchTxt, searchDGV);
        }

        private void EidTxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = findBtn;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = searchBtn;
        }
    }
}
