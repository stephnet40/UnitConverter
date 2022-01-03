using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public partial class UnitConverter
    {

        public string ConvertVolume(int inStartUnit, int inEndUnit, double inStartVolume)
        {
            double endVolumeVal = 0;
            string endVolume = "";

            switch (inStartUnit)
            {
                case 0:
                    // Convert from fluid ounces
                    switch (inEndUnit)
                    {
                        case 0:
                            endVolume = inStartVolume + " fl oz";
                            break;
                        case 1:
                            endVolumeVal = inStartVolume * 0.0625;
                            endVolume = endVolumeVal + " pt";
                            break;
                        case 2:
                            endVolumeVal = inStartVolume * 0.0078125;
                            endVolume = endVolumeVal + " gal";
                            break;
                        case 3:
                            endVolumeVal = inStartVolume / 0.033814;
                            endVolume = endVolumeVal + " mL";
                            break;
                        case 4:
                            endVolumeVal = inStartVolume / 0.33814;
                            endVolume = endVolumeVal + " cl";
                            break;
                        case 5:
                            endVolumeVal = inStartVolume / 33.814;
                            endVolume = endVolumeVal + " L";
                            break;
                    }
                    break;
                case 1:
                    // Convert from pints
                    switch (inEndUnit)
                    {
                        case 0:
                            endVolumeVal = inStartVolume * 16;
                            endVolume = endVolumeVal + " fl oz";
                            break;
                        case 1:
                            endVolume = inStartVolume + " pt";
                            break;
                        case 2:
                            endVolumeVal = inStartVolume * 0.125;
                            endVolume = endVolumeVal + " gal";
                            break;
                        case 3:
                            endVolumeVal = inStartVolume / 0.0021134;
                            endVolume = endVolumeVal + " mL";
                            break;
                        case 4:
                            endVolumeVal = inStartVolume / 0.021134;
                            endVolume = endVolumeVal + " cl";
                            break;
                        case 5:
                            endVolumeVal = inStartVolume / 2.1134;
                            endVolume = endVolumeVal + " L";
                            break;
                    }
                    break;
                case 2:
                    // Convert from gallons
                    switch (inEndUnit)
                    {
                        case 0:
                            endVolumeVal = inStartVolume * 128;
                            endVolume = endVolumeVal + " fl oz";
                            break;
                        case 1:
                            endVolumeVal = inStartVolume * 8;
                            endVolume = endVolumeVal + " pt";
                            break;
                        case 2:
                            endVolume = inStartVolume + " gal";
                            break;
                        case 3:
                            endVolumeVal = inStartVolume / 0.00026417;
                            endVolume = endVolumeVal + " mL";
                            break;
                        case 4:
                            endVolumeVal = inStartVolume / 0.0026417;
                            endVolume = endVolumeVal + " cl";
                            break;
                        case 5:
                            endVolumeVal = inStartVolume / 0.26417;
                            endVolume = endVolumeVal + " L";
                            break;
                    }
                    break;
                case 3:
                    // Convert from milliliters
                    switch (inEndUnit)
                    {
                        case 0:
                            endVolumeVal = inStartVolume * 0.033814;
                            endVolume = endVolumeVal + " fl oz";
                            break;
                        case 1:
                            endVolumeVal = inStartVolume * 0.0021134;
                            endVolume = endVolumeVal + " pt";
                            break;
                        case 2:
                            endVolumeVal = inStartVolume * 0.00026417;
                            endVolume = endVolumeVal + " gal";
                            break;
                        case 3:
                            endVolume = inStartVolume + " mL";
                            break;
                        case 4:
                            endVolumeVal = inStartVolume / 10;
                            endVolume = endVolumeVal + " cl";
                            break;
                        case 5:
                            endVolumeVal = inStartVolume / 1000;
                            endVolume = endVolumeVal + " L";
                            break;
                    }
                    break;
                case 4:
                    // Convert from centiliters
                    switch (inEndUnit)
                    {
                        case 0:
                            endVolumeVal = inStartVolume * 0.33814;
                            endVolume = endVolumeVal + " fl oz";
                            break;
                        case 1:
                            endVolumeVal = inStartVolume * 0.021134;
                            endVolume = endVolumeVal + " pt";
                            break;
                        case 2:
                            endVolumeVal = inStartVolume * 0.0026417;
                            endVolume = endVolumeVal + " gal";
                            break;
                        case 3:
                            endVolumeVal = inStartVolume * 10;
                            endVolume = endVolumeVal + " mL";
                            break;
                        case 4:
                            endVolume = inStartVolume + " cl";
                            break;
                        case 5:
                            endVolumeVal = inStartVolume / 100;
                            endVolume = endVolumeVal + " L";
                            break;
                    }
                    break;
                case 5:
                    // Convert from liters
                    switch (inEndUnit)
                    {
                        case 0:
                            endVolumeVal = inStartVolume * 33.814;
                            endVolume = endVolumeVal + " fl oz";
                            break;
                        case 1:
                            endVolumeVal = inStartVolume * 2.1134;
                            endVolume = endVolumeVal + " pt";
                            break;
                        case 2:
                            endVolumeVal = inStartVolume * 0.26417;
                            endVolume = endVolumeVal + " gal";
                            break;
                        case 3:
                            endVolumeVal = inStartVolume * 1000;
                            endVolume = endVolumeVal + " mL";
                            break;
                        case 4:
                            endVolumeVal = inStartVolume * 100;
                            endVolume = endVolumeVal + " cl";
                            break;
                        case 5:
                            endVolume = inStartVolume + " L";
                            break;
                    }
                    break;
            }

            return endVolume;

        }

    }
}
