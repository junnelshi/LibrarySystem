using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class Report : Form
    {
        private OleDbConnection con;
        private DataGridView grid;
        private Label lblTitle;
        private string reportType;

        public Report(string type)
        {
            reportType = type;
            string dbPath = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location),
                "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
            BuildUI();
            LoadData();
        }

        private void BuildUI()
        {
            this.Text = "Report - " + reportType;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label();
            lblTitle.Text = reportType + " Report";
            lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(20, 15);

            grid = new DataGridView();
            grid.Location = new System.Drawing.Point(20, 55);
            grid.Size = new System.Drawing.Size(655, 415);
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(lblTitle);
            this.Controls.Add(grid);
        }

        private void LoadData()
        {
            try
            {
                string query = "";

                if (reportType == "Borrower")
                    query = "SELECT borrowerid AS BorrowerID, name AS Name, contactNum AS Contact FROM borrowerid ORDER BY borrowerid";
                else if (reportType == "Book")
                    query = "SELECT accession_number AS AccessionNo, title AS Title, author AS Author FROM book ORDER BY CLng(accession_number) ASC";
                else if (reportType == "Transaction")
                    query = "SELECT t.transaction_id AS TransID, b.name AS Borrower, bk.title AS BookTitle, " +
                            "t.date_borrowed AS DateBorrowed, t.date_returned AS DateReturned, t.status AS Status " +
                            "FROM ([transaction] t LEFT JOIN borrowerid b ON t.borrowerid = b.borrowerid) " +
                            "LEFT JOIN book bk ON t.accession_number = bk.accession_number ORDER BY t.transaction_id";

                con.Open();
                OleDbDataAdapter adap = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}