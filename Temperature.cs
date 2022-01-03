using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public partial class UnitConverter
    {
        public double CheckKelvin(double inTempVal) // Makes sure Kelvin does not go below 0
        {
            if (inTempVal < 0)
            {
                inTempVal = 0;
            }

            return inTempVal;
        }

        public string ConvertTemp(int inStartUnit, int inEndUnit, double inStartTemp)
        {

            double endTempVal = 0;
            string endTemp = "";

            if (inStartUnit == 2)
            {
                inStartTemp = CheckKelvin(inStartTemp);
            }

            switch (inStartUnit)
            {
                case 0:
                    // Convert from Fahrenheit
                    switch (inEndUnit)
                    {
                        case 0:
                            endTemp = inStartTemp + " °F";
                            break;
                        case 1:
                            endTempVal = (inStartTemp - 32) * (5 / 9);
                            endTemp = endTempVal.ToString("N2") + " °C";
                            break;
                        case 2:
                            endTempVal = ((inStartTemp - 32) * (5 / 9)) + 273.15;
                            endTempVal = CheckKelvin(endTempVal);
                            endTemp = endTempVal.ToString("N2") + " K";
                            break;
                    }
                    break;
                case 1:
                    // Convert from Celsius
                    switch (inEndUnit)
                    {
                        case 0:
                            endTempVal = (inStartTemp * (9 / 5)) + 32;
                            endTemp = endTempVal.ToString("N2") + " °F";
                            break;
                        case 1:
                            endTemp = inStartTemp + " °C";
                            break;
                        case 2:
                            endTempVal = inStartTemp + 273.15;
                            endTempVal = CheckKelvin(endTempVal);
                            endTemp = endTempVal.ToString("N2") + " K";
                            break;
                    }
                    break;
                case 2:
                    // Convert from Kelvin
                    switch (inEndUnit)
                    {
                        case 0:
                            endTempVal = ((inStartTemp - 273.15) * (9 / 5)) + 32;
                            endTemp = endTempVal.ToString("N2") + " °F";
                            break;
                        case 1:
                            endTempVal = inStartTemp - 237.15;
                            endTemp = endTempVal.ToString("N2") + " °C";
                            break;
                        case 2:
                            endTemp = inStartTemp + " K";
                            break;
                    }
                    break;
            }

            return endTemp; 

        }  

    }
}
