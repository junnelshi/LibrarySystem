using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form5 : Form
    {
        private OleDbConnection con;
        private string originalID;

        public Form5()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(
                   System.Reflection.Assembly.GetExecutingAssembly().Location),
                    "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loaddatagridview();
            loadBorrowers();
            loadBooks();
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "Select * from [transaction] order by transaction_id", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            gridTransaction.DataSource = dt;
            con.Close();
        }

        private void loadBorrowers()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select borrowerid, name from borrowerid", con);
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();

            cboBorrower.DataSource = dt;
            cboBorrower.DisplayMember = "name";
            cboBorrower.ValueMember = "borrowerid";
            cboBorrower.SelectedIndex = -1;
        }

        private void loadBooks()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("Select accession_number, title from book", con);
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();

            cboBook.DataSource = dt;
            cboBook.DisplayMember = "title";
            cboBook.ValueMember = "accession_number";
            cboBook.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboBorrower.SelectedIndex = -1;
            cboBook.SelectedIndex = -1;
            dtpBorrowed.Value = DateTime.Now;
            dtpReturned.Value = DateTime.Now;
            txtStatus.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboBorrower.SelectedIndex == -1 ||
                cboBook.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation");
                return;
            }

            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand(
                    "INSERT INTO [transaction] (borrowerid, accession_number, date_borrowed, date_returned, status) " +
                    "VALUES ('" + cboBorrower.SelectedValue + "','" +
                    cboBook.SelectedValue + "',#" +
                    dtpBorrowed.Value.ToString("MM/dd/yyyy") + "#,#" +
                    dtpReturned.Value.ToString("MM/dd/yyyy") + "#,'" +
                    txtStatus.Text + "')", con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                loaddatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboBorrower.SelectedIndex == -1 ||
                    cboBook.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtStatus.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Validation");
                    return;
                }

                con.Open();
                OleDbCommand com = new OleDbCommand(
                    "UPDATE [transaction] SET borrowerid='" + cboBorrower.SelectedValue +
                    "', accession_number='" + cboBook.SelectedValue +
                    "', date_borrowed=#" + dtpBorrowed.Value.ToString("MM/dd/yyyy") +
                    "#, date_returned=#" + dtpReturned.Value.ToString("MM/dd/yyyy") +
                    "#, status='" + txtStatus.Text +
                    "' WHERE transaction_id=" + originalID, con);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                loaddatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridTransaction.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.", "Delete");
                return;
            }

            try
            {
                string num = gridTransaction.CurrentRow.Cells["transaction_id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?",
                    "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand(
                        "Delete from [transaction] where transaction_id=" + num, con);
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddatagridview();
                }
                else
                {
                    MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "Select * from [transaction] where borrowerid like '%" + txtSearch.Text +
                "%' or accession_number like '%" + txtSearch.Text +
                "%' or status like '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            gridTransaction.DataSource = tab;
            con.Close();
        }

        private void gridTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalID = gridTransaction.Rows[e.RowIndex].Cells["transaction_id"].Value.ToString();

                string bid = gridTransaction.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
                string acc = gridTransaction.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                string stat = gridTransaction.Rows[e.RowIndex].Cells["status"].Value.ToString();

                cboBorrower.SelectedValue = bid;
                cboBook.SelectedValue = acc;
                txtStatus.Text = stat;

                if (gridTransaction.Rows[e.RowIndex].Cells["date_borrowed"].Value != DBNull.Value)
                    dtpBorrowed.Value = Convert.ToDateTime(gridTransaction.Rows[e.RowIndex].Cells["date_borrowed"].Value);

                if (gridTransaction.Rows[e.RowIndex].Cells["date_returned"].Value != DBNull.Value)
                    dtpReturned.Value = Convert.ToDateTime(gridTransaction.Rows[e.RowIndex].Cells["date_returned"].Value);
            }
        }

        private void gridTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalID = gridTransaction.Rows[e.RowIndex].Cells["transaction_id"].Value.ToString();

                string bid = gridTransaction.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
                string acc = gridTransaction.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                string stat = gridTransaction.Rows[e.RowIndex].Cells["status"].Value.ToString();

                cboBorrower.SelectedValue = bid;
                cboBook.SelectedValue = acc;
                txtStatus.Text = stat;

                if (gridTransaction.Rows[e.RowIndex].Cells["date_borrowed"].Value != DBNull.Value)
                    dtpBorrowed.Value = Convert.ToDateTime(gridTransaction.Rows[e.RowIndex].Cells["date_borrowed"].Value);

                if (gridTransaction.Rows[e.RowIndex].Cells["date_returned"].Value != DBNull.Value)
                    dtpReturned.Value = Convert.ToDateTime(gridTransaction.Rows[e.RowIndex].Cells["date_returned"].Value);
            }
        }
    }
}