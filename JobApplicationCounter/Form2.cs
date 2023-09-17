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
    public partial class Form2 : Form
    {
        private const string appliedCompanyNamesFilePath = ".\\applied_company_names.txt";
        private const string logFilePath = ".\\log.txt";

        public Form2()
        {
            InitializeComponent();
            LoadDataFromTxt();
        }

        private void LoadDataFromTxt()
        {
            // Remove the empty column at the beginning
            recordsDataGridView.RowHeadersVisible = false;

            // Iterate through all columns in the DataGridView
            foreach (DataGridViewColumn column in recordsDataGridView.Columns)
            {
                // Access the header cell style
                DataGridViewCellStyle columnHeaderStyle = column.HeaderCell.Style;
                columnHeaderStyle.Font = new Font("Segeo UI", 9, FontStyle.Bold);
            }

            // Adjust AutoSizeMode for columns
            recordsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            recordsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            // Populate the DataGridView with data from the text file
            // Read all lines from the text file into a string array
            string[] lines = File.ReadAllLines(appliedCompanyNamesFilePath);

            // Parse the lines and add data to the DataTable
            foreach (string line in lines)
            {
                string[] parts = line.Split('-'); // Split the line into parts
                if (parts.Length >= 2)
                {
                    // Add a new row with the CompanyName and JobTitle
                    recordsDataGridView.Rows.Add(parts[0].Trim(), parts[1].Trim());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // Export the datagridview as a csv file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Title = "Export data to CSV file";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Create a StreamWriter to write data to the CSV file
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Write the column headers (DataGridView column names)
                        for (int i = 0; i < recordsDataGridView.Columns.Count; i++)
                        {
                            writer.Write(recordsDataGridView.Columns[i].HeaderText);
                            if (i < recordsDataGridView.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write the data from each row
                        foreach (DataGridViewRow row in recordsDataGridView.Rows)
                        {
                            for (int i = 0; i < recordsDataGridView.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < recordsDataGridView.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }

                        MessageBox.Show("Data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // log the action
                        using (StreamWriter logWriter = File.AppendText(logFilePath))
                        {
                            logWriter.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Exported data to {filePath}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // log the action
                    using (StreamWriter logWriter = File.AppendText(logFilePath))
                    {
                        logWriter.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Error exporting data to {filePath}");
                    }
                }
            }
        }
    }
}
