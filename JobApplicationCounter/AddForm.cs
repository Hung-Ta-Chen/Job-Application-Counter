using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationCounter
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text == "" || jobTitleTextBox.Text == "")
            {
                MessageBox.Show("All fields must be filled!");
                if (companyNameTextBox.Text == "")
                {
                    companyNameTextBox.BackColor = SystemColors.InactiveCaption;
                }
                if (jobTitleTextBox.Text == "")
                {
                    jobTitleTextBox.BackColor = SystemColors.InactiveCaption;
                }
            }
            else
            {
                // Set the dialog result to OK and close the form
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Set the dialog result to Cancel and close the form
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            companyNameTextBox.BackColor = SystemColors.Window;
        }

        private void jobTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            companyNameTextBox.BackColor = SystemColors.Window;
        }

        // Properties to get the company name and job title
        // Control class already has a property called CompanyName, so we need to use a different name
        public string NewCompanyName
        {
            get
            {
                return companyNameTextBox.Text;
            }
        }

        public string JobTitle
        {
            get
            {
                return jobTitleTextBox.Text;
            }
        }
    }
}
