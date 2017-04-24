//Library Media Item
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    public abstract class LibraryMediaItem:LibraryItem
    {

        private double _duration;

        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }
        public MediaType _medium;

        public LibraryMediaItem(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod, 
            String theCallNumber, double theDuration):base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Duration = theDuration;
        }

        public double Duration
        {
            // Precondition: None
            // Postcondition: The duration has been returned
            get
            {
                return _duration;
            }

            // Precondition:  value >= 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value >= 0)
                    _duration = value;
                else throw new ArgumentOutOfRangeException("Duration can not be negative");
            }
        }

        public abstract MediaType Medium 
        {
            // Precondition: None
            // Postcondition: The medium has been returned
            get
            {
                return _medium;
            }

            // Precondition:  None
            // Postcondition: The medium has been set to the specified value
            set
            {
                _medium = value;
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary media item's data on separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{6}Publisher: {1}{6}Copyright: {2}{6}" +
                "Loan Period: {3}{6}Call Number: {4}{6}Duration: {5}{6}",
                Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, Duration, System.Environment.NewLine);

            return result;
        }
    }
}
