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
namespace Assignment04
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
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
            double bmi;
            double w = Convert.ToDouble(WeightTextBox.Text);
            double h = Convert.ToDouble(HeightTextBox.Text);
            if (MetricRadioButton.Checked == true)
            {
                bmi = w / (h * h);
            }
            else
            {
                bmi = (w * 703) / (h * h);
            }
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
            BMITextBox.Text = $"BMI: {bmi:N2}";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            BMITextBox.Text = string.Empty;
            MultilineTextBox.Text = string.Empty;
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            if (HeightTextBox.Text != "" & WeightTextBox.Text != "")
            {
                CalculateBMIButton.Enabled = true;
            }
            else
            {
                CalculateBMIButton.Enabled = false;
            }
        }
    }
}
