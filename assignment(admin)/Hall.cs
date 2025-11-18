using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;
using System.IO.Ports;

namespace assignment_admin_
{
    public class Hall
    {
        private int id;
        private string hallName;
        private int capacity;
        private string partyType;

        public int Id { get => id; set => id = value; }
        public string HallName { get => hallName; set => hallName = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string PartyType { get => partyType; set => partyType = value; }


        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }


        private static void ExecuteNonQuery(string query, Action<SqlCommand> parameterSetter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        parameterSetter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Validate(TextBox hallN, TextBox capacity, ComboBox partyT)
        {
            if (string.IsNullOrWhiteSpace(hallN.Text))
                MessageBox.Show("Hall name cannot be empty.", "Error");

            if (!int.TryParse(capacity.Text, out int cap) || cap <= 0)
                MessageBox.Show("Capacity must be a valid number greater than 0.", "Error");

            if (partyT.SelectedIndex == -1)
                MessageBox.Show("Please select a party type.", "Error");
        }




        // hall details + image 
        public void HallInfo(string name)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT Id, HallName, Capacity, PartyType FROM dbo.Hall WHERE HallName = @HallName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HallName", name);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.id = Convert.ToInt32(reader["Id"]);
                                this.hallName = reader["HallName"].ToString();
                                this.capacity = Convert.ToInt32(reader["Capacity"]);
                                this.partyType = reader["PartyType"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Hall not found.", "Error");
                                this.hallName = "";
                                this.capacity = 0;
                                this.partyType = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load hall data: {ex.Message}", "Error");
                this.hallName = "";
                this.capacity = 0;
                this.partyType = "";
            }
        }


        public string Show(Label info)
        {
            return info.Text = $"Hall Name : {hallName}\r\n" +
                $"Party Type : {partyType}\r\n" +
                $"Capacity : {capacity}";
        }



        // textbox hint text
        public void HintText(TextBox txt, Label hint, string hintText)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                hint.Visible = true;
                hint.Text = hintText;
                hint.BringToFront();
            }
            else
            {
                hint.Visible = false;
                hint.Text = "";
            }
        }



        //crud hall
        public void RefreshDGV(DataGridView halldgv)
        {
            halldgv.Visible = true;
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT * FROM Hall";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    halldgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh hall data: {ex.Message}", "Error");
                return;
            }
        }


        public void add(TextBox hallN, TextBox capacity, ComboBox partyT, DataGridView dgv)  // add hall
        {
            Validate(hallN, capacity, partyT);

            int capacityValue;
            if (!int.TryParse(capacity.Text, out capacityValue))
                return;

            try
            {
                string query = "INSERT INTO dbo.Hall (HallName, Capacity, PartyType) VALUES (@HallName, @Capacity, @PartyType)";
                ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@HallName", hallN.Text);
                    cmd.Parameters.AddWithValue("@Capacity", capacityValue); // Use the parsed integer
                    cmd.Parameters.AddWithValue("@PartyType", partyT.SelectedItem.ToString());
                });

                MessageBox.Show("Hall added successfully.", "Success");
                RefreshDGV(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                hallN.Text = "";
                capacity.Text = "";
                partyT.SelectedIndex = -1;

            }
        }


        public void findEdit(TextBox ID, TextBox hallN, TextBox capacity, ComboBox partyT, DataGridView dgv)
        {
            try
            {
                if (!int.TryParse(ID.Text, out int hallId))
                {
                    MessageBox.Show("Please enter a valid ID number.", "Error");
                    return;
                }

                string query = "SELECT Id, HallName, Capacity, PartyType FROM dbo.Hall WHERE Id = @Id";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", hallId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hallN.Text = reader["HallName"].ToString();
                                capacity.Text = reader["Capacity"].ToString();

                                string pt = reader["PartyType"].ToString();
                                if (partyT.Items.Contains(pt))
                                {
                                    partyT.SelectedItem = pt;
                                }
                                else
                                {
                                    partyT.Text = pt;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"No hall found with ID: {hallId}", "Not Found");
                                hallN.Text = "";
                                capacity.Text = "";
                                partyT.SelectedIndex = -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Find operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void edit(TextBox ID, TextBox hallN, TextBox capacity, ComboBox partyTypeCmb, DataGridView dgv)
        {
            try
            {
                Validate(hallN, capacity, partyTypeCmb);
                if (!int.TryParse(ID.Text, out int hallId))
                {
                    MessageBox.Show("Please enter a valid ID number.", "Error");
                    return;
                }

                int capacityValue;
                if (!int.TryParse(capacity.Text, out capacityValue))
                    return;

                string query = "UPDATE dbo.Hall SET HallName = @HN, Capacity = @C, PartyType = @PT WHERE Id = @Id";
                ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Id", hallId);
                    cmd.Parameters.AddWithValue("@HN", hallN.Text);
                    cmd.Parameters.AddWithValue("@C", capacityValue);
                    cmd.Parameters.AddWithValue("@PT", partyTypeCmb.SelectedItem.ToString());
                });
                MessageBox.Show("Hall updated successfully.", "Success");
                RefreshDGV(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ID.Text = "";
                hallN.Text = "";
                capacity.Text = "";
                partyTypeCmb.SelectedIndex = -1;
            }
        }


        public void findDelete(TextBox ID, Label show)
        {
            try
            {
                if (!int.TryParse(ID.Text, out int hallId) || string.IsNullOrWhiteSpace(ID.Text))
                {
                    MessageBox.Show("Please enter a valid ID number.", "Error");
                    return;
                }

                string query = "SELECT Id, HallName, Capacity, PartyType FROM dbo.Hall WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", hallId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hallName = reader["HallName"].ToString();
                                int capacity = Convert.ToInt32(reader["Capacity"]);
                                string partyType = reader["PartyType"].ToString();

                                show.Text = $"Hall Name: {hallName}\n\nCapacity: {capacity}\n\nParty Type: {partyType}";
                            }
                            else
                            {
                                MessageBox.Show($"No hall found with ID: {hallId}", "Not Found");
                                show.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Find operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void delete(TextBox ID, Label show, DataGridView dgv)
        {
            if (MessageBox.Show("Are you sure you want to delete this hall?", "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;    // confirmation

            try
            {
                if (!int.TryParse(ID.Text, out int hallId) || string.IsNullOrWhiteSpace(ID.Text))
                {
                    MessageBox.Show("Please enter a valid ID number.", "Error");
                    return;
                }

                string query = "DELETE FROM dbo.Hall WHERE Id = @Id";
                ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Id", hallId);
                });

                MessageBox.Show("Hall deleted successfully.", "Success", MessageBoxButtons.OK);
                RefreshDGV(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ID.Text = "";
                show.Text = "";
            }
        }
    }
}
