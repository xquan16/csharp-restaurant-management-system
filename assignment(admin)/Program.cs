using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_admin_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string CurrentUsername { get; set; }


        // admin
        public static AdminPortal adminform;
        public static Form1 loginform;
        public static ManageUserPortal manageform;
        public static AddPortal addform;
        public static EditPortal editform;
        public static UpdateOwn editown;

        // manager
        public static menu menuForm;

        // chef
        public static chef Chef;

        // reservation coordinator
        public static reservationfrm j1;

        // customer
        public static k2 customer;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // admin
            adminform = new AdminPortal();
            loginform = new Form1();
            manageform = new ManageUserPortal();
            addform = new AddPortal(manageform);
            editform = new EditPortal(manageform, 0, "defaultUser", "defaultPass", "defaultRole");
            editown = new UpdateOwn();

            // manager
            menuForm = new menu();

            // chef
            Chef = new chef();

            // reservation coordinator
            j1 = new reservationfrm();

            // customer
            customer = new k2();


            //Application.Run(new Form1());
            Application.Run(new k3());
        }
    }
}
