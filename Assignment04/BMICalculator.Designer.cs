namespace Assignment04
{
    partial class BMICalculatorForm
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
            this.HeightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UnitHeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.MultilineTextBox = new System.Windows.Forms.TextBox();
            this.WeightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.HeightTableLayoutPanel.SuspendLayout();
            this.WeightTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightTableLayoutPanel
            // 
            this.HeightTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeightTableLayoutPanel.BackColor = System.Drawing.Color.Gray;
            this.HeightTableLayoutPanel.ColumnCount = 3;
            this.HeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.HeightTableLayoutPanel.Controls.Add(this.UnitHeightLabel, 2, 0);
            this.HeightTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.HeightTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.HeightTableLayoutPanel.Location = new System.Drawing.Point(-7, 55);
            this.HeightTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeightTableLayoutPanel.Name = "HeightTableLayoutPanel";
            this.HeightTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.HeightTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeightTableLayoutPanel.RowCount = 1;
            this.HeightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.HeightTableLayoutPanel.Size = new System.Drawing.Size(315, 50);
            this.HeightTableLayoutPanel.TabIndex = 0;
            // 
            // UnitHeightLabel
            // 
            this.UnitHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitHeightLabel.AutoSize = true;
            this.UnitHeightLabel.Location = new System.Drawing.Point(255, 6);
            this.UnitHeightLabel.Name = "UnitHeightLabel";
            this.UnitHeightLabel.Size = new System.Drawing.Size(39, 37);
            this.UnitHeightLabel.TabIndex = 6;
            this.UnitHeightLabel.Text = "m";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeightTextBox.Location = new System.Drawing.Point(163, 4);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(86, 43);
            this.HeightTextBox.TabIndex = 5;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(8, 6);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(149, 37);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "MY HEIGHT";
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Location = new System.Drawing.Point(160, 0);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(160, 55);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.Text = "IMPERIAL";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(0, 0);
            this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.MetricRadioButton.Size = new System.Drawing.Size(160, 55);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "METRIC";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Location = new System.Drawing.Point(160, 160);
            this.BMITextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(132, 43);
            this.BMITextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CalculateBMIButton.Enabled = false;
            this.CalculateBMIButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.CalculateBMIButton.FlatAppearance.BorderSize = 0;
            this.CalculateBMIButton.Location = new System.Drawing.Point(60, 240);
            this.CalculateBMIButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(188, 51);
            this.CalculateBMIButton.TabIndex = 8;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // MultilineTextBox
            // 
            this.MultilineTextBox.Enabled = false;
            this.MultilineTextBox.Location = new System.Drawing.Point(8, 159);
            this.MultilineTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultilineTextBox.Multiline = true;
            this.MultilineTextBox.Name = "MultilineTextBox";
            this.MultilineTextBox.Size = new System.Drawing.Size(142, 44);
            this.MultilineTextBox.TabIndex = 9;
            // 
            // WeightTableLayoutPanel
            // 
            this.WeightTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WeightTableLayoutPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.WeightTableLayoutPanel.ColumnCount = 3;
            this.WeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.WeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.WeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.WeightTableLayoutPanel.Controls.Add(this.label1, 2, 0);
            this.WeightTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 0);
            this.WeightTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 0);
            this.WeightTableLayoutPanel.Location = new System.Drawing.Point(-7, 105);
            this.WeightTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.WeightTableLayoutPanel.Name = "WeightTableLayoutPanel";
            this.WeightTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.WeightTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeightTableLayoutPanel.RowCount = 1;
            this.WeightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WeightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.WeightTableLayoutPanel.Size = new System.Drawing.Size(315, 50);
            this.WeightTableLayoutPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "kg";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.Gray;
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WeightTextBox.Location = new System.Drawing.Point(163, 4);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(86, 43);
            this.WeightTextBox.TabIndex = 5;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(8, 6);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(149, 37);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "MY HEIGHT";
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.Location = new System.Drawing.Point(8, 210);
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(284, 23);
            this.BMIProgressBar.TabIndex = 11;
            // 
            // BMICalculatorForm
            // 
            this.AcceptButton = this.CalculateBMIButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMIProgressBar);
            this.Controls.Add(this.WeightTableLayoutPanel);
            this.Controls.Add(this.MultilineTextBox);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.HeightTableLayoutPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.HeightTableLayoutPanel.ResumeLayout(false);
            this.HeightTableLayoutPanel.PerformLayout();
            this.WeightTableLayoutPanel.ResumeLayout(false);
            this.WeightTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeightTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox MultilineTextBox;
        private System.Windows.Forms.Label UnitHeightLabel;
        private System.Windows.Forms.TableLayoutPanel WeightTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
    }
}

