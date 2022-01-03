using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public partial class UnitConverter
    {

        public string ConvertWeight(int inStartUnit, int inEndUnit, double inStartWeight)
        {
            double endWeightVal = 0;
            string endWeight = "";

            switch (inStartUnit)
            {
                case 0:
                    // Convert from pounds
                    switch (inEndUnit)
                    {
                        case 0:
                            endWeight = inStartWeight + " lbs";
                            break;
                        case 1:
                            endWeightVal = inStartWeight * 16;
                            endWeight = endWeightVal + " oz";
                            break;
                        case 2:
                            endWeightVal = inStartWeight / 2.2046;
                            endWeight = endWeightVal + " kg";
                            break;
                        case 3:
                            endWeightVal = inStartWeight / 0.0022046;
                            endWeight = endWeightVal + " g";
                            break;
                    }
                    break;
                case 1:
                    // Convert from ounces
                    switch (inEndUnit)
                    {
                        case 0:
                            endWeightVal = inStartWeight / 16;
                            endWeight = endWeightVal + " lbs";
                            break;
                        case 1:
                            endWeight = inStartWeight + "oz";
                            break;
                        case 2:
                            endWeightVal = inStartWeight / 35.274;
                            endWeight = endWeightVal + " kg";
                            break;
                        case 3:
                            endWeightVal = inStartWeight / 0.035274;
                            endWeight = endWeightVal + " g";
                            break;
                    }
                    break;
                case 2:
                    // Convert from kilograms
                    switch (inEndUnit)
                    {
                        case 0:
                            endWeightVal = inStartWeight * 2.2046;
                            endWeight = endWeightVal + " lbs";
                            break;
                        case 1:
                            endWeightVal = inStartWeight * 35.274;
                            endWeight = endWeightVal + " oz";
                            break;
                        case 2:
                            endWeight = inStartWeight + " kg";
                            break;
                        case 3:
                            endWeightVal = inStartWeight * 1000;
                            endWeight = endWeightVal + " g";
                            break;
                    }
                    break;
                case 3:
                    // Convert from grams
                    switch (inEndUnit)
                    {
                        case 0:
                            endWeightVal = inStartWeight * 0.0022046;
                            endWeight = endWeightVal + " lbs";
                            break;
                        case 1:
                            endWeightVal = inStartWeight * 0.035274;
                            endWeight = endWeightVal + " oz";
                            break;
                        case 2:
                            endWeightVal = inStartWeight / 1000;
                            endWeight = endWeightVal + " kg";
                            break;
                        case 3:
                            endWeight = inStartWeight + " g";
                            break;
                    }
                    break;
            }

            return endWeight;

        }

    }
}
