using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Borrower : Form
    {
        private OleDbConnection con;
        private string originalID;

        public Borrower()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location),
                "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
        }

        private void Borrower_Load(object sender, EventArgs e) { loaddatagridview(); }

        private void loaddatagridview()
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM borrowerid ORDER BY borrowerid", con);
            DataTable dt = new DataTable(); adap.Fill(dt);
            gridBorrower.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter(
                "SELECT * FROM borrowerid WHERE name LIKE '%" + txtSearch.Text +
                "%' OR contactNum LIKE '%" + txtSearch.Text +
                "%' OR borrowerid LIKE '%" + txtSearch.Text + "%'", con);
            DataTable tab = new DataTable(); adap.Fill(tab);
            gridBorrower.DataSource = tab;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) { txtBorrowerID.Clear(); txtName.Clear(); txtContact.Clear(); }
        private void btnEdit_Click(object sender, EventArgs e) { txtName.Focus(); }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowerID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            { MessageBox.Show("Please fill all fields.", "Validation"); return; }
            try
            {
                con.Open();
                OleDbCommand check = new OleDbCommand("SELECT COUNT(*) FROM borrowerid WHERE borrowerid='" + txtBorrowerID.Text + "'", con);
                if ((int)check.ExecuteScalar() > 0) { MessageBox.Show("Borrower ID already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning); con.Close(); return; }
                new OleDbCommand("INSERT INTO borrowerid VALUES('" + txtBorrowerID.Text + "','" + txtName.Text + "','" + txtContact.Text + "')", con).ExecuteNonQuery();
                MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); loaddatagridview();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowerID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            { MessageBox.Show("Please fill all fields.", "Validation"); return; }
            try
            {
                con.Open();
                new OleDbCommand("UPDATE borrowerid SET borrowerid='" + txtBorrowerID.Text + "', name='" + txtName.Text + "', contactNum='" + txtContact.Text + "' WHERE borrowerid='" + originalID + "'", con).ExecuteNonQuery();
                MessageBox.Show("Successfully UPDATED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close(); loaddatagridview();
            }
            catch (Exception ex) { MessageBox.Show("Update failed: " + ex.Message); if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridBorrower.CurrentRow == null) { MessageBox.Show("Please select a record to delete."); return; }
            try
            {
                string num = gridBorrower.CurrentRow.Cells["borrowerid"].Value.ToString();
                if (MessageBox.Show("Are you sure you want to delete this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    new OleDbCommand("DELETE FROM borrowerid WHERE borrowerid='" + num + "'", con).ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddatagridview();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void gridBorrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalID = gridBorrower.Rows[e.RowIndex].Cells["borrowerid"].Value.ToString();
                txtBorrowerID.Text = originalID;
                txtName.Text = gridBorrower.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtContact.Text = gridBorrower.Rows[e.RowIndex].Cells["contactNum"].Value.ToString();
            }
        }
    }
}
