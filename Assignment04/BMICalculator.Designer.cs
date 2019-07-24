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
            this.UnitWeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NumberKeysTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.PeriodButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.HeightTableLayoutPanel.SuspendLayout();
            this.WeightTableLayoutPanel.SuspendLayout();
            this.NumberKeysTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightTableLayoutPanel
            // 
            this.HeightTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeightTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.UnitHeightLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitHeightLabel.Location = new System.Drawing.Point(261, 10);
            this.UnitHeightLabel.Name = "UnitHeightLabel";
            this.UnitHeightLabel.Size = new System.Drawing.Size(31, 30);
            this.UnitHeightLabel.TabIndex = 6;
            this.UnitHeightLabel.Text = "m";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeightTextBox.Location = new System.Drawing.Point(157, 4);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(98, 43);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightLabel.Location = new System.Drawing.Point(8, 6);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HeightLabel.Size = new System.Drawing.Size(143, 37);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "my height";
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(160, 0);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(145, 55);
            this.ImperialRadioButton.TabIndex = 2;
            this.ImperialRadioButton.Text = "IMPERIAL";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(0, 0);
            this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MetricRadioButton.Size = new System.Drawing.Size(160, 55);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "METRIC";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BMITextBox.Location = new System.Drawing.Point(183, 160);
            this.BMITextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(109, 36);
            this.BMITextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CalculateBMIButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CalculateBMIButton.Enabled = false;
            this.CalculateBMIButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.CalculateBMIButton.FlatAppearance.BorderSize = 0;
            this.CalculateBMIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBMIButton.Location = new System.Drawing.Point(105, 240);
            this.CalculateBMIButton.Margin = new System.Windows.Forms.Padding(0);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(200, 50);
            this.CalculateBMIButton.TabIndex = 8;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // MultilineTextBox
            // 
            this.MultilineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MultilineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultilineTextBox.Enabled = false;
            this.MultilineTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MultilineTextBox.Location = new System.Drawing.Point(8, 159);
            this.MultilineTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultilineTextBox.Multiline = true;
            this.MultilineTextBox.Name = "MultilineTextBox";
            this.MultilineTextBox.Size = new System.Drawing.Size(169, 44);
            this.MultilineTextBox.TabIndex = 9;
            // 
            // WeightTableLayoutPanel
            // 
            this.WeightTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WeightTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WeightTableLayoutPanel.ColumnCount = 3;
            this.WeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.WeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.WeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.WeightTableLayoutPanel.Controls.Add(this.UnitWeightLabel, 2, 0);
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
            // UnitWeightLabel
            // 
            this.UnitWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnitWeightLabel.AutoSize = true;
            this.UnitWeightLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitWeightLabel.Location = new System.Drawing.Point(261, 10);
            this.UnitWeightLabel.Name = "UnitWeightLabel";
            this.UnitWeightLabel.Size = new System.Drawing.Size(35, 30);
            this.UnitWeightLabel.TabIndex = 6;
            this.UnitWeightLabel.Text = "kg";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WeightTextBox.Location = new System.Drawing.Point(157, 4);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(98, 43);
            this.WeightTextBox.TabIndex = 4;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(8, 6);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WeightLabel.Size = new System.Drawing.Size(143, 37);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "my weight";
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.BackColor = System.Drawing.SystemColors.GrayText;
            this.BMIProgressBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BMIProgressBar.Location = new System.Drawing.Point(8, 210);
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(284, 23);
            this.BMIProgressBar.TabIndex = 11;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(0, 240);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(105, 50);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // NumberKeysTableLayoutPanel
            // 
            this.NumberKeysTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberKeysTableLayoutPanel.ColumnCount = 3;
            this.NumberKeysTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumberKeysTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumberKeysTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumberKeysTableLayoutPanel.Controls.Add(this.BackspaceButton, 0, 3);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.PeriodButton, 0, 3);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.FourButton, 0, 1);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.FiveButton, 1, 1);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.OneButton, 0, 2);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.TwoButton, 1, 2);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.NumberKeysTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 3);
            this.NumberKeysTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumberKeysTableLayoutPanel.Location = new System.Drawing.Point(0, 290);
            this.NumberKeysTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NumberKeysTableLayoutPanel.Name = "NumberKeysTableLayoutPanel";
            this.NumberKeysTableLayoutPanel.RowCount = 4;
            this.NumberKeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberKeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberKeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberKeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberKeysTableLayoutPanel.Size = new System.Drawing.Size(305, 150);
            this.NumberKeysTableLayoutPanel.TabIndex = 13;
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackspaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackspaceButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BackspaceButton.FlatAppearance.BorderSize = 0;
            this.BackspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspaceButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspaceButton.Location = new System.Drawing.Point(203, 112);
            this.BackspaceButton.Margin = new System.Windows.Forms.Padding(1);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(101, 37);
            this.BackspaceButton.TabIndex = 20;
            this.BackspaceButton.Text = "<-";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            // 
            // PeriodButton
            // 
            this.PeriodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PeriodButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.PeriodButton.FlatAppearance.BorderSize = 0;
            this.PeriodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeriodButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodButton.Location = new System.Drawing.Point(102, 112);
            this.PeriodButton.Margin = new System.Windows.Forms.Padding(1);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(99, 37);
            this.PeriodButton.TabIndex = 19;
            this.PeriodButton.Text = ".";
            this.PeriodButton.UseVisualStyleBackColor = false;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SevenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(1, 1);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(1);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(99, 35);
            this.SevenButton.TabIndex = 9;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EightButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(102, 1);
            this.EightButton.Margin = new System.Windows.Forms.Padding(1);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(99, 35);
            this.EightButton.TabIndex = 10;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NineButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(203, 1);
            this.NineButton.Margin = new System.Windows.Forms.Padding(1);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(101, 35);
            this.NineButton.TabIndex = 11;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FourButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(1, 38);
            this.FourButton.Margin = new System.Windows.Forms.Padding(1);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(99, 35);
            this.FourButton.TabIndex = 12;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FiveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(102, 38);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(1);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(99, 35);
            this.FiveButton.TabIndex = 13;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SixButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(203, 38);
            this.SixButton.Margin = new System.Windows.Forms.Padding(1);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(101, 35);
            this.SixButton.TabIndex = 14;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OneButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(1, 75);
            this.OneButton.Margin = new System.Windows.Forms.Padding(1);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(99, 35);
            this.OneButton.TabIndex = 15;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TwoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(102, 75);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(1);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(99, 35);
            this.TwoButton.TabIndex = 16;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ThreeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(203, 75);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(1);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(101, 35);
            this.ThreeButton.TabIndex = 17;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ZeroButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(1, 112);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(1);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(99, 37);
            this.ZeroButton.TabIndex = 18;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // BMICalculatorForm
            // 
            this.AcceptButton = this.CalculateBMIButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.NumberKeysTableLayoutPanel);
            this.Controls.Add(this.ResetButton);
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
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.HeightTableLayoutPanel.ResumeLayout(false);
            this.HeightTableLayoutPanel.PerformLayout();
            this.WeightTableLayoutPanel.ResumeLayout(false);
            this.WeightTableLayoutPanel.PerformLayout();
            this.NumberKeysTableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label UnitWeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TableLayoutPanel NumberKeysTableLayoutPanel;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button PeriodButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button ZeroButton;
    }
}

