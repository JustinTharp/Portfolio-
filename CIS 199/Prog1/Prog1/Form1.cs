// Justin Tharp
// Prog 1
// Due Date: February 16, 2014
// CIS 199-01
// This program allows the user to enter 
//  1. the number of square feet they want painted 
//  2. the number of coats necessary to complete the job
//  3. the price per gallon of paint
// These imputs are then thrown into a series of calculations to determine the total cost of a paint job 
// provided by a certain paint company along with other outputs. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Allows "Calculate" button to be clicked to run the program. 
        private void calcbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables: Allow us to perform calculations easier.
                const int squareftpergallon = 325; // Defines the constant of 325 square feet.
                const int hoursworked = 8; // Defines the constant of 8 hours worked.
                const double costperhour = 10.50; // Defines the constant of the cost of labor per hour. 

                double squarefeet; // Defines what is entered in the textbox "Square feet" as a double. 
                int numberofcoats; // Defines what is entered in the textbox "Number of coats" as an int.
                double priceofpaintpergallon; // Defines what is entered in the textbox "Price per gallon" as a double.

                double totalsquareft; // Defines "Total Square Feet" as a double. 
                double numberofgallons; // Defines "Number of Gallons" as a double. 
                double hoursoflabor; // Defines "Hours of Labor" as a double. 
                double costofpaint; // Defines "Cost of Paint" as a double. 
                double costoflabor; // Defines "Cost of Labor" as a double. 
                double totalcost; // Defines "Total Cost" as a double. 

                squarefeet = double.Parse(squarefeetTextbox.Text); // Changes whats is entered in the textbox "Square feet" to a double.
                numberofcoats = int.Parse(numberofcoatsTextbox.Text); // Changes what is entered in the textbox "Number of coats" to a double. 
                priceofpaintpergallon = double.Parse(pricepergallonTextbox.Text); // Changes what is entered in the textbox "Price per gallon" to a double. 
                
                // Perform calculations for each output required. 
                totalsquareft = numberofcoats * squarefeet;
                numberofgallons = Math.Ceiling(totalsquareft / squareftpergallon);
                hoursoflabor = (totalsquareft / squareftpergallon) * hoursworked;
                costofpaint = numberofgallons * priceofpaintpergallon;
                costoflabor = costperhour * hoursoflabor;
                totalcost = costofpaint + costoflabor;

                // Show outputs for each calculation in output labels.
                totalsquarefeetoutputLabel.Text = totalsquareft.ToString("n1");
                numberofgallonsoutputLabel.Text = numberofgallons.ToString("");
                hoursoflaboroutputLabel.Text = hoursoflabor.ToString("n1");
                costofpaintoutputLabel.Text = costofpaint.ToString("c");
                costoflaboroutputLabel.Text = costoflabor.ToString("c");
                totalcostoutputLabel.Text = totalcost.ToString("c"); 
            }
            catch (Exception) // Used to catch any invalid data entered and not allow outputs to show. 
            {
            }
        }
    }
}
