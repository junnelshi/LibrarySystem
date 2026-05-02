using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form3 : Form
    {
        private OleDbConnection con;
        private string originalID;

        public Form3()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(
             System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location),
                 "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
            loaddatagridview();
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "Select* from book order by CLng(accession_number) ASC", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            grid1.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "Select * from book where title like '%" + txtSearch.Text +
                "%' or author like '%" + txtSearch.Text +
                "%' or accession_number like '%" + txtSearch.Text +
                "%' order by CLng(accession_number) ASC", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
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
                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Accession number already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                OleDbCommand com = new OleDbCommand(
                    "insert into book values('" + txtBookID.Text + "','"
                    + txtTitle.Text + "','" + txtAuthor.Text + "')", con);
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
                if (string.IsNullOrWhiteSpace(txtBookID.Text) ||
                    string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthor.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Validation");
                    return;
                }

                con.Open();

                OleDbCommand com = new OleDbCommand(
                    "UPDATE book SET accession_number='" + txtBookID.Text +
                    "', title='" + txtTitle.Text +
                    "', author='" + txtAuthor.Text +
                    "' WHERE accession_number='" + originalID + "'", con);

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
            if (grid1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.", "Delete");
                return;
            }

            try
            {
                // Get ID directly from the selected row
                string num = grid1.CurrentRow.Cells["accession_number"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?",
                    "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand(
                        "Delete from book where accession_number='" + num + "'", con);
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

        private void grid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalID = grid1.Rows[e.RowIndex].Cells["accession_number"].Value.ToString();
                txtBookID.Text = originalID;
                txtTitle.Text = grid1.Rows[e.RowIndex].Cells["title"].Value.ToString();
                txtAuthor.Text = grid1.Rows[e.RowIndex].Cells["author"].Value.ToString();
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