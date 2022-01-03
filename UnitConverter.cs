using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit_converter
{
    public partial class UnitConverter : Form
    {
        public UnitConverter()
        {
            InitializeComponent();
        }

        private void UnitConverter_Load(object sender, EventArgs e)
        {
            // Set Default Dropdown items
            initialTempUnit.SelectedIndex = 0;
            endTempUnit.SelectedIndex = 0;

            initialLengthUnit.SelectedIndex = 0;
            endLengthUnit.SelectedIndex = 0;

            initialWeightUnit.SelectedIndex = 0;
            endWeightUnit.SelectedIndex = 0;

            initialVolumeUnit.SelectedIndex = 0;
            endVolumeUnit.SelectedIndex = 0;
        }

        private void initialTempUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (initialTempUnit.SelectedIndex)
            {
                case 0:
                    initialTempLabel.Text = "°F";
                    break;
                case 1:
                    initialTempLabel.Text = "°C";
                    break;
                case 2:
                    initialTempLabel.Text = "K";
                    break;
            }
        }

        private void initialLengthUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (initialLengthUnit.SelectedIndex)
            {
                case 0:
                    initialLengthLabel.Text = "in";
                    break;
                case 1:
                    initialLengthLabel.Text = "ft";
                    break;
                case 2:
                    initialLengthLabel.Text = "yd";
                    break;
                case 3:
                    initialLengthLabel.Text = "mi";
                    break;
                case 4:
                    initialLengthLabel.Text = "mm";
                    break;
                case 5:
                    initialLengthLabel.Text = "cm";
                    break;
                case 6:
                    initialLengthLabel.Text = "m";
                    break;
                case 7:
                    initialLengthLabel.Text = "km";
                    break;
            }
        }

        private void initialWeightUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (initialWeightUnit.SelectedIndex)
            {
                case 0:
                    initialWeightLabel.Text = "lbs";
                    break;
                case 1:
                    initialWeightLabel.Text = "oz";
                    break;
                case 2:
                    initialWeightLabel.Text = "kg";
                    break;
                case 3:
                    initialWeightLabel.Text = "g";
                    break;
            }
        }

        private void initialVolumeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (initialVolumeUnit.SelectedIndex)
            {
                case 0:
                    initialVolumeLabel.Text = "fl oz";
                    break;
                case 1:
                    initialVolumeLabel.Text = "pt";
                    break;
                case 2:
                    initialVolumeLabel.Text = "gal";
                    break;
                case 3:
                    initialVolumeLabel.Text = "mL";
                    break;
                case 4:
                    initialVolumeLabel.Text = "cl";
                    break;
                case 5:
                    initialVolumeLabel.Text = "L";
                    break;
            }
        }

        private void convertTemp_Click(object sender, EventArgs e)
        {
            string initialTempString = initialTemp.Text;
            double initialTempVal;
            bool tempValid = double.TryParse(initialTempString, out initialTempVal);
            int startTempUnit = initialTempUnit.SelectedIndex;
            int finishTempUnit = endTempUnit.SelectedIndex;

            if (tempValid == true)
            {
                endTemp.Text = ConvertTemp(startTempUnit, finishTempUnit, initialTempVal);
            }
        }

        private void convertLength_Click(object sender, EventArgs e)
        {
            string initialLengthString = initialLength.Text;
            double initialLengthVal;
            bool lengthValid = double.TryParse((initialLengthString), out initialLengthVal);
            int startLengthUnit = initialLengthUnit.SelectedIndex;
            int finishLengthUnit = endLengthUnit.SelectedIndex;

            if (lengthValid == true)
            {
                if (initialLengthVal >= 0)
                {
                    endLength.Text = ConvertLength(startLengthUnit, finishLengthUnit, initialLengthVal);
                }
                else
                {
                    endLength.Text = "Error: Length must be positive";
                }
            }
        }

        private void convertWeight_Click(object sender, EventArgs e)
        {
            string initialWeightString = initialWeight.Text;
            double initialWeightVal;
            bool weightValid = double.TryParse((initialWeightString), out initialWeightVal);
            int startWeightUnit = initialWeightUnit.SelectedIndex;
            int finishWeightUnit = endWeightUnit.SelectedIndex;

            if (weightValid == true)
            {
                if (initialWeightVal >= 0)
                {
                    endWeight.Text = ConvertWeight(startWeightUnit, finishWeightUnit, initialWeightVal);
                }
                else
                {
                    endWeight.Text = "Error: Weight must be positive";
                }
            }
        }

        private void convertVolume_Click(object sender, EventArgs e)
        {
            string initialVolumeString= initialVolume.Text;
            double initialVolumeVal;
            bool volumeValid = double.TryParse((initialVolumeString), out initialVolumeVal);
            int startVolumeUnit = initialVolumeUnit.SelectedIndex;
            int finishVolumeUnit = endVolumeUnit.SelectedIndex;

            if (volumeValid == true)
            {
                if (initialVolumeVal >= 0)
                {
                    endVolume.Text = ConvertVolume(startVolumeUnit, finishVolumeUnit, initialVolumeVal);
                }
                else
                {
                    endVolume.Text = "Error: Volume must be positive";
                }
            }
        }
    }
}
