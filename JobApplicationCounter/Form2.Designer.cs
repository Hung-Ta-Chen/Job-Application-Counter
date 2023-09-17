namespace JobApplicationCounter
{
    partial class Form2
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
            recordsDataGridView = new DataGridView();
            okButton = new Button();
            exportButton = new Button();
            titleLabel = new Label();
            companyName = new DataGridViewTextBoxColumn();
            jobTitle = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // recordsDataGridView
            // 
            recordsDataGridView.AllowUserToAddRows = false;
            recordsDataGridView.AllowUserToDeleteRows = false;
            recordsDataGridView.AllowUserToResizeRows = false;
            recordsDataGridView.BackgroundColor = SystemColors.Window;
            recordsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordsDataGridView.Columns.AddRange(new DataGridViewColumn[] { companyName, jobTitle });
            recordsDataGridView.Location = new Point(25, 75);
            recordsDataGridView.Name = "recordsDataGridView";
            recordsDataGridView.ReadOnly = true;
            recordsDataGridView.RowHeadersWidth = 200;
            recordsDataGridView.RowTemplate.Height = 33;
            recordsDataGridView.Size = new Size(530, 305);
            recordsDataGridView.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Location = new Point(325, 398);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(443, 398);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(112, 34);
            exportButton.TabIndex = 4;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(27, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(200, 32);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "All Applied Jobs";
            titleLabel.Click += label1_Click;
            // 
            // companyName
            // 
            companyName.HeaderText = "Company Name";
            companyName.MinimumWidth = 8;
            companyName.Name = "companyName";
            companyName.ReadOnly = true;
            companyName.Width = 250;
            // 
            // jobTitle
            // 
            jobTitle.HeaderText = "Job Title";
            jobTitle.MinimumWidth = 8;
            jobTitle.Name = "jobTitle";
            jobTitle.ReadOnly = true;
            jobTitle.Width = 150;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 444);
            Controls.Add(titleLabel);
            Controls.Add(okButton);
            Controls.Add(exportButton);
            Controls.Add(recordsDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Display";
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView recordsDataGridView;
        private Button okButton;
        private Button exportButton;
        private Label titleLabel;
        private DataGridViewTextBoxColumn companyName;
        private DataGridViewTextBoxColumn jobTitle;
    }
}