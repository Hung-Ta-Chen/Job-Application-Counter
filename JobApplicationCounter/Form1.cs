namespace JobApplicationCounter
{
    public partial class Form1 : Form
    {
        //private const string countFilePath = ".\\job_application_counter.txt";
        private const string appliedCompanyNamesFilePath = ".\\applied_company_names.txt";
        private const string logFilePath = ".\\log.txt";
        private int count;

        public Form1()
        {
            InitializeComponent();


            /*
            if (!File.Exists(countFilePath))
            {
                // The file doesn't exist, so create it and write to it in the same using block
                using (FileStream fs = File.Create(countFilePath)) // Create and open the file
                {
                    // Write to the file
                    File.WriteAllText(countFilePath, "0");
                    Console.WriteLine($"File {countFilePath} created.");
                }
            }
            */

            if (!File.Exists(appliedCompanyNamesFilePath))
            {
                // The file doesn't exist, so create it and write to it in the same using block
                using (FileStream fs = File.Create(appliedCompanyNamesFilePath)) // Create and open the file
                {
                    Console.WriteLine($"File {appliedCompanyNamesFilePath} created.");
                }
            }

            if (!File.Exists(logFilePath))
            {
                // The file doesn't exist, so create it and write to it in the same using block
                using (FileStream fs = File.Create(logFilePath)) // Create and open the file
                {
                    Console.WriteLine($"File {logFilePath} created.");
                }
            }

            /*
            // Open the file and fetch the count
            using (StreamReader reader = new StreamReader(countFilePath))
            {
                string line = reader.ReadLine() ?? "0";
                try
                {
                    count = Convert.ToInt32(line);
                    countLabel.Text = Convert.ToString(count);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Cannot read the count correctly");
                    countLabel.Text = "0";
                }
            }
            */

            // Open the file and fetch the count by counting the lines
            using (StreamReader reader = new StreamReader(appliedCompanyNamesFilePath))
            {
                int cnt = 0;
                while ((_ = reader.ReadLine()) != null)
                {
                    cnt++;
                }

                count = cnt;
                countLabel.Text = Convert.ToString(count);
            }

            RecenterElements();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddForm class
            using (AddForm dialog = new AddForm())
            {
                DialogResult popUpResult = dialog.ShowDialog();

                // Check if the user clicked OK
                if (popUpResult == DialogResult.OK)
                {
                    string companyName = dialog.NewCompanyName;
                    string jobTitle = dialog.JobTitle;
                    string jobLocation = dialog.JobLocation;
                    string applicationDate = dialog.ApplicationDate;

                    // Append the company name and job title to the file
                    using (StreamWriter writer = File.AppendText(appliedCompanyNamesFilePath))
                    {
                        writer.WriteLine($"{companyName} / {jobTitle} / {jobLocation} / {applicationDate}");
                    }

                    // Update the count
                    count++;
                    countLabel.Text = Convert.ToString(count);
                    //File.WriteAllText(countFilePath, Convert.ToString(count));

                    // Log the action
                    using (StreamWriter writer = File.AppendText(logFilePath))
                    {
                        writer.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Added a record [{companyName} / {jobTitle} / {jobLocation}]");
                    }
                }
            }

            RecenterElements();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string boxMessage = "Are you sure about clearing all records?";
            string boxCaption = "Clear";
            MessageBoxButtons boxButtons = MessageBoxButtons.YesNo;
            DialogResult boxResult;

            // Display the message box for comfirmation
            boxResult = MessageBox.Show(boxMessage, boxCaption, boxButtons, MessageBoxIcon.Question);

            if (boxResult == DialogResult.Yes)
            {
                // Clean the records
                File.WriteAllText(appliedCompanyNamesFilePath, "");

                // Update the count
                count = 0;
                countLabel.Text = Convert.ToString(count);

                // Log the action
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Cleared all records");
                }
            }

            RecenterElements();
        }

        private void RecenterElements()
        {
            // Center the title label
            int titleLabelX = (int)((Width - titleLabel.Width) / 2 * 0.95);
            titleLabel.Location = new System.Drawing.Point(titleLabelX, titleLabel.Location.Y);

            // Center the count label
            int countLabelX = (int)((Width - countLabel.Width) / 2 * 0.95);
            countLabel.Location = new System.Drawing.Point(countLabelX, countLabel.Location.Y);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            using(Form2 dialog = new Form2())
            {
                dialog.ShowDialog();

                // Log the action
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Displayed all records");
                }
            }
        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }


    }
}