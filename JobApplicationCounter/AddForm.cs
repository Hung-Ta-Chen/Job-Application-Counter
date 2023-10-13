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
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Set the elements of yearComboBox to the years from 2020 to 2030
            for (int i = 2020; i <= 2030; i++)
            {
                yearComboBox.Items.Add(i);
            }

            // Set the elements of monthComboBox to the months from 1 to 12
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }

            // Set the elements of dayComboBox to the days from 1 to 31
            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text == "" || jobTitleTextBox.Text == "" || locationTextBox.Text == "" ||
                !yearComboBox.Text.All(char.IsDigit) || !monthComboBox.Text.All(char.IsDigit) || !dayComboBox.Text.All(char.IsDigit))
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
                if (locationTextBox.Text == "")
                {
                    locationTextBox.BackColor = SystemColors.InactiveCaption;
                }
                if (!yearComboBox.Text.All(char.IsDigit))
                {
                    yearComboBox.BackColor = SystemColors.InactiveCaption;
                }
                if (!monthComboBox.Text.All(char.IsDigit))
                {
                    monthComboBox.BackColor = SystemColors.InactiveCaption;
                }
                if (!dayComboBox.Text.All(char.IsDigit))
                {
                    dayComboBox.BackColor = SystemColors.InactiveCaption;
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

        private void elementTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = SystemColors.Window;
            }
            else if (sender is ComboBox comboBox)
            {
                comboBox.BackColor = SystemColors.Window;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        public string JobLocation
        {
            get
            {
                return locationTextBox.Text;
            }
        }

        public string ApplicationDate
        {
            get
            {
                return $"{yearComboBox.Text}-{monthComboBox.Text}-{dayComboBox.Text}";
            }
        }
    }
}
