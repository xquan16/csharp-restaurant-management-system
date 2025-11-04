using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment_admin_;

namespace assignment_admin_
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            menuBtn_Click(sender, e);

            DateTime today = DateTime.Today;
            DateTime firstDay = new DateTime(today.Year, today.Month, 1);
            dtPicker.Value = firstDay;
        }


        // profile update
        private void Nemailtxt_TextChanged(object sender, EventArgs e)
        {
            Hall hint = new Hall();
            hint.HintText(Nusertxt, NEWeLbl, "Enter new username");
        }


        private void Npwtxt_TextChanged(object sender, EventArgs e)
        {
            Hall hint = new Hall();
            hint.HintText(Npwtxt, NEWpLbl, "Enter new password");
            AcceptButton = doneBtn;
        }


        private Own cU = new Own();
        private void doneBtn_Click(object sender, EventArgs e)
        {
            string newUser = Nusertxt.Text.Trim();
            string newPw = Npwtxt.Text.Trim();

            if (string.IsNullOrEmpty(Nusertxt.Text))
            {
                MessageBox.Show("Please enter new username.", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Npwtxt.Text))
                MessageBox.Show("Please enter new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                try
                {
                    cU.UpdateProfile(newUser, newPw);  // update new username and password into database

                    var userDetails = cU.GetUserDetails();  // renew username
                    currentU.Text = $"Current Username: {userDetails.oldN}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
                finally
                {
                    Nusertxt.Clear();
                    Npwtxt.Clear();
                }
            }
        }




        //
        // sidebar control
        //
        private void sidebarBtn_Click_1(object sender, EventArgs e)
        {
            if (sidebarContainer.Width != sidebarContainer.MaximumSize.Width)
                sidebarContainer.Width = sidebarContainer.MaximumSize.Width;
            else
                sidebarContainer.Width = sidebarContainer.MinimumSize.Width;
        }


        //
        // profile button timer
        //
        bool profileBtnOpen;  // is it expanded or not
        private void profileTimer_Tick(object sender, EventArgs e)
        {
            if (profileBtnOpen)
            {
                profileContainer.Height -= 2000;
                if (profileContainer.Height == profileContainer.MinimumSize.Height)
                {
                    profileBtnOpen = false;
                    profileTimer.Stop();
                }
            }
            else
            {
                profileContainer.Height += 10;
                if (profileContainer.Height == profileContainer.MaximumSize.Height)
                {
                    profileBtnOpen = true;
                    profileTimer.Stop();
                }
            }
        }

        private void profileContainer_MouseEnter(object sender, EventArgs e)
        {
            profileBtnOpen = false;
            profileTimer.Start();
        }

        private void profileContainer_MouseLeave(object sender, EventArgs e)
        {
            profileTimer.Stop();   // Ensure only one timer runs
            profileBtnOpen = true; // Set to expand
            profileTimer.Start();
        }





        // back to login page
        private void signoutBtn_Click(object sender, EventArgs e)
        {
            Program.loginform.Show();
            this.Hide();
        }



        // create a function set sidebar control penal visible = false
        private void HideAllPanels(Panel show)
        {
            menuPage.Visible = false;
            reservePage.Visible = false;
            hallPage.Visible = false;
            HalldetailP.Visible = false;
            editPage.Visible = false;

            show.Visible = true;
            show.BringToFront();
        }


        // sidebar button control
        private void menuBtn_Click(object sender, EventArgs e)
        {
            HideAllPanels(menuPage);
            tabsBtn1_Click(sender, e);

            this.Text = "Menu Categories";
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            HideAllPanels(reservePage);
            tickBtn_Click(sender, e);

            this.Text = "Reservation Report";
        }

        private void hallBtn_Click(object sender, EventArgs e)
        {
            HideAllPanels(hallPage);
            hallSidePanel(imgHall);
            halls.RefreshDGV(hallDGV);

            this.Text = "Hall Detail";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            HideAllPanels(editPage);
            this.Text = "Edit Profile";

            var userDetails = cU.GetUserDetails(); // get user details store in tuple

            string username = userDetails.oldN;
            string password = userDetails.oldP;

            currentU.Text = $"Current Username: {username}";
        }







        //
        // tabs(button) control method
        private void tabsColor(Button btn)
        {

            //menu categories
            tabsBtn1.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn2.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn3.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn4.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn5.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn6.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn7.BackColor = Color.FromArgb(255, 192, 128);
            tabsBtn8.BackColor = Color.FromArgb(255, 192, 128);

            //hall
            SMALL.BackColor = Color.FromArgb(255, 192, 128);
            SMALL.ForeColor = SystemColors.ActiveBorder;
            MEDIUM.BackColor = Color.FromArgb(255, 192, 128);
            MEDIUM.ForeColor = SystemColors.ActiveBorder;
            LARGE.BackColor = Color.FromArgb(255, 192, 128);
            LARGE.ForeColor = SystemColors.ActiveBorder;


            btn.BackColor = Color.FromArgb(255, 192, 192);  //active button color
            btn.ForeColor = Color.Black;  //active button text color
        }


        private void tabsBtn1_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn1);
            MenuItem categories = new MenuItem(tabsBtn1.Tag.ToString());  // create object get table name (pre-set table name for each categories button)
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn1.Tag.ToString();   // update button tag (this button go to crud.cs form)
        }

        private void tabsBtn2_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn2);
            MenuItem categories = new MenuItem(tabsBtn2.Tag.ToString());
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn2.Tag.ToString();
        }

        private void tabsBtn3_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn3);
            MenuItem categories = new MenuItem(tabsBtn3.Tag.ToString());
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn3.Tag.ToString();
        }

        private void tabsBtn4_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn4);
            MenuItem categories = new MenuItem(tabsBtn4.Tag.ToString());
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn4.Tag.ToString();
        }

        private void tabsBtn5_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn5);
            MenuItem categories = new MenuItem(tabsBtn5.Tag.ToString());
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn5.Tag.ToString();
        }

        private void tabsBtn6_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn6);
            MenuItem categories = new MenuItem(tabsBtn6.Tag.ToString());
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn6.Tag.ToString();
        }

        private void tabsBtn7_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn7);
            MenuItem categories = new MenuItem(tabsBtn7.Tag.ToString());
            categories.RefreshDGV(menuDGV);
            
            upBtn.Tag = tabsBtn7.Tag.ToString();
        }

        private void tabsBtn8_Click(object sender, EventArgs e)
        {
            tabsColor(tabsBtn8);
            MenuItem categories = new MenuItem(tabsBtn8.Tag.ToString());
            categories.RefreshDGV(menuDGV);

            upBtn.Tag = tabsBtn8.Tag.ToString();
        }



        private void A1_Click(object sender, EventArgs e)
        {
            MenuItem passTb = new MenuItem(upBtn.Tag.ToString());  // get table name
            crud crudForm = new crud(passTb); // pass object to crud form (pass the table name)

            crudForm.Show();
            this.Hide();
        }





        private void HideTabsPanels(Panel show)
        {
            //hall 
            sPanel.Visible = false;
            mPanel.Visible = false;
            lPanel.Visible = false;

            show.Visible = true;
            show.BringToFront();
        }

        // hall detail 
        private Hall halls = new Hall();
        private void SMALL_Click(object sender, EventArgs e)
        {
            tabsColor(SMALL);
            HideTabsPanels(sPanel);

            halls.HallInfo("Hana Kiri Suite");
            halls.Show(h1Lbl);
            halls.HallInfo("Yuzen Dining Room");
            halls.Show(h2Lbl);
        }

        private void MEDITATION_Click(object sender, EventArgs e)
        {
            tabsColor(MEDIUM);
            HideTabsPanels(mPanel);

            halls.HallInfo("Kaze Private Dining");
            halls.Show(h3Lbl);
            halls.HallInfo("Takekage Room");
            halls.Show(h4Lbl);
        }

        private void LARGE_Click_1(object sender, EventArgs e)
        {
            tabsColor(LARGE);
            HideTabsPanels(lPanel);

            halls.HallInfo("Fujisakura Room");
            halls.Show(h5Lbl);
        }

        private void backBtn_Click(object sender, EventArgs e)  //button (image)
        {
            hallBtn_Click(sender, e);
        }



        // hall crud page
        private void hallSidePanel(Panel show)
        {
            // hall page side panel
            imgHall.Visible = false;
            crudHall.Visible = false;
            addHall.Visible = false;
            editHall.Visible = false;
            deleteHall.Visible = false;

            show.Visible = true;
            show.BringToFront();
        }


        private void IMGhallBtn_Click(object sender, EventArgs e)
        {
            HideAllPanels(HalldetailP);

            SMALL_Click(sender, e);
        }


        private void udHalBtn_Click(object sender, EventArgs e)
        {
            hallSidePanel(crudHall);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            hallSidePanel(imgHall);
        }

        private void addHBtn_Click(object sender, EventArgs e)
        {
            hallSidePanel(addHall);
            ADDtxt1.Focus();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            hallSidePanel(crudHall);
            ADDtxt1.Clear();
            ADDtxt2.Clear();
            ADDcombox.SelectedIndex = -1;
        }

        private void editHBtn_Click(object sender, EventArgs e)
        {
            hallSidePanel(editHall);
            EDITtxt1.Focus();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            hallSidePanel(crudHall);
            EDITtxt1.Clear();
            EDITtxt2.Clear();
            EDITtxt3.Clear();
            EDITcombox.SelectedIndex = -1;
        }

        private void deleteHBtn_Click(object sender, EventArgs e)
        {
            hallSidePanel(deleteHall);
            DELETEtxt1.Focus();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            hallSidePanel(crudHall);
            DELETEtxt1.Clear();
        }



        // textbox hint text control
        private void ADDtxt1_TextChanged(object sender, EventArgs e)
        {
            halls.HintText(ADDtxt1, ADDlbl1, "Hall Name...");
        }

        private void ADDtxt2_TextChanged(object sender, EventArgs e)
        {
            halls.HintText(ADDtxt2, ADDlbl2, "Capacity...");
        }

        private void ADDcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ADDcombox.SelectedIndex == -1) // No selection
            {
                ADDlbl3.Text = "Party Type...";
            }
            else
            {
                ADDlbl3.Text = "";
            }
        }
      

        private void EDITtxt1_TextChanged(object sender, EventArgs e)
        {
            halls.HintText(EDITtxt1, EDITlbl1, "Enter ID that want to edit");
            AcceptButton = findHALL;
        }

        private void EDITtxt2_TextChanged(object sender, EventArgs e)
        {
            halls.HintText(EDITtxt2, EDITlbl2, "Hall Name...");
        }

        private void EDITtxt3_TextChanged(object sender, EventArgs e)
        {
            halls.HintText(EDITtxt3, EDITlbl3, "Capacity...");
        }

        private void EDITcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EDITcombox.SelectedIndex == -1) // No selection
            {
                EDITlbl4.Text = "Party Type...";
            }
            else
            {
                EDITlbl4.Text = "";
            }
        }



        private void DELETEtxt1_TextChanged(object sender, EventArgs e)
        {
            halls.HintText(DELETEtxt1, DELETElbl1, "Enter ID that want to delete");
            AcceptButton = btnDELETE;
        }


        // hall crud ==> update to database
        private void upADD_Click(object sender, EventArgs e)
        {
            halls.add(ADDtxt1, ADDtxt2, ADDcombox, hallDGV);
            hallSidePanel(imgHall);
        }

        private void findHALL_Click(object sender, EventArgs e)
        {
            halls.findEdit(EDITtxt1, EDITtxt2, EDITtxt3, EDITcombox, hallDGV);
        }

        private void doneEDIT_Click(object sender, EventArgs e)
        {
            halls.edit(EDITtxt1, EDITtxt2, EDITtxt3, EDITcombox, hallDGV);
            hallSidePanel(imgHall);
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (halls.findDelete(DELETEtxt1, showInfo) == true)
            {
                halls.delete(DELETEtxt1, showInfo, hallDGV);
                hallSidePanel(imgHall);
            }
            else 
            {
                hallSidePanel(imgHall);
                return;            
            }
        }






        // reservation report
        Reservation_Q report = new Reservation_Q();
        private void filterBtn_Click(object sender, EventArgs e)  // filter function button
        {
            Fby.Visible = true;
            Fby.BringToFront();
        }

        private void monthBtn_Click(object sender, EventArgs e)
        {
            Fby.Visible = false;
            selectMonth.Visible = true;
            selectMonth.Focus();
            selectMonth.BringToFront();
        }

        private void statusBtn_Click(object sender, EventArgs e)  // reservation type button
        {
            Fby.Visible = false;
            byMLbl.Visible = true;
            byMLbl.Text = "By reservation type";
            byMLbl.BringToFront();

            monthR.Visible = false;
            report.refreshRT(reportDGV);
            report.reportRT(rtR, r1, r2, r3);

        }

        private void backF_Click(object sender, EventArgs e)
        {
            selectMonth.Visible = false;
            Fby.Visible = true;
        }


        private void tickBtn_Click(object sender, EventArgs e)  // year, month button
        {
            byMLbl.Visible = true;
            byMLbl.Text = "By year, month";
            byMLbl.BringToFront();

            rtR.Visible = false;
            selectMonth.Visible = false;

            report.refreshM(reportDGV, dtPicker);
            report.reportMonth(monthR, dtPicker, rLbl1y, rLbl1, rLbl2, rLbl3);
        }
    }
}