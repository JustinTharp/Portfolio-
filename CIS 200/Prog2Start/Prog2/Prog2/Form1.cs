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
    public partial class Form1 : Form
    {
        private Library _lib; // Creates private library variable

        public Form1()
        {
            InitializeComponent();

            _lib = new Library(); // Creates the new library

            // Insert library item test data into library
            _lib.AddLibraryBook("C# for Winners", "UofL Press", 2008, 16, "JK335 4H", "Andrew Wright");
            _lib.AddLibraryBook("Hydra's Book of Secrets", "Hydra", 1994, 21, "HD000 1K", "Stephen Kendra");
            _lib.AddLibraryMovie("Rum is Key", "Cap'n Morgan", 2003, 13, "1-800-RUMGOOD", 6, "Me", 
                LibraryMediaItem.MediaType.DVD,LibraryMovie.MPAARatings.R);
            _lib.AddLibraryMovie("UK Greatest Moments", "Kentucky Athletics", 2015, 15, "006-CATSWIN", 8, "John Calipari", 
                LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.G);
            _lib.AddLibraryMusic("Medcare Greatest Hits", "Medcare", 2016, 11, "1-800-MEDFIRE", 5, "ASAP Bern", 
                LibraryMediaItem.MediaType.CD, 30);
            _lib.AddLibraryMusic("Ogre Beats", "Shrek", 2000, 17, "234-OLONION", 3, "Shrek", LibraryMediaItem.MediaType.VINYL, 5);
            _lib.AddLibraryJournal("Mass Effect Journal", "The Alliance", 2006, 9, "597-0567", 4, 36, "Science", "The Commander");
            _lib.AddLibraryJournal("Trump the Barbarian", "USA Today", 2016, 6, "298-0002", 5, 12, "Politics", "Marco Rubio");
            _lib.AddLibraryMagazine("How to Get Fat Quick", "Pawnee Journal", 2010, 7, "612-0534", 3, 24);
            _lib.AddLibraryMagazine("Swanson Guide to Manliness", "Swanson Magazine", 1999, 4, "248-0175", 5, 23);

            // Insert Patron test data
            _lib.AddPatron("Senor Soloman", "00056");
            _lib.AddPatron("Stephen Kendra", "39056");
            _lib.AddPatron("Justin Tharp", "29017");
            _lib.AddPatron("Carlos", "50278");
            _lib.AddPatron("Jacob God", "00000");
            _lib.AddPatron("John Calipari", "11111");
        }

        // Precondition: The about tool strip menu item is clicked
        // Postcondition: A messagebox is displayed with information about the program.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show messagge box
            MessageBox.Show("Justin Tharp" + System.Environment.NewLine + "CIS 200-01" + System.Environment.NewLine
                + "Program 2" + System.Environment.NewLine + "Due: 3/10/16","Program Information");
        }

        // Precondition: The exit tool strip menu item is clicked
        // Postcondition: The application closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close application
        }

        // Precondition: The patron list tool strip menu item is clicked
        // Postcondition: The patrons in the library are displayed in the textbox along with the count of patrons
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtextBox.Text = string.Empty; // Empties the textbox

            outputtextBox.Text = _lib.GetPatronCount().ToString() + System.Environment.NewLine; // Sets the textbox to display 
                                                                                                // the count of library patrons

            foreach (LibraryPatron p in _lib.GetPatronsList()) // For each patron in the list
            {
                outputtextBox.AppendText(p.ToString()+ System.Environment.NewLine); // Append the text
                outputtextBox.AppendText(System.Environment.NewLine); // Generate new line
            }
        }

        // Precondition: The item list tool strip menu item is clicked
        // Postcondition: The items in the library are displayed in the textbox along with the count of items
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtextBox.Text = string.Empty; // Empties the textbox

            outputtextBox.Text = _lib.GetItemCount().ToString() + System.Environment.NewLine; // Sets the textbox to display the 
                                                                                              // count of library items

            foreach (LibraryItem i in _lib.GetItemsList()) // For each items in the list
            {
                outputtextBox.AppendText(i.ToString()+ System.Environment.NewLine); // Append the text
                outputtextBox.AppendText(System.Environment.NewLine); // Generate new line
            }
        }

        // Precondition: The checkedout items tool strip menu item has been clicked
        // Postcondition: The checkedout items are displayed in the textbox along with the count of checked out items
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputtextBox.Text = string.Empty; // Empties the textbox

            foreach (LibraryItem c in _lib.GetItemsList()) // Get each item in the list
            {
                if (c.IsCheckedOut()) // If it is checked out
                {
                    outputtextBox.AppendText(c.ToString() + System.Environment.NewLine); // Append the text
                    outputtextBox.AppendText(System.Environment.NewLine); // Generate new line
                }
            }
        }


        // Precondition: The patron tool strip menu item has been clicked
        // Postcondition: The patron dialog box is displayed. User must enter a patron, and the patron is added to the library.
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatron newPatron = new NewPatron(); // The dialog box form to add patron
            DialogResult result;                   // The result from the dialog box
            string patronName;                     // User's input for name
            string patronId;                       // User's input for ID
           

            result = newPatron.ShowDialog();       // Generates dialog box to add patron

            if (result == DialogResult.OK) // Only update if Ok was selected from dialog box
            {
                patronName = newPatron.PatronNameInput; // Retrieve name from dialog box
                patronId = newPatron.PatronIDInput; // Retrieve ID from dialog box

                _lib.AddPatron(patronName, patronId); // Add the new patron to the library
            }
        }


        // Precondition: The book tool strip menu item has been clicked
        // Postcondition: The book dialog box is displayed. User must enter a book, and the book is added to the library.
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBook newBook = new NewBook(); // The dialog box form to add book
            DialogResult result;             // The result from the dialog box
            string bookTitle;                // User's input for title
            string bookPublisher;            // User's input for publisher
            int bookCopyright;               // User's input for copyright
            int bookLoanPeriod;              // User's input for loan period
            string bookCallNumber;           // User's input for call number
            string bookAuthor;               // User's input for author

            result = newBook.ShowDialog();   // Generates dialog box to add book

            if (result == DialogResult.OK) // Only update if Ok was selected from dialog box
            {
                bookTitle = newBook.BookTitleInput;                       // Retrieve title from dialog box
                bookPublisher = newBook.BookPublisherInput;               // Retrieve publisher from dialog box
                bookCopyright = int.Parse(newBook.BookCopyrightInput);    // Retrieve copyright from dialog box(must be parsed)
                bookLoanPeriod = int.Parse(newBook.BookLoanPeriodInput);  // Retrieve loan period from dialog box(must be parsed)
                bookCallNumber = newBook.BookCallNumberInput;             // Retrieve call number from dialog box
                bookAuthor = newBook.BookAuthorInput;                     // Retrieve author from dialog box

                // Add the new book to the library
                _lib.AddLibraryBook(bookTitle, bookPublisher, bookCopyright, bookLoanPeriod, bookCallNumber, bookAuthor); 
            }
        }


        // Precondition: The check out items tool strip menu item has been clicked
        // Postcondition: The check out dialog box is opened. The items available for checkout and patrons 
        // that could check them out are displayed in the combo box and once selected, are added to the checked out report
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut newCheckout = new CheckOut(_lib._items, _lib._patrons); // The dialog box form to check out items
            DialogResult result;                 // The result from the dialog box
            int itemCheckOut;                    // User's item selection
            int patronCheckout;                  // User's patron selection
           
            result = newCheckout.ShowDialog();   // Generates dialog box to check out items

            if (result == DialogResult.OK) // Only updated if Ok was selected from dialog box
            {
                itemCheckOut = newCheckout.ItemSelectedInput; // Retrieve item selected from dialog box
                patronCheckout = newCheckout.PatronSelectedInput; // Retrieve patron selected from dialog box

                // Check out item
                _lib.CheckOut(itemCheckOut, patronCheckout);
            }
        }


        // Precondition: The return items tool strip menu item has been clicked
        // Postcondition: The return dialog box is opened. The items available for return are displayed in the combo box 
        // and once selected, are returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return newReturn = new Return(_lib._items); // The dialog box form to return items
            DialogResult result;                // The result from the dialog box
            int itemReturn;                     // User's item selection

            result = newReturn.ShowDialog();    // Generates dialog box to return items

            if (result == DialogResult.OK) // Only updated if Ok was selected from dialog box
            {
                itemReturn = newReturn.ReturnItemInput; // Retrieve item selected from the dialog box

                // Return item
                _lib.ReturnToShelf(itemReturn);
            }
        }
    }
}
