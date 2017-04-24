//Library Music
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
   public class LibraryMusic:LibraryMediaItem
    {

       private String _artist;
       private int _numberoftracks;
       private const decimal _musicMediaFEE = .50M;

        public LibraryMusic(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod, 
            String theCallNumber, double theDuration, String theArtist, MediaType theMedium, int theNumberofTracks)
            :base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Artist = theArtist;
            NumberofTracks = theNumberofTracks;
        }

        public String Artist
        {
            // Precondition: None
            // Postcondition: The artist has been returned
            get
            {
                return _artist;
            }

            // Precondition:  None
            // Postcondition: The artist has been set to the specified value
            set
            {
                _artist = value;
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

            // Precondition:  Medium = CD, SACD or VINYL
            // Postcondition: The medium has been set to the specified value
            set
            {
                if (_medium == MediaType.CD || _medium == MediaType.SACD || _medium == MediaType.VINYL)
                    _medium = value;
                else throw new ArgumentOutOfRangeException("Must be CD, SACD or VINYL");
            }
        }

        public int NumberofTracks
        {
            // Precondition: None
            // Postcondition: The number of tracks has been returned
            get
            {
                return _numberoftracks;
            }

            // Precondition:  None
            // Postcondition: The number of tracks has been set to the specified value
            set
            {
                _numberoftracks = value;
            }
        }

        public override decimal CalcLateFee(int dayslate)
        {

            if (dayslate * _musicMediaFEE < 20.00M)
                return dayslate * _musicMediaFEE;
            else
                Console.WriteLine("Over Limit");
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary music's data on separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{9}Publisher: {1}{9}Copyright: {2}{9}" +
                "Loan Period: {3}{9}Call Number: {4}{9}Duration: {5}{9}Artist: {6}{9}Medium: {7}{9}NumberofTracks: {8}{9}",
                Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, Duration, Artist,
                Medium, NumberofTracks, System.Environment.NewLine);

            return result;
        }
    }
}
