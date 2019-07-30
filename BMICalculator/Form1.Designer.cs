namespace BMICalculator
{
    partial class BMICalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.RadioImperial = new System.Windows.Forms.RadioButton();
            this.RadioMetric = new System.Windows.Forms.RadioButton();
            this.MyHeight = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.HeightUnits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightUnits = new System.Windows.Forms.Label();
            this.MyWeight = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.ButtonCaculator = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.KeyboardTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.KeyboardTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioImperial
            // 
            this.RadioImperial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioImperial.AutoSize = true;
            this.RadioImperial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.RadioImperial, 6);
            this.RadioImperial.Location = new System.Drawing.Point(3, 3);
            this.RadioImperial.Name = "RadioImperial";
            this.RadioImperial.Size = new System.Drawing.Size(144, 40);
            this.RadioImperial.TabIndex = 0;
            this.RadioImperial.TabStop = true;
            this.RadioImperial.Text = "Imperial";
            this.RadioImperial.UseVisualStyleBackColor = false;
            this.RadioImperial.CheckedChanged += new System.EventHandler(this.UnitChose);
            this.RadioImperial.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // RadioMetric
            // 
            this.RadioMetric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioMetric.AutoSize = true;
            this.RadioMetric.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.RadioMetric, 6);
            this.RadioMetric.Location = new System.Drawing.Point(153, 3);
            this.RadioMetric.Name = "RadioMetric";
            this.RadioMetric.Size = new System.Drawing.Size(148, 40);
            this.RadioMetric.TabIndex = 1;
            this.RadioMetric.TabStop = true;
            this.RadioMetric.Text = "Metric";
            this.RadioMetric.UseVisualStyleBackColor = false;
            this.RadioMetric.CheckedChanged += new System.EventHandler(this.UnitChose);
            // 
            // MyHeight
            // 
            this.MyHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeight.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyHeight, 6);
            this.MyHeight.Location = new System.Drawing.Point(3, 46);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(144, 46);
            this.MyHeight.TabIndex = 2;
            this.MyHeight.Text = "MyHeight";
            this.MyHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightBox
            // 
            this.HeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.HeightBox, 3);
            this.HeightBox.Location = new System.Drawing.Point(153, 49);
            this.HeightBox.Multiline = true;
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(69, 40);
            this.HeightBox.TabIndex = 4;
            this.HeightBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightDataMouseDown);
            // 
            // HeightUnits
            // 
            this.HeightUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightUnits.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.HeightUnits, 3);
            this.HeightUnits.Location = new System.Drawing.Point(228, 46);
            this.HeightUnits.Name = "HeightUnits";
            this.HeightUnits.Size = new System.Drawing.Size(73, 46);
            this.HeightUnits.TabIndex = 6;
            this.HeightUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "BMI Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightBox
            // 
            this.WeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.WeightBox, 3);
            this.WeightBox.Location = new System.Drawing.Point(153, 95);
            this.WeightBox.Multiline = true;
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(69, 42);
            this.WeightBox.TabIndex = 5;
            this.WeightBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WeightDataMouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.Controls.Add(this.WeightUnits, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.RadioImperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightUnits, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RadioMetric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightBox, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.MyWeight, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 140);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // WeightUnits
            // 
            this.WeightUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightUnits.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.WeightUnits, 3);
            this.WeightUnits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WeightUnits.Location = new System.Drawing.Point(228, 92);
            this.WeightUnits.Name = "WeightUnits";
            this.WeightUnits.Size = new System.Drawing.Size(73, 48);
            this.WeightUnits.TabIndex = 8;
            this.WeightUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyWeight
            // 
            this.MyWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeight.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MyWeight, 6);
            this.MyWeight.Location = new System.Drawing.Point(3, 92);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(144, 48);
            this.MyWeight.TabIndex = 7;
            this.MyWeight.Text = "MyWeight";
            this.MyWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button7
            // 
            this.Button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button7.Location = new System.Drawing.Point(3, 3);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(43, 42);
            this.Button7.TabIndex = 29;
            this.Button7.Tag = "7";
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button8
            // 
            this.Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button8.Location = new System.Drawing.Point(52, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(43, 42);
            this.Button8.TabIndex = 30;
            this.Button8.Tag = "8";
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button9
            // 
            this.Button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button9.Location = new System.Drawing.Point(101, 3);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(43, 42);
            this.Button9.TabIndex = 31;
            this.Button9.Tag = "9";
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button4
            // 
            this.Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button4.Location = new System.Drawing.Point(3, 51);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(43, 42);
            this.Button4.TabIndex = 32;
            this.Button4.Tag = "4";
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button5
            // 
            this.Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button5.Location = new System.Drawing.Point(52, 51);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(43, 42);
            this.Button5.TabIndex = 33;
            this.Button5.Tag = "5";
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button6
            // 
            this.Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button6.Location = new System.Drawing.Point(101, 51);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(43, 42);
            this.Button6.TabIndex = 34;
            this.Button6.Tag = "6";
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(3, 99);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(43, 42);
            this.Button1.TabIndex = 35;
            this.Button1.Tag = "1";
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button2.Location = new System.Drawing.Point(52, 99);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(43, 42);
            this.Button2.TabIndex = 36;
            this.Button2.Tag = "2";
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button3.Location = new System.Drawing.Point(101, 99);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(43, 42);
            this.Button3.TabIndex = 37;
            this.Button3.Tag = "3";
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // Button0
            // 
            this.Button0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyboardTable.SetColumnSpan(this.Button0, 2);
            this.Button0.Location = new System.Drawing.Point(3, 147);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(92, 42);
            this.Button0.TabIndex = 38;
            this.Button0.Tag = "0";
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDecimal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDecimal.Location = new System.Drawing.Point(101, 147);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(43, 42);
            this.ButtonDecimal.TabIndex = 39;
            this.ButtonDecimal.Tag = "decimal";
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = false;
            this.ButtonDecimal.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // ButtonCaculator
            // 
            this.ButtonCaculator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCaculator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyboardTable.SetColumnSpan(this.ButtonCaculator, 3);
            this.ButtonCaculator.Location = new System.Drawing.Point(3, 195);
            this.ButtonCaculator.Name = "ButtonCaculator";
            this.ButtonCaculator.Size = new System.Drawing.Size(141, 42);
            this.ButtonCaculator.TabIndex = 40;
            this.ButtonCaculator.Tag = "calculator";
            this.ButtonCaculator.Text = "Caculator";
            this.ButtonCaculator.UseVisualStyleBackColor = false;
            this.ButtonCaculator.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyboardTable.SetColumnSpan(this.ButtonClear, 2);
            this.ButtonClear.Location = new System.Drawing.Point(199, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(96, 42);
            this.ButtonClear.TabIndex = 41;
            this.ButtonClear.Tag = "clear";
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // KeyboardTable
            // 
            this.KeyboardTable.ColumnCount = 6;
            this.KeyboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.KeyboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.KeyboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.KeyboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.KeyboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.KeyboardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.KeyboardTable.Controls.Add(this.ButtonDelete, 3, 0);
            this.KeyboardTable.Controls.Add(this.Button0, 0, 3);
            this.KeyboardTable.Controls.Add(this.ButtonDecimal, 2, 3);
            this.KeyboardTable.Controls.Add(this.Button7, 0, 0);
            this.KeyboardTable.Controls.Add(this.Button3, 2, 2);
            this.KeyboardTable.Controls.Add(this.Button2, 1, 2);
            this.KeyboardTable.Controls.Add(this.Button1, 0, 2);
            this.KeyboardTable.Controls.Add(this.Button6, 2, 1);
            this.KeyboardTable.Controls.Add(this.Button5, 1, 1);
            this.KeyboardTable.Controls.Add(this.Button4, 0, 1);
            this.KeyboardTable.Controls.Add(this.Button9, 2, 0);
            this.KeyboardTable.Controls.Add(this.Button8, 1, 0);
            this.KeyboardTable.Controls.Add(this.ButtonClear, 4, 0);
            this.KeyboardTable.Controls.Add(this.ButtonCaculator, 0, 4);
            this.KeyboardTable.Controls.Add(this.ResultBox, 3, 2);
            this.KeyboardTable.Controls.Add(this.ProgressBar, 3, 1);
            this.KeyboardTable.Location = new System.Drawing.Point(3, 203);
            this.KeyboardTable.Name = "KeyboardTable";
            this.KeyboardTable.RowCount = 5;
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.KeyboardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.KeyboardTable.Size = new System.Drawing.Size(298, 240);
            this.KeyboardTable.TabIndex = 4;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDelete.Location = new System.Drawing.Point(150, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(43, 42);
            this.ButtonDelete.TabIndex = 43;
            this.ButtonDelete.Tag = "delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.KeyboardButtonClick);
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardTable.SetColumnSpan(this.ResultBox, 3);
            this.ResultBox.Location = new System.Drawing.Point(150, 99);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.KeyboardTable.SetRowSpan(this.ResultBox, 3);
            this.ResultBox.Size = new System.Drawing.Size(145, 138);
            this.ResultBox.TabIndex = 44;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardTable.SetColumnSpan(this.ProgressBar, 3);
            this.ProgressBar.Location = new System.Drawing.Point(150, 51);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(145, 42);
            this.ProgressBar.TabIndex = 45;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(304, 455);
            this.Controls.Add(this.KeyboardTable);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "result";
            this.Text = "BMICalculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.KeyboardTable.ResumeLayout(false);
            this.KeyboardTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RadioImperial;
        private System.Windows.Forms.RadioButton RadioMetric;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label HeightUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label WeightUnits;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonCaculator;
        private System.Windows.Forms.Button ButtonDecimal;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.TableLayoutPanel KeyboardTable;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

