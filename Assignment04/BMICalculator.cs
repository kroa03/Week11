using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author's Name: Koolait Roa
// Student No.: 301034220
// Revision History:
// Date         Changes
// 22-Jul-2019  Created
// 24-Jul-2019  Created BMICalculatorForm_Load Event
// 24-Jul-2019  Created BMICalculatorForm_FormClosing Event
// 24-Jul-2019  Created MetricRadioButton_CheckedChanged Event
// 24-Jul-2019  Created ImperialRadioButton_CheckedChanged Event
// 24-Jul-2019  Created CalculateBMIButton_Click Event
// 24-Jul-2019  Created ResetButton_Click Event
// 25-Jul-2019  Created CalculatorButton_Click Event
// 25-Jul-2019  Added properties to store values from numeric keypad
// 25-Jul-2019  Created an overload for the method ResetButton_Click
// 25-Jul-2019  Created TextBox_Click Event
namespace Assignment04
{
    public partial class BMICalculatorForm : Form
    {
        // Class Properties
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists  { get; set; }

        public TextBox ActiveTextBox { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler that triggers when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            NumberKeysTableLayoutPanel.Visible = false;
            CalculateBMIButton.Enabled = false;
        }

        /// <summary>
        /// This is a method to reset the values
        /// </summary>
        private void ClearNumericKeyboard()
        {
            BMIResultTextBox.Text = string.Empty;
            BMIScaleMultilineTextBox.Text = string.Empty;

            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }

        /// <summary>
        /// This is the event handler when the form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler to switch unit labels to metric
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnitHeightLabel.Text = "m";
            UnitWeightLabel.Text = "kg";
        }

        /// <summary>
        /// This is the event handler to switch unit labels to imperial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnitHeightLabel.Text = "in";
            UnitWeightLabel.Text = "lbs";
        }

        /// <summary>
        /// This is the event handler for the shared click event of HeightTextBox and WeightTextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Click(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            NumberKeysTableLayoutPanel.Visible = true;
            
            ActiveTextBox = sender as TextBox;
        }

        /// <summary>
        /// Shared event when text is changed calculate button enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (HeightTextBox.Text != string.Empty && WeightTextBox.Text != string.Empty)
            {
                CalculateBMIButton.Enabled = true;
            }
            else
            {
                CalculateBMIButton.Enabled = false;
            }
        }

        /// <summary>
        /// This is the shared Event Handler for all the keypad buttons - Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeypadButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;
                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length <= maxSize)
                    {
                        outputString += tag;
                    }
                }
                ActiveTextBox.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "backspace":
                        var lastChar = outputString.Substring(outputString.Length - 1);
                        if (lastChar == ".")
                        {
                            decimalExists = false;
                        }
                        outputString = outputString.Remove(outputString.Length - 1);
                        HeightTextBox.Text = outputString;
                        if (outputString.Length == 0)
                        {
                            outputString = "0";
                        }
                        break;
                    case "decimal":
                        if (!decimalExists)
                        {
                            outputString += ".";
                            decimalExists = true;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// This is the event handler to calculate bmi based on the input values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double bmi = MetricRadioButton.Checked == true ? weight / (height * height) : (weight * 703) / (height * height);
            if (bmi < 18.5)
            {
                BMIScaleMultilineTextBox.Text = "Underweight";
                //copied code format from Designer
                BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                BMIScaleMultilineTextBox.Text = "Normal";
                BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                BMIScaleMultilineTextBox.Text = "Overweight";
                BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
            }
            else if (bmi >= 30)
            {
                BMIScaleMultilineTextBox.Text = "Obese";
                BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            else
            {
                BMIScaleMultilineTextBox.Text = "Error!";
                BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            BMIResultTextBox.Text = $"BMI: {bmi:N1}";

            NumberKeysTableLayoutPanel.Visible = false;

            ProgressBar(bmi);
        }

        /// <summary>
        /// Clears and resets the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            BMIResultTextBox.Text = string.Empty;
            BMIScaleMultilineTextBox.Text = string.Empty;

            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;

        }

        private void ProgressBar(double bmi)
        {
            // References https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.progressbar?view=netframework-4.8
            // Display the ProgressBar control.
            BMIProgressBar.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            BMIProgressBar.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            BMIProgressBar.Maximum = 50;
            // Set the initial value of the ProgressBar.
            BMIProgressBar.Value = 1;
            // Set the Step property to a value of 1
            BMIProgressBar.Step = 1;

            // Loop through all files to copy.
            for (int x = 1; x <= bmi; x++)
            {
                {
                    // Perform the increment on the ProgressBar.
                    BMIProgressBar.PerformStep();
                }
            }
        }
    }
}
