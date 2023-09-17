namespace JobApplicationCounter
{
    partial class Form1
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
            countLabel = new Label();
            titleLabel = new Label();
            addButton = new Button();
            displayButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            countLabel.Location = new Point(160, 94);
            countLabel.Margin = new Padding(0);
            countLabel.Name = "countLabel";
            countLabel.RightToLeft = RightToLeft.Yes;
            countLabel.Size = new Size(53, 81);
            countLabel.TabIndex = 0;
            countLabel.Text = " ";
            countLabel.TextAlign = ContentAlignment.MiddleLeft;
            countLabel.Click += countLabel_Click;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(45, 35);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(281, 41);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Applied Job Count";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addButton
            // 
            addButton.Location = new Point(134, 219);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 38);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // displayButton
            // 
            displayButton.Location = new Point(134, 267);
            displayButton.Margin = new Padding(4, 5, 4, 5);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(107, 38);
            displayButton.TabIndex = 3;
            displayButton.Text = "Display";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // clearButton
            // 
            clearButton.ForeColor = SystemColors.InactiveCaption;
            clearButton.Location = new Point(134, 315);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(107, 38);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 394);
            Controls.Add(countLabel);
            Controls.Add(titleLabel);
            Controls.Add(clearButton);
            Controls.Add(displayButton);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Job Count";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label countLabel;
        private Label titleLabel;
        private Button addButton;
        private Button displayButton;
        private Button clearButton;


    }
}