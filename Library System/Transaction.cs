using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Transaction : Form
    {
        private OleDbConnection con;
        private string originalID;

        public Transaction()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location),
                "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            loaddatagridview();
            loadBorrowers();
            loadBooks();
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM [transaction] ORDER BY transaction_id", con);
            DataTable dt = new DataTable(); adap.Fill(dt);
            gridTransaction.DataSource = dt;
            con.Close();
        }

        private void loadBorrowers()
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT borrowerid, name FROM borrowerid", con);
            DataTable dt = new DataTable(); adap.Fill(dt); con.Close();
            cboBorrower.DataSource = dt; cboBorrower.DisplayMember = "name"; cboBorrower.ValueMember = "borrowerid"; cboBorrower.SelectedIndex = -1;
        }

        private void loadBooks()
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT accession_number, title FROM book", con);
            DataTable dt = new DataTable(); adap.Fill(dt); con.Close();
            cboBook.DataSource = dt; cboBook.DisplayMember = "title"; cboBook.ValueMember = "accession_number"; cboBook.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboBorrower.SelectedIndex = -1; cboBook.SelectedIndex = -1;
            dtpBorrowed.Value = DateTime.Now; dtpReturned.Value = DateTime.Now; txtStatus.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboBorrower.SelectedIndex == -1 || cboBook.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtStatus.Text))
            { MessageBox.Show("Please fill all fields.", "Validation"); return; }
            try
            {
                con.Open();
                new OleDbCommand("INSERT INTO [transaction] (borrowerid, accession_number, date_borrowed, date_returned, status) VALUES ('" +
                    cboBorrower.SelectedValue + "','" + cboBook.SelectedValue + "',#" +
                    dtpBorrowed.Value.ToString("MM/dd/yyyy") + "#,#" + dtpReturned.Value.ToString("MM/dd/yyyy") + "#,'" + txtStatus.Text + "')", con).ExecuteNonQuery();
                MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); loaddatagridview();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboBorrower.SelectedIndex == -1 || cboBook.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtStatus.Text))
            { MessageBox.Show("Please fill all fields.", "Validation"); return; }
            try
            {
                con.Open();
                new OleDbCommand("UPDATE [transaction] SET borrowerid='" + cboBorrower.SelectedValue +
                    "', accession_number='" + cboBook.SelectedValue +
                    "', date_borrowed=#" + dtpBorrowed.Value.ToString("MM/dd/yyyy") +
                    "#, date_returned=#" + dtpReturned.Value.ToString("MM/dd/yyyy") +
                    "#, status='" + txtStatus.Text + "' WHERE transaction_id=" + originalID, con).ExecuteNonQuery();
                MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); loaddatagridview();
            }
            catch (Exception ex) { MessageBox.Show("Update failed: " + ex.Message); if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridTransaction.CurrentRow == null) { MessageBox.Show("Please select a record to delete."); return; }
            try
            {
                string num = gridTransaction.CurrentRow.Cells["transaction_id"].Value.ToString();
                if (MessageBox.Show("Are you sure you want to delete this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    new OleDbCommand("DELETE FROM [transaction] WHERE transaction_id=" + num, con).ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddatagridview();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter(
                "SELECT * FROM [transaction] WHERE borrowerid LIKE '%" + txtSearch.Text +
                "%' OR accession_number LIKE '%" + txtSearch.Text +
                "%' OR status LIKE '%" + txtSearch.Text + "%'", con);
            DataTable tab = new DataTable(); adap.Fill(tab);
            gridTransaction.DataSource = tab;
            con.Close();
        }

        private void gridTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalID = gridTransaction.Rows[e.RowIndex].Cells["transaction_id"].Value.ToString();
                cboBorrower.SelectedValue = gridTransaction.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
                cboBook.SelectedValue = gridTransaction.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                txtStatus.Text = gridTransaction.Rows[e.RowIndex].Cells["status"].Value.ToString();
                if (gridTransaction.Rows[e.RowIndex].Cells["date_borrowed"].Value != DBNull.Value)
                    dtpBorrowed.Value = Convert.ToDateTime(gridTransaction.Rows[e.RowIndex].Cells["date_borrowed"].Value);
                if (gridTransaction.Rows[e.RowIndex].Cells["date_returned"].Value != DBNull.Value)
                    dtpReturned.Value = Convert.ToDateTime(gridTransaction.Rows[e.RowIndex].Cells["date_returned"].Value);
            }
        }
    }
}
