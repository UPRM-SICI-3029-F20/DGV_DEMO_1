using System;
using System.IO;
using System.Windows.Forms;

namespace DGV_DEMO_1
{
    public partial class Form1 : Form
    {
        // Class variables
        string[,] dataArray = null;
        int rows, columns;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            // Edit the following path according to your environment
            openFileDialog.InitialDirectory = "C:\\Users\\Jose\\Desktop\\App_Data";
            // Select input file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    // Read file and add data to ListBox, then
                    // save data to a 2D Array named dataArray
                    putDataInto2DArray(getAndDisplayData(ref inputFile));
                    // Hint: putDataInto2DArray(datarows)

                    // Close the file
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }

        }

        public string[] getAndDisplayData(ref StreamReader inputFile)
        {
            // Temporarily read all rows into an array 
            string[] allLines = File.ReadAllLines(openFileDialog.FileName);

            // rows is the same as the length/count of all lines
            rows = allLines.Length;
            // columns is the same as the number of tokens
            columns = allLines[0].Split(',').Length;
            MessageBox.Show("File has " + rows + " rows and " + columns + " columns");

            // Clear Listbox
            listBoxInput.Items.Clear();
            // Read/save all rows & display each line in the listbox
            // Declare array of "rows"size
            string[] dataRows = new string[rows];
            for (int i = 0; i < dataRows.Length; i++)
            {
                // Read each row/line
                dataRows[i] = inputFile.ReadLine();
                // Display the row/line -- a single string
                listBoxInput.Items.Add(dataRows[i]);
            }

            // Return the ref to the data
            return dataRows;
        }


        public void putDataInto2DArray(string[] dataRows)
        {
            dataArray = new string[rows, columns];
            string[] dataElements = null;

            // Loop & Process row by row
            for (int i = 0; i < dataRows.Length; i++)
            {
                dataElements = dataRows[i].Split(',');
                for (int j = 0; j < dataElements.Length; j++)
                {
                    dataArray[i, j] = dataElements[j];
                }
            }
            //return dataArray;
        }


        public void arrayToDGV(string[,] dataArray)
        {
            //Clear all DGV rows
            dgvDemo.Rows.Clear();

            int dataRows = dataArray.GetLength(0); // Length of First Dimension 
            int dataCols = dataArray.GetLength(1); // Length of Second Dimension

            // Add columns with headers & properties from first row
            string colHeader;
            for (int i = 0; i < dataCols; i++)
            {
                colHeader = dataArray[0, i];
                dgvDemo.Columns.Add(colHeader, colHeader);
                //**dgvDemo.Columns[i].DataPropertyName = colHeader;
                //**dgvDemo.Columns[i].HeaderText = colHeader;
            }

            // Assumes row=0 contains headers
            // Populate rows with content beyond 
            for (int row = 1; row < dataRows; row++)
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(this.dgvDemo);

                for (int col = 0; col < dataCols; col++)
                {
                    dgvRow.Cells[col].Value = dataArray[row, col];
                }

                this.dgvDemo.Rows.Add(dgvRow);
            }
        }

        private void BtnDataToDGV_Click(object sender, EventArgs e)
        {
            // Create a DGV with the array data
            arrayToDGV(dataArray);
        }

        private void BtnDataFromDGV_Click(object sender, EventArgs e)
        {

                string[,] saveArray = new string[dgvDemo.RowCount, dgvDemo.ColumnCount];
                string[] saveRow = new string[dgvDemo.RowCount];
                string[] rowElements = new string[dgvDemo.ColumnCount];
                //MessageBox.Show("Rows: " + dgvDemo.RowCount); 
                
                // Get headers
                for (int i = 0; i < dgvDemo.ColumnCount; i++)
                {
                    saveArray[0, i] = dgvDemo.Columns[i].HeaderText;
                }

                //DataGridViewRow row2 = dgvDemo.Rows[0];

                for (int i = 0; i < dgvDemo.RowCount - 1; i++)
                //foreach (DataGridViewRow row in dgvDemo.Rows)
                {
                    foreach (DataGridViewColumn col in dgvDemo.Columns)
                    {
                        saveArray[i + 1, col.Index] =
                           dgvDemo.Rows[i].Cells[col.Index].FormattedValue.ToString().Trim();
                    }
                }

                // Clear listbox
                listBoxOutput.Items.Clear();

                for (int i = 0; i < saveArray.GetLength(0); i++)
                {
                    for (int j = 0; j < saveArray.GetLength(1); j++)
                    {
                        rowElements[j] = saveArray[i, j];
                    }

                    saveRow[i] = String.Join(",", rowElements);
                    listBoxOutput.Items.Add(saveRow[i]);
                }
        }


        private void BtnSaveData_Click(object sender, EventArgs e)
        {
            // Edit the following path according to your environment
            saveFileDialog.InitialDirectory = "C:\\Users\\Jose\\Desktop\\App_Data";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    StreamWriter myOutputFile;
                    myOutputFile = File.CreateText(saveFileDialog.FileName);

                    foreach (string s in listBoxOutput.Items)
                    {
                        myOutputFile.WriteLine(s);
                    }

                    myOutputFile.Close();

                    MessageBox.Show("Data saved to file");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }
        }


    private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
