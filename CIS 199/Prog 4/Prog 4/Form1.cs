// Justin Tharp
// CIS 199-01
// Prog 4
// Due Date: 4/26/2015
// This program allows a user to enter information about a package (which then is stored in a class called GroundPackage) and
// based off the info entered, a cost of shipping is calculated and displayed in a listbox. The user can then a details button to see the
// the specific info about the package they entered. (This is done through a string method in the GroundPackage class.) The user can also
// set the package to be sent to or from U of L, which changes the price. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_4
{
    public partial class Prog4 : Form
    {
        // List created from info entered through the GUI and tracked through the GrounPackage class
        List<GroundPackage> GroundPackageList = new List<GroundPackage>();

        // Precondition: None
        // Postcondition: Form is constructed and ready to display
        public Prog4()
        {
            InitializeComponent();
        }

        // Precondition: AddPackage button is clicked
        // Postcondition: If an item entered by the user does not match 
           // the type of the variable for the specified textbox, display
           // error message, otherwise run. 
        private void addPackagebutton_Click(object sender, EventArgs e)
        {
            int originZip; // Origin zipcode variable
            int destinationZip; // Destination zipcode variable
            double length; // Length variable
            double width; // Width variable
            double height; // Height variable
            double weight; // Weight variable

            // Each item entered is tryparsed with the variable specified.
            if (int.TryParse(originZiptextBox.Text, out originZip) && int.TryParse(destinationZiptextBox.Text, out destinationZip)
                && double.TryParse(lengthtextBox.Text, out length) && double.TryParse(widthtextBox.Text, out width)
                && double.TryParse(heighttextBox.Text, out height) && double.TryParse(weighttextBox.Text, out weight))
            {
                if (originZip < 00000 || originZip > 99999)
                {
                    MessageBox.Show("Enter valid zipcode!");
                    return;
                }
                if (destinationZip < 00000 || destinationZip > 99999)
                {
                    MessageBox.Show("Enter valid zipcode!");
                    return;
                }
                if (length < 0)
                {
                    MessageBox.Show("Length must be > 0!");
                    return;
                }
                if (width < 0)
                {
                    MessageBox.Show("Width must be > 0!");
                    return;
                }
                if (height < 0)
                {
                    MessageBox.Show("Height must be > 0!");
                    return;
                }
                if (weight < 0)
                {
                    MessageBox.Show("Weight must be > 0!");
                    return;
                }
                 // Create mypackage object
                GroundPackage myGroundPackage = new GroundPackage(originZip, destinationZip, length, width, height, weight);

                // Add object to list
                GroundPackageList.Add(myGroundPackage);

                // Add object to listbox
                packagelistBox.Items.Add(myGroundPackage.CalcCost().ToString("c"));

                // Clear textboxes
                originZiptextBox.Clear();
                destinationZiptextBox.Clear();
                lengthtextBox.Clear();
                widthtextBox.Clear();
                heighttextBox.Clear();
                weighttextBox.Clear();

            }
            else
            {
                MessageBox.Show("Please enter values into each textbox!");
            }
        }

        // Precondition: Details button is clicked
        // Postcondition: If item in listbox is not  = -1, string, otherwise display error message
        private void detailsbutton_Click(object sender, EventArgs e)
        {
            int index = packagelistBox.SelectedIndex;// Selected listbox index = index

            if (index != -1)
            {
                MessageBox.Show(GroundPackageList[index].ToString());
            }
            else
            {
                MessageBox.Show("Please select package.");
            }
        }

        // Precondition: Send from UL button is clicked
        // Postcondition: If item in listbox is not = -1, set new zip, calc new cost and notify user, 
           // otherwise display error message
        private void sendfromULbutton_Click(object sender, EventArgs e)
        {
            int index = packagelistBox.SelectedIndex;// Selected listbox index = index

            if (index != -1)
            {
                GroundPackageList[index].OriginZip = 40292;
                packagelistBox.Items[index] = GroundPackageList[index].CalcCost().ToString("c");
                MessageBox.Show("Zip code has been modified.");
            }
            else
            {
                MessageBox.Show("Please select package.");
            }
        }

        // Precondition: Send to UL button is clicked
        // Postcondition: If item in listbox is not = -1, set new zip, calc new cost and notify user,
           // otherwise display error message
        private void sendtoULbutton_Click(object sender, EventArgs e)
        {

            int index = packagelistBox.SelectedIndex;// Selected listbox index = index

            if (index!= -1)
            {
                GroundPackageList[index].DestinationZip = 40292;
                packagelistBox.Items[index] = GroundPackageList[index].CalcCost().ToString("c");
                MessageBox.Show("Zip code has been modified.");
            }
            else
            { 
                MessageBox.Show("Please select package.");
            }
        }
    }
}
