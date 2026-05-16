using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Book : Form
    {
        private OleDbConnection con;
        private string originalID;

        public Book()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location),
                "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
        }

        private void Book_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter(
                "SELECT * FROM book ORDER BY CLng(accession_number) ASC", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            grid1.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter(
                "SELECT * FROM book WHERE title LIKE '%" + txtSearch.Text +
                "%' OR author LIKE '%" + txtSearch.Text +
                "%' OR accession_number LIKE '%" + txtSearch.Text +
                "%' ORDER BY CLng(accession_number) ASC", con);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            grid1.DataSource = tab;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation");
                return;
            }
            try
            {
                con.Open();
                OleDbCommand check = new OleDbCommand(
                    "SELECT COUNT(*) FROM book WHERE accession_number='" + txtBookID.Text + "'", con);
                if ((int)check.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Accession number already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close(); return;
                }
                new OleDbCommand(
                    "INSERT INTO book VALUES('" + txtBookID.Text + "','" +
                    txtTitle.Text + "','" + txtAuthor.Text + "')", con).ExecuteNonQuery();
                MessageBox.Show("Successfully SAVED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(txtBookID.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation"); return;
            }
            try
            {
                con.Open();
                new OleDbCommand(
                    "UPDATE book SET accession_number='" + txtBookID.Text +
                    "', title='" + txtTitle.Text +
                    "', author='" + txtAuthor.Text +
                    "' WHERE accession_number='" + originalID + "'", con).ExecuteNonQuery();
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
            if (grid1.CurrentRow == null) { MessageBox.Show("Please select a record to delete."); return; }
            try
            {
                string num = grid1.CurrentRow.Cells["accession_number"].Value.ToString();
                if (MessageBox.Show("Are you sure you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    new OleDbCommand("DELETE FROM book WHERE accession_number='" + num + "'", con).ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully DELETED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddatagridview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalID = grid1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                txtBookID.Text = originalID;
                txtTitle.Text = grid1.Rows[e.RowIndex].Cells["title"].Value.ToString();
                txtAuthor.Text = grid1.Rows[e.RowIndex].Cells["author"].Value.ToString();
            }
        }
    }
}
