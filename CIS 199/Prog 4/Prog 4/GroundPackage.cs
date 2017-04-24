// This file all creates a GroundPackage class that tracks info entered by the user in the textboxes from the GUI.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_4
{
    class GroundPackage
    {
        private int _OriginZip;// OriginZip variable
        private int _DestinationZip;// DestinationZip variable
        private double _Length;// Length variable
        private double _Width;// Width variable
        private double _Height;// Height variable
        private double _Weight;// Weight variable

        // Precondition: orZ= origin zip, destZ= destination zip, L= length, Wd= width, H= height, We= weight
        // Postcondition: Each parameter has been initialized with the values for each variable.
        public GroundPackage(int orZ, int destZ, double L, double Wd, double H, double We)
        {
            _OriginZip = orZ;
            _DestinationZip = destZ;
            _Length = L;
            _Width = Wd;
            _Height = H;
            _Weight = We;
        }

        // OriginZip property
        public int OriginZip
        {
            // Precondition: None
            // Postcondition: Get value of _OriginZip
            get { return _OriginZip; }

            // Precondition: 00000 < value < 99999
            // Postcondition: The origin zipcode has been set to the value.
            set
            {
                if (value > 00000 && value < 99999)
                    _OriginZip = value;
            }
        }

        // DestinationZip property
        public int DestinationZip
        {
            // Predcondition: None
            // Postcondition: Get value of _DestinationZip
            get { return _DestinationZip; }

            // Precondition: 00000 < value < 99999
            // Postcondition: The destination zipcode has been set to the value.
            set
            {
                if (value > 00000 && value < 99999)
                    _DestinationZip = value;
            }
        }

        // Length property
        public double Length
        {
            // Precondition: None
            // Postcondition: Get value of _Length
            get { return _Length; }

            // Precondition: > 0
            // Postcondition: The length has been set to the value.
            set
            {
                if (value > 0) 
                    _Length = value;
            }
        }

        // Width property
        public double Width
        {
            // Precondition: None
            // Postcondition: Get value of _Width
            get { return _Width; }

            // Precondition: > 0
            // Postcondition: The width has been set to the value.
            set
            {
                if (value > 0) 
                    _Width = value;
            }
        }

        // Height property
        public double Height
        {
            // Precondition: None
            // Postcondition: Get value of _Height
            get { return _Height; }

            // Precondition: > 0
            // Postcondition: The height has been set to the value.
            set
            {
                if (value > 0)
                    _Height = value;
            }
        }

        // Weight property
        public double Weight
        {
            // Precondition: None
            // Postcondition: Get value of _Weight
            get { return _Weight; }

            // Precondition: > 0
            // Postcondition: The weight has been set to the value.
            set
            {
                if (value > 0) 
                    _Weight = value;
            }
        }


        // ZoneDistance property
        public int ZoneDistance
        {
            // Precondition: None
            // Postcondition: Return abs value of originzip/10000 - destinationzip/10000
            get { return Math.Abs(OriginZip / 10000) - (DestinationZip / 10000); }
        }

        // Precondition: None
        // Postcondition: Return cost function as specified
        public double CalcCost()
        {
            double cost;
            return cost = 20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);
        }

        // Precondition: None
        // Postcondition: Return string of info specified
        public override string ToString()
        {
            string newString;
           newString= String.Format("Origin Zipcode: {0} Destination Zipcode: {1} Length: {2} Width: {3} Height: {4} Weight: {5}", 
               OriginZip, DestinationZip, Length, Width, Height, Weight);
           return newString;
        }
    }
}
