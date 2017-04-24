//Library Journal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    public class LibraryJournal:LibraryPeriodical
    {

        private String _discipline;
        private String _editor;
        private const decimal _journalFee = .75M;

        public LibraryJournal(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
           String theCallNumber, int theVolume, int theNumber, String theDiscipline, String theEditor)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
            Discipline = theDiscipline;
            Editor = theEditor;
        }

        public String Discipline
        {
            // Precondition: None
            // Postcondition: The discipline has been returned
            get
            {
                return _discipline;
            }

            // Precondition:  None
            // Postcondition: The discipline has been set to the specified value
            set
            {
                _discipline = value;
            }
        }

        public String Editor
        {
            // Precondition: None
            // Postcondition: The editor has been returned
            get
            {
                return _editor;
            }

            // Precondition:  None
            // Postcondition: The editor has been set to the specified value
            set
            {
                _editor = value;
            }
        }

        public override decimal CalcLateFee(int dayslate)
        {
            return dayslate * _journalFee;
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary journals's data
        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{9}Publisher: {1}{9}Copyright: {2}{9}" +
                "Loan Period: {3}{9}Call Number: {4}{9}Volume: {5}{9}Number: {6}{9}Discipline: {7}{9}Editor {8}{9}",
                Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, Volume, Number, Discipline, Editor, System.Environment.NewLine);

            return result;
        }
    }
}
