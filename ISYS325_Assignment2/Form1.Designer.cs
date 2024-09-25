namespace ISYS325_Assignment2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mamoLbl = new Label();
            mamoListBox = new ListBox();
            yearLbl = new Label();
            yearTextBox = new TextBox();
            colorGroupBox = new GroupBox();
            Black_Radio = new RadioButton();
            Green_Radio = new RadioButton();
            Blue_Radio = new RadioButton();
            Red_Radio = new RadioButton();
            featuresGroupBox = new GroupBox();
            laneCheckBox = new CheckBox();
            siriusCheckBox = new CheckBox();
            powwinCheckBox = new CheckBox();
            AirCondition_CheckBox = new CheckBox();
            submitBtn = new Button();
            sumLabel = new Label();
            colorGroupBox.SuspendLayout();
            featuresGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // mamoLbl
            // 
            mamoLbl.AutoSize = true;
            mamoLbl.Location = new Point(25, 12);
            mamoLbl.Name = "mamoLbl";
            mamoLbl.Size = new Size(121, 20);
            mamoLbl.TabIndex = 0;
            mamoLbl.Text = "&Make and Model";
            // 
            // mamoListBox
            // 
            mamoListBox.FormattingEnabled = true;
            mamoListBox.Items.AddRange(new object[] { "Toyota Prius", "Chevrolet Silverado", "Honda Accord", "Hyundai Elantra" });
            mamoListBox.Location = new Point(25, 35);
            mamoListBox.Name = "mamoListBox";
            mamoListBox.Size = new Size(150, 104);
            mamoListBox.TabIndex = 1;
            mamoListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // yearLbl
            // 
            yearLbl.AutoSize = true;
            yearLbl.Location = new Point(193, 12);
            yearLbl.Name = "yearLbl";
            yearLbl.Size = new Size(37, 20);
            yearLbl.TabIndex = 3;
            yearLbl.Text = "&Year";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(193, 35);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(125, 27);
            yearTextBox.TabIndex = 4;
            yearTextBox.TextChanged += yearBox_TextChanged;
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(Black_Radio);
            colorGroupBox.Controls.Add(Green_Radio);
            colorGroupBox.Controls.Add(Blue_Radio);
            colorGroupBox.Controls.Add(Red_Radio);
            colorGroupBox.Location = new Point(324, 14);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(250, 125);
            colorGroupBox.TabIndex = 5;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "&Color";
            // 
            // Black_Radio
            // 
            Black_Radio.AutoSize = true;
            Black_Radio.Location = new Point(6, 95);
            Black_Radio.Name = "Black_Radio";
            Black_Radio.Size = new Size(65, 24);
            Black_Radio.TabIndex = 3;
            Black_Radio.TabStop = true;
            Black_Radio.Text = "Black";
            Black_Radio.UseVisualStyleBackColor = true;
            Black_Radio.CheckedChanged += black_CheckedChanged;
            // 
            // Green_Radio
            // 
            Green_Radio.AutoSize = true;
            Green_Radio.Location = new Point(6, 72);
            Green_Radio.Name = "Green_Radio";
            Green_Radio.Size = new Size(69, 24);
            Green_Radio.TabIndex = 2;
            Green_Radio.TabStop = true;
            Green_Radio.Text = "Green";
            Green_Radio.UseVisualStyleBackColor = true;
            Green_Radio.CheckedChanged += green_CheckedChanged;
            // 
            // Blue_Radio
            // 
            Blue_Radio.AutoSize = true;
            Blue_Radio.Location = new Point(6, 49);
            Blue_Radio.Name = "Blue_Radio";
            Blue_Radio.Size = new Size(59, 24);
            Blue_Radio.TabIndex = 1;
            Blue_Radio.TabStop = true;
            Blue_Radio.Text = "Blue";
            Blue_Radio.UseVisualStyleBackColor = true;
            Blue_Radio.CheckedChanged += blue_CheckedChanged;
            // 
            // Red_Radio
            // 
            Red_Radio.AutoSize = true;
            Red_Radio.Location = new Point(6, 26);
            Red_Radio.Name = "Red_Radio";
            Red_Radio.Size = new Size(56, 24);
            Red_Radio.TabIndex = 0;
            Red_Radio.TabStop = true;
            Red_Radio.Text = "Red";
            Red_Radio.UseVisualStyleBackColor = true;
            Red_Radio.CheckedChanged += red_CheckedChanged;
            // 
            // featuresGroupBox
            // 
            featuresGroupBox.Controls.Add(laneCheckBox);
            featuresGroupBox.Controls.Add(siriusCheckBox);
            featuresGroupBox.Controls.Add(powwinCheckBox);
            featuresGroupBox.Controls.Add(AirCondition_CheckBox);
            featuresGroupBox.Location = new Point(580, 14);
            featuresGroupBox.Name = "featuresGroupBox";
            featuresGroupBox.Size = new Size(221, 125);
            featuresGroupBox.TabIndex = 6;
            featuresGroupBox.TabStop = false;
            featuresGroupBox.Text = "&Features";
            // 
            // laneCheckBox
            // 
            laneCheckBox.AutoSize = true;
            laneCheckBox.Location = new Point(4, 95);
            laneCheckBox.Name = "laneCheckBox";
            laneCheckBox.Size = new Size(103, 24);
            laneCheckBox.TabIndex = 8;
            laneCheckBox.Text = "Lane Assist";
            laneCheckBox.UseVisualStyleBackColor = true;
            // 
            // siriusCheckBox
            // 
            siriusCheckBox.AutoSize = true;
            siriusCheckBox.Location = new Point(4, 72);
            siriusCheckBox.Name = "siriusCheckBox";
            siriusCheckBox.Size = new Size(109, 24);
            siriusCheckBox.TabIndex = 7;
            siriusCheckBox.Text = "Sirius Radio";
            siriusCheckBox.UseVisualStyleBackColor = true;
            // 
            // powwinCheckBox
            // 
            powwinCheckBox.AutoSize = true;
            powwinCheckBox.Location = new Point(4, 49);
            powwinCheckBox.Name = "powwinCheckBox";
            powwinCheckBox.Size = new Size(136, 24);
            powwinCheckBox.TabIndex = 1;
            powwinCheckBox.Text = "Power Windows";
            powwinCheckBox.UseVisualStyleBackColor = true;
            // 
            // AirCondition_CheckBox
            // 
            AirCondition_CheckBox.AutoSize = true;
            AirCondition_CheckBox.Location = new Point(4, 26);
            AirCondition_CheckBox.Name = "AirCondition_CheckBox";
            AirCondition_CheckBox.Size = new Size(56, 24);
            AirCondition_CheckBox.TabIndex = 0;
            AirCondition_CheckBox.Text = "A/C";
            AirCondition_CheckBox.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(25, 261);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 37);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "&Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submit_Click;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.BorderStyle = BorderStyle.FixedSingle;
            sumLabel.Location = new Point(230, 269);
            sumLabel.MinimumSize = new Size(500, 150);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(500, 150);
            sumLabel.TabIndex = 10;
            sumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sumLabel);
            Controls.Add(submitBtn);
            Controls.Add(featuresGroupBox);
            Controls.Add(colorGroupBox);
            Controls.Add(yearTextBox);
            Controls.Add(yearLbl);
            Controls.Add(mamoListBox);
            Controls.Add(mamoLbl);
            Name = "frmMain";
            Text = "Assignment 2";
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            featuresGroupBox.ResumeLayout(false);
            featuresGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mamoLbl;
        private ListBox mamoListBox;
        private Label yearLbl;
        private TextBox yearTextBox;
        private GroupBox colorGroupBox;
        private RadioButton Blue_Radio;
        private RadioButton Red_Radio;
        private RadioButton Green_Radio;
        private RadioButton Black_Radio;
        private GroupBox featuresGroupBox;
        private CheckBox AirCondition_CheckBox;
        private CheckBox siriusCheckBox;
        private CheckBox powwinCheckBox;
        private CheckBox laneCheckBox;
        private Button submitBtn;
        private Label sumLabel;
    }
}
