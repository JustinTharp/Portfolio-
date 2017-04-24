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
    public partial class CheckOut : Form
    {

        List<LibraryItem> _items; // Variable to hold list item
        List<LibraryPatron> _patrons; // Variable to hold list patron

        public CheckOut(List<LibraryItem> items, List<LibraryPatron> patrons) // Paramterized constructor -returns library list
        {
            InitializeComponent();

            _items = items; // Item variable is equivalent to parameter
            _patrons = patrons; // Patron variable is equivalent to parameter
        }

        internal int ItemSelectedInput
        {
            // Precondition: None
            // Postcondition: Return index of item selected from the combo box
            get
            {
                return itemComboBox.SelectedIndex;
            }
        }

        internal int PatronSelectedInput
        {
            // Precondition: None
            // Postcondition: Return index of patron selected from the combo box
            get
            {
                return patronComboBox.SelectedIndex;
            }
        }

        // Precondition: Checkout ok button is clicked
        // Postcondition: Input is validated and the result is the ok
        private void checkoutOkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Precondition: Checkout cancel button is clicked
        // Postcondition: Dialog box closes
        private void checkoutCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
            this.DialogResult = DialogResult.Cancel;
        }


        // Precondition: None
        // Postcondition: Dialog box loads with items and patrons from the list in the combo boxes
        private void CheckOut_Load(object sender, EventArgs e)
        {
            foreach (var iComboBox in _items) // For each item in the list variable
                itemComboBox.Items.Add(iComboBox.Title + ", " + iComboBox.CallNumber); // Add item to the combo box by title and
                                                                                       // call number

            foreach (var iComboBox2 in _patrons) // For each patron in the list variable
                patronComboBox.Items.Add(iComboBox2.PatronName + ", " + iComboBox2.PatronID); // Add patron to the combo box by
                                                                                              // name and ID
        }


        // Precondition:  Attempting to change focus from itemComboBox
        // Postcondition: If item selected, focus will change
        private void itemComboBox_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the combo box is blank
            if (itemComboBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider1.SetError(itemComboBox, "Select an item!"); // Set error message
            }
        }

        // Precondition:  itemComboBox_Validating succeeded
        // Postcondition: Any error message set for itemComboBox is cleared -Focus is allowed to change
        private void itemComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemComboBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from patronComboBox
        // Postcondition: If patron selected, focus will change
        private void patronComboBox_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the combo box is blank
            if (patronComboBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider2.SetError(patronComboBox, "Select a patron!"); // Set error message
            }
        }

        // Precondition:  patronComboBox_Validating succeeded
        // Postcondition: Any error message set for patronComboBox is cleared -Focus is allowed to change
        private void patronComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(patronComboBox, ""); // Clears error message
        }
    }
}
