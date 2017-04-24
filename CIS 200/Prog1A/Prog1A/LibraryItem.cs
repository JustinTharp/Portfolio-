//Library Item Hierarchy
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    public abstract class LibraryItem
    {
        public const int DEFAULT_YEAR = 2015; // Default copyright year

        private String _title;
        private String _publisher;
        private int _copyrightYear;
        private int _loanPeriod;
        private String _callNumber;
        private bool _checkedOut;
        private LibraryPatron _patron;

        public LibraryItem(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod, String theCallNumber)
        {
            // Establish default first in case invalid
            CopyrightYear = DEFAULT_YEAR;

            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            LoanPeriod = theLoanPeriod;
            CallNumber = theCallNumber;

            ReturnToShelf(); // Make sure the book isn't checked out. 
        }


        public String Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  None
            // Postcondition: The title has been set to the specified value
            set
            {
                _title = value;
            }
        }

        public String Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                _publisher = value;
            }
        }

        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _copyrightYear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
            }
        }

        public int LoanPeriod
        {
            // Precondition: None
            // Postcondition: The loan period has been returned
            get
            {
                return _loanPeriod;
            }

            // Precondition:  value >= 0
            // Postcondition: The loan period has been set to the specified value
            set
            {
                if (value >= 0)
                    _loanPeriod = value;
            }
        }

        public String CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callNumber;
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                _callNumber = value;
            }
        }

        public LibraryPatron Patron
        {
            // Precondition:  IsCheckedOut() == true
            // Postcondition: The patron that has the item checked out is returned
            //                (otherwise null)
            get
            {
                return _patron;
            }

            // HELPER - not public
            // Precondition:  None
            // Postcondition: The associated patron value is stored
            private set
            {
                _patron = value;
            }
        }

        // Precondition:  None
        // Postcondition: The item is checked out by thePatron
        public void CheckOut(LibraryPatron thePatron)
        {
            _checkedOut = true;
            Patron = thePatron;
        }

        // Precondition:  None
        // Postcondition: The item is not checked out (by any patron)
        public void ReturnToShelf()
        {
            _checkedOut = false;
            Patron = null; // No longer associated with anyone
        }

        // Precondition:  None
        // Postcondition: true is returned if the item is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return _checkedOut;
        }

        public abstract decimal CalcLateFee(int dayslate);

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{5}Publisher: {1}{5}Copyright: {2}{5}" +
                "Loan Period: {3}{5}Call Number: {4}{5}",
                Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, System.Environment.NewLine);

            if (IsCheckedOut())
                result += String.Format("Checked Out By: {1}{0}", Patron, System.Environment.NewLine);
            else
                result += "Not Checked Out";

            return result;
        }


    }
}
