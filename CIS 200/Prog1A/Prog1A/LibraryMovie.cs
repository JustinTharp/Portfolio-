//Library Movie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    class LibraryMovie:LibraryMediaItem
    {
        public enum MPAARatings { G, PG, PG13, R, NC17, U }
        private MPAARatings _rating;
        private String _director;
        private const decimal _dvdVhsFEE = 1.00M;
        private const decimal _blurayFEE = 1.50M;

        public LibraryMovie(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod, 
            String theCallNumber, double theDuration, String theDirector, MediaType theMedium, MPAARatings theRating)
            :base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Director = theDirector;
            Rating = theRating;
        }

        public String Director
        {
            // Precondition: None
            // Postcondition: The director has been returned
            get
            {
                return _director;
            }

            // Precondition:  None
            // Postcondition: The director has been set to the specified value
            set
            {
                _director = value;
            }
        }

        public MediaType Medium
        {
            // Precondition: None
            // Postcondition: The medium has been returned
            get
            {
                return _medium;
            }

            // Precondition:  Medium = DVD, BLURAY, or VHS
            // Postcondition: The medium has been set to the specified value
            set
            {
                if(_medium == MediaType.DVD || _medium == MediaType.BLURAY || _medium == MediaType.VHS)
                    _medium = value;
                else throw new ArgumentOutOfRangeException("Must be DVD, BLURAY or VHS");
            }
        }

        public MPAARatings Rating
        {
            // Precondition: None
            // Postcondition: The rating has been returned
            get
            {
                return _rating;
            }

            // Precondition:  None
            // Postcondition: The rating has been set to the specified value
            set
            {
                _rating = value;
            }
        }

        public override decimal CalcLateFee(int dayslate)
        {
            if (_medium == MediaType.DVD || _medium == MediaType.VHS)
                return dayslate * _dvdVhsFEE;
            else
                return dayslate * _blurayFEE;
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary movie's data on separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{9}Publisher: {1}{9}Copyright: {2}{9}" +
                "Loan Period: {3}{9}Call Number: {4}{9}Duration: {5}{9}Director: {6}{9}Medium: {7}{9}Rating: {8}{9}",
                Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, Duration, Director, 
                Medium, Rating, System.Environment.NewLine);

            return result;
        }
    }
}
