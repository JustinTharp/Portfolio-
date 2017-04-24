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
    public partial class NewPatron : Form
    {
        public NewPatron()
        {
            InitializeComponent();
        }

        internal string PatronNameInput
        {
            // Precondition: None
            // Postcondition: Return text from the patronName textbox
            get 
            { 
                return patronNameTextBox.Text; 
            }  
        }

        internal string PatronIDInput
        {
            // Precondition: None
            // Postcondition: Return text from the patronId textbox
            get 
            { 
                return patronIdTextBox.Text;
            }
        }

        // Precondition: Patron ok button is clicked
        // Postcondition: Input is validated and the result is the ok
        private void patronOkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Precondition: Patron cancel button is clicked
        // Postcondition: Dialog box closes
        private void patronCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // If it was a left-click, cancel
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  Attempting to change focus from patronNameText
        // Postcondition: If name entered, focus will change
        private void patronNameText_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the text box is blank
            if (patronNameTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider1.SetError(patronNameTextBox, "Enter a patron name!"); // Set error message
            }
        }

        // Precondition:  patronNameText validating succeeded
        // Postcondition: Any error message set for patronNameText is cleared
        private void patronNameText_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronNameTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from patronIDText
        // Postcondition: If ID entered, focus will change
        private void patronIDText_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the text box is blank
            if (patronIdTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider2.SetError(patronIdTextBox, "Enter a patron ID!"); // Set error message
            }
        }

        // Precondition:  patronIdText validating succeeded
        // Postcondition: Any error message set for patronIdText is cleared
        private void patronIDText_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(patronIdTextBox, ""); // Clears error message
        }
    }
}
