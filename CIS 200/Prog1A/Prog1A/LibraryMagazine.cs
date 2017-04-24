//Library Magazine
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
   public class LibraryMagazine:LibraryPeriodical
    {

       private const decimal _periodicalFee = .25M;

        public LibraryMagazine(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
           String theCallNumber, int theVolume, int theNumber)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod,theCallNumber, theVolume, theNumber)
        {
        }

        public override decimal CalcLateFee(int dayslate)
        {

            if (dayslate * _periodicalFee < 20.00M)
                return dayslate * _periodicalFee;
            else
                Console.WriteLine("Over Limit");
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary magazines's data
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
