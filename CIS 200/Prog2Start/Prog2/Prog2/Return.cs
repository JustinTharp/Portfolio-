using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class Return : Form
    {

        List<LibraryItem> _returnedItems; // Variable to hold list item

        public Return(List<LibraryItem> returnedItems) // Parameterized constructor -returns list of items 
        {
            InitializeComponent();

            _returnedItems = returnedItems; // Item variable is eqivalent to parameter
        }
        
        internal int ReturnItemInput
        {
            // Precondition: None
            // Postcondition: Return item selected from the combo box
            get
            {
                return returnItemComboBox.SelectedIndex;
            }
        }

        // Precondition: Checkout ok button is clicked
        // Postcondition: Input is validated and the result is the ok
        private void returnItemButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Precondition: Return cancel button is clicked
        // Postcondition: Dialog box closes
        private void returnCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
            this.DialogResult = DialogResult.Cancel;
        }

        // Precondition: None
        // Postcondition: Dialog box loads with items from the list in the combo box
        private void Return_Load(object sender, EventArgs e)
        {
            foreach (var rComboBox in _returnedItems) // For each item in the list variable
                returnItemComboBox.Items.Add(rComboBox.Title + ", " + rComboBox.CallNumber); // Add item into the combo box by title
                                                                                             // and call number
        }


        // Precondition:  Attempting to change focus from returnItemComboBox
        // Postcondition: If item selected, focus will change
        private void returnItemComboBox_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the combo box is blank
            if (returnItemComboBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider1.SetError(returnItemComboBox, "Select an item!"); // Set error message
            }
        }

        // Precondition:  itemComboBox_Validating succeeded
        // Postcondition: Any error message set for itemComboBox is cleared -Focus is allowed to change
        private void returnItemComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(returnItemComboBox, ""); // Clears error message
        }
    }
}
