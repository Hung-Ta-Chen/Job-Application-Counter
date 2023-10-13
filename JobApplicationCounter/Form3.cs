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
    public partial class Form3 : Form
    {
        // State of the selected radio button
        // 0: companyRadioButton
        // 1: titleRadioButton
        // 2: locationRadioButton
        // 3: dateRadioButton
        private int selectedButton = 0;

        public Form3()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Perform actions based on the selected radio button.
                if (radioButton == companyRadioButton)
                {
                    selectedButton = 0;
                }
                else if (radioButton == titleRadioButton)
                {
                    selectedButton = 1;
                }
                else if (radioButton == locationRadioButton)
                {
                    selectedButton = 2;
                }
                else if (radioButton == dateRadioButton)
                {
                    selectedButton = 3;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public int SelectedButton
        {
            get { return selectedButton; }
        }
    }
}
