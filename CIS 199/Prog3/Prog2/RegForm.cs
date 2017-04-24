// Justin Tharp
// Program 3
// Due Date: April 7, 2015
// CIS 199-01
// This program allows the user to enter their last name and select the year of school they are in and recieve what time
// they are scheduled to register for classes in the folowing semester. I edited this code which was originally Dr. Wright's
// to take out the if/else statements and achieve the same goal using arrays and range matching. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "April 1";  // 1st day of registration
            const string DAY2 = "April 2"; // 2nd day of registration
            const string DAY3 = "April 3"; // 3rd day of registration
            const string DAY4 = "April 6"; // 4th day of registration
            const string DAY5 = "April 7"; // 5th day of registration
            const string DAY6 = "April 8"; // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration

            lastNameStr = lastNameTxt.Text;

            if (lastNameStr == "") // Empty text box
                MessageBox.Show("Please enter last name!");
            else
            {
                lastNameLetterCh = lastNameStr[0]; // As in text, p. 466-467

                if (!char.IsLetter(lastNameLetterCh)) // Is it a letter or not?
                    MessageBox.Show("Please ensure a letter is in first position of last name!");
                else
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    

                    // Juniors and Seniors share same schedule but different days
                    if (juniorBtn.Checked || seniorBtn.Checked)
                    {
                        if (seniorBtn.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;

                    // Define an array for the junior/senior lower letter limits.
                    char[] juniorseniorLetter = {'A','E','J','P','T'};

                    // Define an array for the junior/senior times. 
                    string[] juniorseniorTimes = {TIME2,TIME3,TIME4,TIME5,TIME1};

                    // Declare an int variable for the length of the junior/senior letter - 1.
                    int index = juniorseniorLetter.Length - 1;

                        // Use a while loop to filter through the arrays as long as the length is >= 0 and 
                        // the last name entered does not equal what is in the array, until it does. 
                        while(index >= 0 && lastNameLetterCh <= juniorseniorLetter[index]) --index;

                        // Make outputlabel variable = the time extracted from the array. 
                        timeStr = juniorseniorTimes[index];

                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophBtn.Checked)
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;
                        }
                        else // must be freshman
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;
                        }

                        // Define an array for the freshman/sophomore lower letter limits.
                        char[] freshmansophomoreLetter = {'A','C','E','G','J','M','P','R','T','W'};

                        // Define an array for the freshman/sophomore times. 
                        string[] freshmansophomoretimes = { TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2 };

                        // Declare an int variable for the length of the freshman/sophomore letter - 1.
                        int index2 = freshmansophomoreLetter.Length - 1;

                            // Use a while loop to filter through the arrays as long as the length is >= 0 and 
                            // the last name entered does not equal what is in the array, until it does. 
                            while(index2 >= 0 && lastNameLetterCh <= freshmansophomoreLetter[index2]) --index2;

                            // Make outputlabel variable = the time extracted from the array.
                            timeStr = freshmansophomoretimes[index2];

                    }

                    dateTimeLbl.Text = dateStr + " at " + timeStr;
                }
            }
        }
    }
}
