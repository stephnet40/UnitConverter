namespace unit_converter
{
    partial class UnitConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initialTemp = new System.Windows.Forms.TextBox();
            this.initialTempLabel = new System.Windows.Forms.Label();
            this.endTempUnit = new System.Windows.Forms.ComboBox();
            this.initialTempUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convertTemp = new System.Windows.Forms.Button();
            this.endTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.initialLengthUnit = new System.Windows.Forms.ComboBox();
            this.endLengthUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.initialLength = new System.Windows.Forms.TextBox();
            this.convertLength = new System.Windows.Forms.Button();
            this.initialLengthLabel = new System.Windows.Forms.Label();
            this.endLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.initialWeightUnit = new System.Windows.Forms.ComboBox();
            this.endWeightUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.initialWeight = new System.Windows.Forms.TextBox();
            this.initialWeightLabel = new System.Windows.Forms.Label();
            this.endWeight = new System.Windows.Forms.Label();
            this.convertWeight = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.initialVolumeUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.endVolumeUnit = new System.Windows.Forms.ComboBox();
            this.initialVolume = new System.Windows.Forms.TextBox();
            this.initialVolumeLabel = new System.Windows.Forms.Label();
            this.endVolume = new System.Windows.Forms.Label();
            this.convertVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialTemp
            // 
            this.initialTemp.Location = new System.Drawing.Point(83, 107);
            this.initialTemp.Name = "initialTemp";
            this.initialTemp.Size = new System.Drawing.Size(100, 20);
            this.initialTemp.TabIndex = 1;
            // 
            // initialTempLabel
            // 
            this.initialTempLabel.AutoSize = true;
            this.initialTempLabel.Location = new System.Drawing.Point(187, 110);
            this.initialTempLabel.Name = "initialTempLabel";
            this.initialTempLabel.Size = new System.Drawing.Size(17, 13);
            this.initialTempLabel.TabIndex = 4;
            this.initialTempLabel.Text = "°F";
            // 
            // endTempUnit
            // 
            this.endTempUnit.FormattingEnabled = true;
            this.endTempUnit.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.endTempUnit.Location = new System.Drawing.Point(282, 65);
            this.endTempUnit.Name = "endTempUnit";
            this.endTempUnit.Size = new System.Drawing.Size(121, 21);
            this.endTempUnit.TabIndex = 3;
            // 
            // initialTempUnit
            // 
            this.initialTempUnit.FormattingEnabled = true;
            this.initialTempUnit.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.initialTempUnit.Location = new System.Drawing.Point(83, 65);
            this.initialTempUnit.Name = "initialTempUnit";
            this.initialTempUnit.Size = new System.Drawing.Size(121, 21);
            this.initialTempUnit.TabIndex = 2;
            this.initialTempUnit.SelectedIndexChanged += new System.EventHandler(this.initialTempUnit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "to";
            // 
            // convertTemp
            // 
            this.convertTemp.Location = new System.Drawing.Point(499, 62);
            this.convertTemp.Name = "convertTemp";
            this.convertTemp.Size = new System.Drawing.Size(75, 23);
            this.convertTemp.TabIndex = 6;
            this.convertTemp.Text = "Convert";
            this.convertTemp.UseVisualStyleBackColor = true;
            this.convertTemp.Click += new System.EventHandler(this.convertTemp_Click);
            // 
            // endTemp
            // 
            this.endTemp.AutoSize = true;
            this.endTemp.Location = new System.Drawing.Point(282, 113);
            this.endTemp.Name = "endTemp";
            this.endTemp.Size = new System.Drawing.Size(0, 13);
            this.endTemp.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Length";
            // 
            // initialLengthUnit
            // 
            this.initialLengthUnit.FormattingEnabled = true;
            this.initialLengthUnit.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards",
            "Miles",
            "Millimeters",
            "Centimeters",
            "Meters",
            "Kilometers"});
            this.initialLengthUnit.Location = new System.Drawing.Point(83, 185);
            this.initialLengthUnit.Name = "initialLengthUnit";
            this.initialLengthUnit.Size = new System.Drawing.Size(121, 21);
            this.initialLengthUnit.TabIndex = 10;
            this.initialLengthUnit.SelectedIndexChanged += new System.EventHandler(this.initialLengthUnit_SelectedIndexChanged);
            // 
            // endLengthUnit
            // 
            this.endLengthUnit.FormattingEnabled = true;
            this.endLengthUnit.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards",
            "Miles",
            "Millimeters",
            "Centimeters",
            "Meters",
            "Kilometers"});
            this.endLengthUnit.Location = new System.Drawing.Point(282, 185);
            this.endLengthUnit.Name = "endLengthUnit";
            this.endLengthUnit.Size = new System.Drawing.Size(121, 21);
            this.endLengthUnit.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "to";
            // 
            // initialLength
            // 
            this.initialLength.Location = new System.Drawing.Point(83, 225);
            this.initialLength.Name = "initialLength";
            this.initialLength.Size = new System.Drawing.Size(100, 20);
            this.initialLength.TabIndex = 13;
            // 
            // convertLength
            // 
            this.convertLength.Location = new System.Drawing.Point(499, 185);
            this.convertLength.Name = "convertLength";
            this.convertLength.Size = new System.Drawing.Size(75, 23);
            this.convertLength.TabIndex = 14;
            this.convertLength.Text = "Convert";
            this.convertLength.UseVisualStyleBackColor = true;
            this.convertLength.Click += new System.EventHandler(this.convertLength_Click);
            // 
            // initialLengthLabel
            // 
            this.initialLengthLabel.AutoSize = true;
            this.initialLengthLabel.Location = new System.Drawing.Point(189, 228);
            this.initialLengthLabel.Name = "initialLengthLabel";
            this.initialLengthLabel.Size = new System.Drawing.Size(15, 13);
            this.initialLengthLabel.TabIndex = 15;
            this.initialLengthLabel.Text = "in";
            // 
            // endLength
            // 
            this.endLength.AutoSize = true;
            this.endLength.Location = new System.Drawing.Point(279, 228);
            this.endLength.Name = "endLength";
            this.endLength.Size = new System.Drawing.Size(0, 13);
            this.endLength.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Weight";
            // 
            // initialWeightUnit
            // 
            this.initialWeightUnit.FormattingEnabled = true;
            this.initialWeightUnit.Items.AddRange(new object[] {
            "Pounds",
            "Ounces",
            "Kilograms",
            "Grams"});
            this.initialWeightUnit.Location = new System.Drawing.Point(83, 305);
            this.initialWeightUnit.Name = "initialWeightUnit";
            this.initialWeightUnit.Size = new System.Drawing.Size(121, 21);
            this.initialWeightUnit.TabIndex = 18;
            this.initialWeightUnit.SelectedIndexChanged += new System.EventHandler(this.initialWeightUnit_SelectedIndexChanged);
            // 
            // endWeightUnit
            // 
            this.endWeightUnit.FormattingEnabled = true;
            this.endWeightUnit.Items.AddRange(new object[] {
            "Pounds",
            "Ounces",
            "Kilograms",
            "Grams"});
            this.endWeightUnit.Location = new System.Drawing.Point(282, 305);
            this.endWeightUnit.Name = "endWeightUnit";
            this.endWeightUnit.Size = new System.Drawing.Size(121, 21);
            this.endWeightUnit.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "to";
            // 
            // initialWeight
            // 
            this.initialWeight.Location = new System.Drawing.Point(83, 346);
            this.initialWeight.Name = "initialWeight";
            this.initialWeight.Size = new System.Drawing.Size(100, 20);
            this.initialWeight.TabIndex = 21;
            // 
            // initialWeightLabel
            // 
            this.initialWeightLabel.AutoSize = true;
            this.initialWeightLabel.Location = new System.Drawing.Point(189, 349);
            this.initialWeightLabel.Name = "initialWeightLabel";
            this.initialWeightLabel.Size = new System.Drawing.Size(20, 13);
            this.initialWeightLabel.TabIndex = 22;
            this.initialWeightLabel.Text = "lbs";
            // 
            // endWeight
            // 
            this.endWeight.AutoSize = true;
            this.endWeight.Location = new System.Drawing.Point(279, 349);
            this.endWeight.Name = "endWeight";
            this.endWeight.Size = new System.Drawing.Size(0, 13);
            this.endWeight.TabIndex = 23;
            // 
            // convertWeight
            // 
            this.convertWeight.Location = new System.Drawing.Point(499, 305);
            this.convertWeight.Name = "convertWeight";
            this.convertWeight.Size = new System.Drawing.Size(75, 23);
            this.convertWeight.TabIndex = 24;
            this.convertWeight.Text = "Convert";
            this.convertWeight.UseVisualStyleBackColor = true;
            this.convertWeight.Click += new System.EventHandler(this.convertWeight_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Volume";
            // 
            // initialVolumeUnit
            // 
            this.initialVolumeUnit.FormattingEnabled = true;
            this.initialVolumeUnit.Items.AddRange(new object[] {
            "Fluid Ounces",
            "Pints",
            "Gallons",
            "Millileters",
            "Centiliters",
            "Liters"});
            this.initialVolumeUnit.Location = new System.Drawing.Point(83, 420);
            this.initialVolumeUnit.Name = "initialVolumeUnit";
            this.initialVolumeUnit.Size = new System.Drawing.Size(121, 21);
            this.initialVolumeUnit.TabIndex = 26;
            this.initialVolumeUnit.SelectedIndexChanged += new System.EventHandler(this.initialVolumeUnit_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "to";
            // 
            // endVolumeUnit
            // 
            this.endVolumeUnit.FormattingEnabled = true;
            this.endVolumeUnit.Items.AddRange(new object[] {
            "Fluid Ounces",
            "Pints",
            "Gallons",
            "Millileters",
            "Centiliters",
            "Liters"});
            this.endVolumeUnit.Location = new System.Drawing.Point(282, 420);
            this.endVolumeUnit.Name = "endVolumeUnit";
            this.endVolumeUnit.Size = new System.Drawing.Size(121, 21);
            this.endVolumeUnit.TabIndex = 28;
            // 
            // initialVolume
            // 
            this.initialVolume.Location = new System.Drawing.Point(81, 464);
            this.initialVolume.Name = "initialVolume";
            this.initialVolume.Size = new System.Drawing.Size(100, 20);
            this.initialVolume.TabIndex = 29;
            // 
            // initialVolumeLabel
            // 
            this.initialVolumeLabel.AutoSize = true;
            this.initialVolumeLabel.Location = new System.Drawing.Point(187, 467);
            this.initialVolumeLabel.Name = "initialVolumeLabel";
            this.initialVolumeLabel.Size = new System.Drawing.Size(26, 13);
            this.initialVolumeLabel.TabIndex = 30;
            this.initialVolumeLabel.Text = "fl oz";
            // 
            // endVolume
            // 
            this.endVolume.AutoSize = true;
            this.endVolume.Location = new System.Drawing.Point(282, 471);
            this.endVolume.Name = "endVolume";
            this.endVolume.Size = new System.Drawing.Size(0, 13);
            this.endVolume.TabIndex = 31;
            // 
            // convertVolume
            // 
            this.convertVolume.Location = new System.Drawing.Point(499, 418);
            this.convertVolume.Name = "convertVolume";
            this.convertVolume.Size = new System.Drawing.Size(75, 23);
            this.convertVolume.TabIndex = 32;
            this.convertVolume.Text = "Convert";
            this.convertVolume.UseVisualStyleBackColor = true;
            this.convertVolume.Click += new System.EventHandler(this.convertVolume_Click);
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 528);
            this.Controls.Add(this.convertVolume);
            this.Controls.Add(this.endVolume);
            this.Controls.Add(this.initialVolumeLabel);
            this.Controls.Add(this.initialVolume);
            this.Controls.Add(this.endVolumeUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.initialVolumeUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.convertWeight);
            this.Controls.Add(this.endWeight);
            this.Controls.Add(this.initialWeightLabel);
            this.Controls.Add(this.initialWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endWeightUnit);
            this.Controls.Add(this.initialWeightUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endLength);
            this.Controls.Add(this.initialLengthLabel);
            this.Controls.Add(this.convertLength);
            this.Controls.Add(this.initialLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endLengthUnit);
            this.Controls.Add(this.initialLengthUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endTemp);
            this.Controls.Add(this.convertTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initialTempLabel);
            this.Controls.Add(this.endTempUnit);
            this.Controls.Add(this.initialTempUnit);
            this.Controls.Add(this.initialTemp);
            this.Name = "UnitConverter";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.UnitConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox initialTemp;
        private System.Windows.Forms.Label initialTempLabel;
        private System.Windows.Forms.ComboBox endTempUnit;
        private System.Windows.Forms.ComboBox initialTempUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertTemp;
        private System.Windows.Forms.Label endTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox initialLengthUnit;
        private System.Windows.Forms.ComboBox endLengthUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialLength;
        private System.Windows.Forms.Button convertLength;
        private System.Windows.Forms.Label initialLengthLabel;
        private System.Windows.Forms.Label endLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox initialWeightUnit;
        private System.Windows.Forms.ComboBox endWeightUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox initialWeight;
        private System.Windows.Forms.Label initialWeightLabel;
        private System.Windows.Forms.Label endWeight;
        private System.Windows.Forms.Button convertWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox initialVolumeUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox endVolumeUnit;
        private System.Windows.Forms.TextBox initialVolume;
        private System.Windows.Forms.Label initialVolumeLabel;
        private System.Windows.Forms.Label endVolume;
        private System.Windows.Forms.Button convertVolume;
    }
}

