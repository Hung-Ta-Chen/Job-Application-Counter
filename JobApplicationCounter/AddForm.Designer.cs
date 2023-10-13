namespace JobApplicationCounter
{
    partial class AddForm
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            jobTitleLabel = new Label();
            companyNameLabel = new Label();
            panel2 = new Panel();
            dayComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            locationTextBox = new TextBox();
            jobTitleTextBox = new TextBox();
            companyNameTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(jobTitleLabel);
            panel1.Controls.Add(companyNameLabel);
            panel1.Location = new Point(23, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 215);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 163);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "Date: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 115);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "Location: ";
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            jobTitleLabel.Location = new Point(3, 68);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new Size(95, 25);
            jobTitleLabel.TabIndex = 1;
            jobTitleLabel.Text = "Job Title: ";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            companyNameLabel.Location = new Point(3, 22);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(157, 25);
            companyNameLabel.TabIndex = 0;
            companyNameLabel.Text = "Company Name: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dayComboBox);
            panel2.Controls.Add(monthComboBox);
            panel2.Controls.Add(yearComboBox);
            panel2.Controls.Add(locationTextBox);
            panel2.Controls.Add(jobTitleTextBox);
            panel2.Controls.Add(companyNameTextBox);
            panel2.Location = new Point(193, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 215);
            panel2.TabIndex = 1;
            // 
            // dayComboBox
            // 
            dayComboBox.DropDownHeight = 150;
            dayComboBox.FormattingEnabled = true;
            dayComboBox.IntegralHeight = false;
            dayComboBox.Location = new Point(190, 160);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(68, 33);
            dayComboBox.TabIndex = 5;
            dayComboBox.Text = "Day";
            dayComboBox.TextChanged += elementTextChanged;
            // 
            // monthComboBox
            // 
            monthComboBox.DropDownHeight = 150;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.IntegralHeight = false;
            monthComboBox.Location = new Point(92, 160);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(92, 33);
            monthComboBox.TabIndex = 4;
            monthComboBox.Text = "Month";
            monthComboBox.TextChanged += elementTextChanged;
            // 
            // yearComboBox
            // 
            yearComboBox.DropDownHeight = 150;
            yearComboBox.FormattingEnabled = true;
            yearComboBox.IntegralHeight = false;
            yearComboBox.Location = new Point(3, 160);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(83, 33);
            yearComboBox.TabIndex = 3;
            yearComboBox.Text = "Year";
            yearComboBox.TextChanged += elementTextChanged;
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(3, 112);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(255, 31);
            locationTextBox.TabIndex = 2;
            locationTextBox.TextChanged += elementTextChanged;
            // 
            // jobTitleTextBox
            // 
            jobTitleTextBox.Location = new Point(3, 65);
            jobTitleTextBox.Name = "jobTitleTextBox";
            jobTitleTextBox.Size = new Size(255, 31);
            jobTitleTextBox.TabIndex = 1;
            jobTitleTextBox.TextChanged += elementTextChanged;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.BackColor = SystemColors.Window;
            companyNameTextBox.Location = new Point(3, 19);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(255, 31);
            companyNameTextBox.TabIndex = 0;
            companyNameTextBox.TextChanged += elementTextChanged;
            // 
            // okButton
            // 
            okButton.Location = new Point(230, 255);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(348, 255);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 301);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddForm";
            Text = "Add";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label companyNameLabel;
        private Panel panel2;
        private Label jobTitleLabel;
        private TextBox jobTitleTextBox;
        private TextBox companyNameTextBox;
        private Label label1;
        private TextBox locationTextBox;
        private Button okButton;
        private Button cancelButton;
        private Label label2;
        private ComboBox yearComboBox;
        private ComboBox dayComboBox;
        private ComboBox monthComboBox;
    }
}