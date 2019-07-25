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
namespace Assignment04
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            if (HeightTextBox.Text != null && WeightTextBox.Text != null)
            {
                CalculateBMIButton.Enabled = true;
            }
            else
            {
                CalculateBMIButton.Enabled = false;
            }
        }

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnitHeightLabel.Text = "m";
            UnitWeightLabel.Text = "kg";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnitHeightLabel.Text = "in";
            UnitWeightLabel.Text = "lbs";
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double bmi = MetricRadioButton.Checked == true ? weight / (height * height) : (weight * 703) / (height * height);
            if (bmi < 18.5)
            {
                MultilineTextBox.Text = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                MultilineTextBox.Text = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                MultilineTextBox.Text = "Overweight";
            }
            else if (bmi >= 30)
            {
                MultilineTextBox.Text = "Obese";
            }
            else
            {
                MultilineTextBox.Text = "Error!";
            }
            BMITextBox.Text = $"BMI: {bmi:N1}";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            BMITextBox.Text = string.Empty;
            MultilineTextBox.Text = string.Empty;
        }
    }
}
