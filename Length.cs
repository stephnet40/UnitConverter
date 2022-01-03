using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public partial class UnitConverter
    {

        public string ConvertLength(int inStartUnit, int inEndUnit, double inStartLength)
        {
            double endLengthVal = 0;
            string endLength = "";

            switch (inStartUnit)
            {
                case 0:
                    // Convert from inches
                    switch (inEndUnit)
                    {
                        case 0:
                            endLength = inStartLength + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength / 12;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength / 36;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength / (5280 * 12);
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength / 0.03937;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength / 0.3937;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength / 39.37;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 39370;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 1:
                    // Convert from feet
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * 12;
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLength = inStartLength + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength / 3;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength / 5280;
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength / 0.0032808;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength / 0.032808;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength / 3.2808;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 3280.8;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 2:
                    // Convert from yards
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * 36;
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength * 3;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLength = inStartLength + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength / 1760;
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength / 0.0010936;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength / 0.010936;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength / 1.0936;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 1093.6;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 3:
                    // Convert from miles
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * (5280 * 12);
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength * 5280;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength * 1760;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLength = inStartLength + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength / 0.00000062137;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength / 0.0000062137;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength / 0.00062137;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 0.62137;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 4:
                    // Convert from millimeters
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * 0.03937;
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength * 0.0032808;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength * 0.0010936;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength * 0.00000062137;
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLength = inStartLength + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength / 10;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength / 1000;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 1000000;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 5:
                    // Convert from centimeters
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * 0.3937;
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength * 0.032808;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength * 0.010936;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength * 0.0000062137;
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength * 10;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLength = inStartLength + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength / 100;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 100000;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 6:
                    // Convert from meters
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * 39.37;
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength * 3.2808;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength * 1.0936;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength * 0.00062137;
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength * 1000;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength * 100;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLength = inStartLength + " m";
                            break;
                        case 7:
                            endLengthVal = inStartLength / 1000;
                            endLength = endLengthVal + " km";
                            break;
                    }
                    break;
                case 7:
                    // Convert from kilometers
                    switch (inEndUnit)
                    {
                        case 0:
                            endLengthVal = inStartLength * 39370;
                            endLength = endLengthVal + " in";
                            break;
                        case 1:
                            endLengthVal = inStartLength * 3280.8;
                            endLength = endLengthVal + " ft";
                            break;
                        case 2:
                            endLengthVal = inStartLength * 1093.6;
                            endLength = endLengthVal + " yd";
                            break;
                        case 3:
                            endLengthVal = inStartLength * 0.62137;
                            endLength = endLengthVal + " mi";
                            break;
                        case 4:
                            endLengthVal = inStartLength * 1000000;
                            endLength = endLengthVal + " mm";
                            break;
                        case 5:
                            endLengthVal = inStartLength * 100000;
                            endLength = endLengthVal + " cm";
                            break;
                        case 6:
                            endLengthVal = inStartLength * 1000;
                            endLength = endLengthVal + " m";
                            break;
                        case 7:
                            endLength = inStartLength + " km";
                            break;
                    }
                    break;
            }

            return endLength;

        }

    }
}
