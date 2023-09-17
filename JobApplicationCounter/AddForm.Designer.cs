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
            jobTitleLabel = new Label();
            companyNameLabel = new Label();
            panel2 = new Panel();
            jobTitleTextBox = new TextBox();
            companyNameTextBox = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(jobTitleLabel);
            panel1.Controls.Add(companyNameLabel);
            panel1.Location = new Point(23, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 117);
            panel1.TabIndex = 0;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            jobTitleLabel.Location = new Point(3, 69);
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
            panel2.Controls.Add(jobTitleTextBox);
            panel2.Controls.Add(companyNameTextBox);
            panel2.Location = new Point(193, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 117);
            panel2.TabIndex = 1;
            // 
            // jobTitleTextBox
            // 
            jobTitleTextBox.Location = new Point(3, 66);
            jobTitleTextBox.Name = "jobTitleTextBox";
            jobTitleTextBox.Size = new Size(255, 31);
            jobTitleTextBox.TabIndex = 1;
            jobTitleTextBox.TextChanged += jobTitleTextBox_TextChanged;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.BackColor = SystemColors.Window;
            companyNameTextBox.Location = new Point(3, 19);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(255, 31);
            companyNameTextBox.TabIndex = 0;
            companyNameTextBox.TextChanged += companyNameTextBox_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(348, 154);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(230, 154);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 200);
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
        private Button cancelButton;
        private Button okButton;
    }
}