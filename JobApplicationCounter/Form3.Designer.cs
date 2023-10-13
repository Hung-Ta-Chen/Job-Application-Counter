namespace JobApplicationCounter
{
    partial class Form3
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
            companyRadioButton = new RadioButton();
            titleRadioButton = new RadioButton();
            locationRadioButton = new RadioButton();
            dateRadioButton = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // companyRadioButton
            // 
            companyRadioButton.AutoSize = true;
            companyRadioButton.Checked = true;
            companyRadioButton.Location = new Point(34, 66);
            companyRadioButton.Name = "companyRadioButton";
            companyRadioButton.Size = new Size(166, 29);
            companyRadioButton.TabIndex = 0;
            companyRadioButton.TabStop = true;
            companyRadioButton.Text = "Company Name";
            companyRadioButton.UseVisualStyleBackColor = true;
            companyRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // titleRadioButton
            // 
            titleRadioButton.AutoSize = true;
            titleRadioButton.Location = new Point(34, 101);
            titleRadioButton.Name = "titleRadioButton";
            titleRadioButton.Size = new Size(102, 29);
            titleRadioButton.TabIndex = 1;
            titleRadioButton.Text = "Job Title";
            titleRadioButton.UseVisualStyleBackColor = true;
            // 
            // locationRadioButton
            // 
            locationRadioButton.AutoSize = true;
            locationRadioButton.Location = new Point(34, 136);
            locationRadioButton.Name = "locationRadioButton";
            locationRadioButton.Size = new Size(137, 29);
            locationRadioButton.TabIndex = 2;
            locationRadioButton.Text = "Job Location";
            locationRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateRadioButton
            // 
            dateRadioButton.AutoSize = true;
            dateRadioButton.Location = new Point(34, 171);
            dateRadioButton.Name = "dateRadioButton";
            dateRadioButton.Size = new Size(169, 29);
            dateRadioButton.TabIndex = 3;
            dateRadioButton.Text = "Application Date";
            dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 4;
            label1.Text = "Column to Sort";
            // 
            // button1
            // 
            button1.Location = new Point(25, 223);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(124, 223);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(85, 34);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 279);
            Controls.Add(cancelButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dateRadioButton);
            Controls.Add(locationRadioButton);
            Controls.Add(titleRadioButton);
            Controls.Add(companyRadioButton);
            Name = "Form3";
            Text = "Sorting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton companyRadioButton;
        private RadioButton titleRadioButton;
        private RadioButton locationRadioButton;
        private RadioButton dateRadioButton;
        private Label label1;
        private Button button1;
        private Button cancelButton;
    }
}