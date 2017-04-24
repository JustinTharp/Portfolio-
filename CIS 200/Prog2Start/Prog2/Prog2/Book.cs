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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        internal string BookTitleInput
        {
            // Precondition: None
            // Postcondition: Return text from the bookTitle textbox
            get
            {
                return bookTitleTextBox.Text;
            }
        }

        internal string BookPublisherInput
        {
            // Precondition: None
            // Postcondition: Return text from the bookPublisher textbox
            get
            {
                return bookPublisherTextBox.Text;
            }
        }

        internal string BookCopyrightInput
        {
            // Precondition: None
            // Postcondition: Return text from the bookCopyright textbox
            get
            {
                return bookCopyrightTextBox.Text;
            }
        }

        internal string BookLoanPeriodInput
        {
            // Precondition: None
            // Postcondition: Return text from the bookLoanPeriod textbox
            get
            {
                return bookLoanPeriodTextBox.Text;
            }
        }

        internal string BookCallNumberInput
        {
            // Precondition: None
            // Postcondition: Return text from the bookCallNumber textbox
            get
            {
                return bookCallNumberTextBox.Text;
            }
        }

        internal string BookAuthorInput
        {
            // Precondition: None
            // Postcondition: Return text from the bookAuthor textbox
            get
            {
                return bookAuthorTextBox.Text;
            }
        }

        // Precondition: Book ok button is clicked
        // Postcondition: Input is validated and the result is the ok
        private void bookOkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Precondition: Patron cancel button is clicked
        // Postcondition: Dialog box closes
        private void bookCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
            this.DialogResult = DialogResult.Cancel;
        }




        // VALIDATION


        // Precondition:  Attempting to change focus from bookTitleText
        // Postcondition: If title entered, focus will change
        private void bookTitleText_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the text box is blank
            if (bookTitleTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider1.SetError(bookTitleTextBox, "Enter a book title!"); // Set error message
            }
        }

        // Precondition:  bookTitleText validating succeeded
        // Postcondition: Any error message set for bookTitleText is cleared
        private void bookTitleText_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(bookTitleTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from bookPublisherText
        // Postcondition: If publisher entered, focus will change
        private void bookPublisherText_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the text box is blank
            if (bookPublisherTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider2.SetError(bookPublisherTextBox, "Enter a book publisher!"); // Set error message
            }
        }

        // Precondition:  bookPublisherText validating succeeded
        // Postcondition: Any error message set for bookPublisherText is cleared
        private void bookPublisherText_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(bookPublisherTextBox, ""); // Clears error message
        }

        
        // Precondition:  Attempting to change focus from bookCopyrightText
        // Postcondition: If entered value is valid int, focus will change, else focus will remain and error provider message set
        private void bookCopyrightText_Validating(object sender, CancelEventArgs e)
        {
            int copyrightNum; // Value entered into bookCopyrightText

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(bookCopyrightTextBox.Text, out copyrightNum))
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider3.SetError(bookCopyrightTextBox, "Enter an integer!"); // Set error message

                bookCopyrightTextBox.SelectAll(); // Select all text in bookCopyrightText to ease correction
            }
            else
            {
                if (copyrightNum < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to validated event

                    errorProvider3.SetError(bookCopyrightTextBox, "Enter a non-negative integer!"); // Set error message

                    bookCopyrightTextBox.SelectAll(); // Select all text in bookCopyrightText to ease correction
                }
            }
        }

        // Precondition:  bookCopyrightText_Validating succeeded
        // Postcondition: Any error message set for bookCopyrightText is cleared -Focus is allowed to change
        private void bookCopyrightText_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(bookCopyrightTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from bookLoanPeriodText
        // Postcondition: If entered value is valid int, focus will change, else focus will remain and error provider message set
        private void bookLoanPeriodText_Validating(object sender, CancelEventArgs e)
        {
            int loanPeriodNum; // Value entered into bookLoanPeriodText

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(bookLoanPeriodTextBox.Text, out loanPeriodNum))
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider4.SetError(bookLoanPeriodTextBox, "Enter an integer!"); // Set error message

                bookLoanPeriodTextBox.SelectAll(); // Select all text in bookLoanPeriodText to ease correction
            }
            else
            {
                if (loanPeriodNum < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to validated event

                    errorProvider4.SetError(bookLoanPeriodTextBox, "Enter a non-negative integer!"); // Set error message

                    bookLoanPeriodTextBox.SelectAll(); // Select all text in bookLoanPeriodText to ease correction
                }
            }
        }

        // Precondition:  bookLoanPeriodText_Validating succeeded
        // Postcondition: Any error message set for bookLoanPeriodText is cleared -Focus is allowed to change
        private void bookLoanPeriod_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(bookLoanPeriodTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from bookCallNumberText
        // Postcondition: If call number entered, focus will change
        private void bookCallNumberText_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the text box is blank
            if (bookCallNumberTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider5.SetError(bookCallNumberTextBox, "Enter a book call number!"); // Set error message
            }
        }

        // Precondition:  bookCallNumberText validating succeeded
        // Postcondition: Any error message set for bookCallNumberText is cleared
        private void bookCallNumberText_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(bookCallNumberTextBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from bookAuthorText
        // Postcondition: If author entered, focus will change
        private void bookAuthorText_Validating(object sender, CancelEventArgs e)
        {
            // If the text in the text box is blank
            if (bookAuthorTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to validated event

                errorProvider6.SetError(bookAuthorTextBox, "Enter a book author!"); // Set error message
            }
        }

        // Precondition:  bookAuthorText validating succeeded
        // Postcondition: Any error message set for bookAuthorText is cleared
        private void bookAuthorText_Validated(object sender, EventArgs e)
        {
            errorProvider6.SetError(bookAuthorTextBox, ""); // Clears error message
        }
    }
}
