//Library Book
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
   public class LibraryBook : LibraryItem
    {
        private String _author;
        private const decimal _bookFee = .25M;

        public LibraryBook(String theAuthor, String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod, 
            String theCallNumber):base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Author = theAuthor;
        }

        public String Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _author;
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                _author = value;
            }
        }

        public override decimal CalcLateFee(int dayslate)
        {
            return dayslate * _bookFee;
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary book's data
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Author: {0}{6}Title: {1}{6}Publisher: {2}{6}Copyright: {3}{6}" +
                "Loan Period: {4}{6}Call Number: {5}{6}",
                Author, Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, System.Environment.NewLine);

            return result;
        }
    }
}
