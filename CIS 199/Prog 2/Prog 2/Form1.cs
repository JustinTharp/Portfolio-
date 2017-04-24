// Justin Tharp
// Program 2
// Due Date: March 9, 2015
// CIS 199-01
// This program allows the user to select their year and enter their last name to determine what day and time they will be eligible
// to register for the next semester's classes. It works by sorting each student first by which year they are in (which radio button
// they select) and then uses character variables to determine when they can register based on the name they enter in the textbox.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
        }
        // Program runs when the submit button is clicked.
        private void submitbutton_Click(object sender, EventArgs e)
        {
            // If statement to determine if the textbox is empty.
            if (string.IsNullOrEmpty(lastnametextBox.Text))
            {
                MessageBox.Show("Please enter your last name."); // If textbox is empty, show messagebox.
            }
            else // Otherwise, run program.
            {
                char letter; // Define standard variable for letter. 
                letter = 'y';

                // String text from textbox as name.
                string name = lastnametextBox.Text;

                // Define variable letter equal to the first character extracted from text.
                letter = name[0];

                // Convert any text entered to uppercase so it is compatible with the program.
                letter = char.ToUpper(letter);

                // Define each character variable.
                // Make each character variable equal to the letter it defines. 
                char letterA;
                letterA = 'A';

                char letterB;
                letterB = 'B';

                char letterC;
                letterC = 'C';

                char letterD;
                letterD = 'D';

                char letterE;
                letterE = 'E';

                char letterF;
                letterF = 'F';

                char letterG;
                letterG = 'G';

                char letterI;
                letterI = 'I';

                char letterJ;
                letterJ = 'J';

                char letterL;
                letterL = 'L';

                char letterM;
                letterM = 'M';

                char letterO;
                letterO = 'O';

                char letterP;
                letterP = 'P';

                char letterQ;
                letterQ = 'Q';

                char letterR;
                letterR = 'R';

                char letterS;
                letterS = 'S';

                char letterT;
                letterT = 'T';

                char letterV;
                letterV = 'V';

                char letterW;
                letterW = 'W';

                char letterZ;
                letterZ = 'Z';

               
                // If senior button is checked...
                if (seniorradioButton.Checked)
                {
                    if (letter >= letterT && letter <= letterZ) // If first letter is T, Z or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 1  8:30am"); // Display messagebox. 
                    }
                    else if (letter >= letterA && letter <= letterD) // if not, If first letter is A, D or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 1  10:00am"); // Display messagebox.
                    }
                    else if (letter >= letterE && letter <= letterI) // if not, If first letter is E, I or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 1  11:30am"); // Display messagebox. 
                    }
                    else if (letter >= letterJ && letter <= letterO) // if not, If first letter is J, O or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 1  2:00pm"); // Display messagebox. 
                    }
                    else // Else (P, S or inbetween.)
                    {
                        MessageBox.Show("Wednesday, April 1  4:00pm"); // Display messagebox. 
                    }
                }
                // If junior button is checked...
                else if (juniorradioButton.Checked)
                {
                    if (letter >= letterT && letter <= letterZ) // If first letter is T, Z or inbetween...
                    {
                        MessageBox.Show("Thursday, April 2  8:30am"); // Display messagebox.
                    }
                    else if (letter >= letterA && letter <= letterD) // if not, If first letter is A, D or inbetween...
                    {
                        MessageBox.Show("Thursday, April 2  10:00am"); // Display messagebox.
                    }
                    else if (letter >= letterE && letter <= letterI) // if not, If first letter is E, I or inbetween...
                    {
                        MessageBox.Show("Thursday, April 2  11:30am"); // Display messagebox.
                    }
                    else if (letter >= letterJ && letter <= letterO) // if not, If first letter is J, O or inbetween...
                    {
                        MessageBox.Show("Thursday, April 2  2:00pm"); // Display messagebox.
                    }
                    else // Else (P, S or inbetween)
                    {
                        MessageBox.Show("Thursday, April 2  4:00pm"); // Display messagebox.
                    }
                }
                // If sophomore button is checked...
                else if (sophomoreradioButton.Checked)
                {
                    if (letter >= letterT && letter <= letterV) // If first letter is T, V or inbetween...
                    {
                        MessageBox.Show("Friday, April 3  8:30am"); // Display messagebox.
                    }
                    else if (letter >= letterW && letter <= letterZ) // if not, If first letter is W, Z or inbetween...
                    {
                        MessageBox.Show("Friday, April 3  10:00am"); // Display messagebox.
                    }
                    else if (letter >= letterA && letter <= letterB) // if not, If first letter is A or B...
                    {
                        MessageBox.Show("Friday, April 3  11:30am"); // Display messagebox.
                    }
                    else if (letter >= letterC && letter <= letterD) // if not, If first letter is C or D...
                    {
                        MessageBox.Show("Friday, April 3  2:00pm"); // Display messagebox.
                    }
                    else if (letter >= letterE && letter <= letterF) // if not, If first letter is E or F...
                    {
                        MessageBox.Show("Friday, April 3  4:00pm"); // Display messagebox.
                    }
                    else if (letter >= letterG && letter <= letterI) // if not, If first letter is G, I or inbetween...
                    {
                        MessageBox.Show("Monday, April 6  8:30am"); // Display messagebox.
                    }
                    else if (letter >= letterJ && letter <= letterL) // if not, If first letter is J, L or inbetween...
                    {
                        MessageBox.Show("Monday, April 6  10:00am"); // Display messagebox.
                    }
                    else if (letter >= letterM && letter <= letterO) // if not, If first letter is M, O or inbetween...
                    {
                        MessageBox.Show("Monday, April 6  11:30am"); // Display messagebox.
                    }
                    else if (letter >= letterP && letter <= letterQ) // if not, If first letter is P or Q...
                    {
                        MessageBox.Show("Monday, April 6  2:00pm"); // Display messagebox.
                    }
                    else // Else (R or S)
                    {
                        MessageBox.Show("Monday, April 6  4:00pm"); // Display messagebox.
                    }
                }
                // If none of above, Freshman button checked.
                else
                {
                    if (letter >= letterT && letter <= letterV) // If first letter is T, V or inbetween...
                    {
                        MessageBox.Show("Tuesday, April 7  8:30am"); // Display messagebox.
                    }
                    else if (letter >= letterW && letter <= letterZ) // if not, If first letter is W, Z or inbetween...
                    {
                        MessageBox.Show("Tuesday, April 7  10:00am"); // Display messagebox.
                    }
                    else if (letter >= letterA && letter <= letterB) // if not, If first letter is A or B...
                    {
                        MessageBox.Show("Tuesday, April 7  11:30am"); // Display messagebox.
                    }
                    else if (letter >= letterC && letter <= letterD) // if not, If first letter is C, or D...
                    {
                        MessageBox.Show("Tuesday, April 7  2:00pm"); // Display messagebox.
                    }
                    else if (letter >= letterE && letter <= letterF) // if not, If first letter is E or F...
                    {
                        MessageBox.Show("Tuesday, April 7  4:00pm"); // Display messagebox.
                    }
                    else if (letter >= letterG && letter <= letterI) // if not, If first letter is G, I or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 8  8:30am"); // Display messagebox.
                    }
                    else if (letter >= letterJ && letter <= letterL) // if not,If first letter is J, L or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 8  10:00am"); // Display messagebox.
                    }
                    else if (letter >= letterM && letter <= letterO) // if not, If first letter is M, O or inbetween...
                    {
                        MessageBox.Show("Wednesday, April 8  11:30am"); // Display messagebox.
                    }
                    else if (letter >= letterP && letter <= letterQ) // if not, If first letter is P, or Q...
                    {
                        MessageBox.Show("Wednesday, April 8  2:00pm"); // Display messagebox.
                    }
                    else // Else (R or S)
                    {
                        MessageBox.Show("Wednesday, April 8  4:00pm"); // Display messagebox.
                    }
                }
            }
        }
    }
}
