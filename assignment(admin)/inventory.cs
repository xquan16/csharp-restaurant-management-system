using System;
using System.Data;
using System.Windows.Forms;
using assignment_admin_;

namespace assignment
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        // Load inventory data when the form loads
        private void inventory_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        // Helper method to refresh the DataGridView
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null; // Clear existing data
            dataGridView1.DataSource = InventoryItem.ViewAll(); // Use static method
        }


        // Add button click event (from addpanel)
        private void adddone_Click(object sender, EventArgs e)
        {
            string itemName = tbaname.Text;
            int quantity = int.Parse(tbaquantity.Text);
            decimal price = decimal.Parse(tbaprice.Text);

            InventoryItem newItem = new InventoryItem(itemName, quantity, price);
            if (newItem.AddItem())
            {
                MessageBox.Show("Item added successfully!");
                RefreshGrid();
                addpanel.Visible = false;
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed to add item.");
            }
        }

        // Delete button click event (from deletepanel)
        InventoryItem invty = new InventoryItem();
        private void tbddone_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the item with ID {tbdid.Text}？",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                invty.Delete(tbdid, dataGridView1);
                panel1.Visible = true;
                deletepanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Delete operation cancelled.", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Edit button click event (from editpanel)
        private void tbedone_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(tbeid.Text);
            string itemName = tbename.Text;
            int quantity = int.Parse(tbequantity.Text);
            decimal price = decimal.Parse(tbeprice.Text);

            InventoryItem itemToUpdate = new InventoryItem(itemId, itemName, quantity, price);
            if (itemToUpdate.UpdateItem())
            {
                MessageBox.Show("Item updated successfully!");
                RefreshGrid();
                editpanel.Visible = false; // Hide edit panel
                panel1.Visible = true;     // Show main panel
            }
            else
            {
                MessageBox.Show("Failed to update item.");
            }
        }

        // Existing panel navigation methods remain the same
        private void btnadd_Click(object sender, EventArgs e)
        {
            addpanel.Visible = true;
            panel1.Visible = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            editpanel.Visible = true;
            panel1.Visible = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            deletepanel.Visible = true;
            panel1.Visible = false;
        }

        // Back button clicks to return to main panel
        private void btaback_Click(object sender, EventArgs e)
        {
            addpanel.Visible = false;
            panel1.Visible = true;
        }

        private void bteback_Click(object sender, EventArgs e)
        {
            editpanel.Visible = false;
            panel1.Visible = true;
        }

        private void btdback_Click(object sender, EventArgs e)
        {
            deletepanel.Visible = false;
            panel1.Visible = true;
        }

        // Optional: Back to main page
        private void iibtnback_Click(object sender, EventArgs e)
        {
            chef chef = new chef();
            chef.Show();
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add any price text changed logic if needed
        }


        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    // Validate search input
        //    if (string.IsNullOrWhiteSpace(txtSearch.Text))
        //    {
        //        MessageBox.Show("Please enter an item ID to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtSearch.Focus();
        //        return;
        //    }

        //    // Try to parse the search input as an integer
        //    if (!int.TryParse(txtSearch.Text.Trim(), out int searchId))
        //    {
        //        MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtSearch.Clear();
        //        txtSearch.Focus();
        //        return;
        //    }

        //    // Attempt to find the item
        //    try
        //    {
        //        // Use the existing ViewItemById method to find the item
        //        InventoryItem foundItem = InventoryItem.ViewItemById(searchId);

        //        if (foundItem != null)
        //        {
        //            // Create a DataTable to display the result
        //            DataTable searchResultTable = new DataTable();
        //            searchResultTable.Columns.Add("Id", typeof(int));
        //            searchResultTable.Columns.Add("Name", typeof(string));
        //            searchResultTable.Columns.Add("Quantity", typeof(int));
        //            searchResultTable.Columns.Add("Price(RM)", typeof(decimal));

        //            // Add the found item to the DataTable
        //            searchResultTable.Rows.Add(
        //                foundItem.Id,
        //                foundItem.Name,
        //                foundItem.Quantity,
        //                foundItem.Price
        //            );

        //            // Update the DataGridView with search results
        //            dataGridView1.DataSource = searchResultTable;

        //            // Show success message
        //            MessageBox.Show($"Item found: {foundItem.Name}", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            // No item found
        //            MessageBox.Show($"No item found with ID {searchId}.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //            // Optionally, refresh the grid to show all items
        //            RefreshGrid();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any unexpected errors
        //        MessageBox.Show($"An error occurred during search: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        // Always clear the search text and return focus
        //        txtSearch.Clear();
        //        txtSearch.Focus();
        //    }
        //}
    }
}