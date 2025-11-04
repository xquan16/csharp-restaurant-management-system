using Microsoft.Win32;
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
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace assignment_admin_
{
    public partial class ManageUserPortal: Form
    {
        public ManageUserPortal()
        {
            InitializeComponent();
            this.Load += ManageUserPortal_Load; // when the form loads, ManaagePortal_Load will be executed (+=, subscribe)
        }
        private void ManageUserPortal_Load(object sender, EventArgs e)
        {
            LoadUsers();
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
        }

        public void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString()))
            {
                string query = "SELECT MemberID, Username, Password, Role FROM Members";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dgvMembers.DataSource = dt; 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DataGridViewRow selectedRow = dgvMembers.SelectedRows[0];

            
            if (selectedRow.Cells["MemberID"].Value == null)
            {
                MessageBox.Show("Invalid selection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int memberId;
            if (!int.TryParse(selectedRow.Cells["MemberID"].Value.ToString(), out memberId))
            {
                MessageBox.Show("Error retrieving user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string username = selectedRow.Cells["Username"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string role = selectedRow.Cells["Role"].Value.ToString();

                UserManager userManager = new UserManager(memberId, username, password, role);

                bool deleted = userManager.DeleteUser(memberId);

                if (deleted)
                {
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers(); 
                }
                else
                {
                    MessageBox.Show("Error deleting user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                int memberID = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["MemberID"].Value);
                string username = dgvMembers.SelectedRows[0].Cells["Username"].Value.ToString();
                string password = dgvMembers.SelectedRows[0].Cells["Password"].Value.ToString(); // Fetch password
                string role = dgvMembers.SelectedRows[0].Cells["Role"].Value.ToString();

                EditPortal editPortal = new EditPortal(this, memberID, username, password, role);
                editPortal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPortal addPortal = new AddPortal(this);
            addPortal.Show();
            this.Hide();
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backMU_Click(object sender, EventArgs e)
        {
            Program.adminform.Show();
            this.Hide();
        }
    }
}
