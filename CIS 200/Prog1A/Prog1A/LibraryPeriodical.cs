//Library Periodical
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    public abstract class LibraryPeriodical : LibraryItem
    {

        private int _volume;
        private int _number;

        public LibraryPeriodical(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod, 
            String theCallNumber, int theVolume, int theNumber):base(theTitle, thePublisher, theCopyrightYear, 
            theLoanPeriod, theCallNumber)
        {
            Volume = theVolume;
            Number = theNumber;
        }

        public int Volume
        {
            // Precondition: None
            // Postcondition: The volume has been returned
            get
            {
                return _volume;
            }

            // Precondition:  value >= 0
            // Postcondition: The volume has been set to the specified value
            set
            {
                if (value >= 0)
                    _volume = value;
            }
        }

        public int Number
        {
            // Precondition: None
            // Postcondition: The number has been returned
            get
            {
                return _number;
            }

            // Precondition:  value >= 0
            // Postcondition: The number has been set to the specified value
            set
            {
                if (value >= 0)
                    _number = value;
                else throw new ArgumentOutOfRangeException("Number can not be negative");
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary periodical's data
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{7}Publisher: {1}{7}Copyright: {2}{7}" +
                "Loan Period: {3}{7}Call Number: {4}{7}Volume: {5}{7}Number:{6}{7}",
                Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, Volume, Number, System.Environment.NewLine);

            return result;
        }
    }
}
