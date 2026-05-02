using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form4 : Form
    {
        private OleDbConnection con;
        private string originalID;

        public Form4()
        {
            InitializeComponent();
            string dbPath = System.IO.Path.Combine(
                System.IO.Path.GetDirectoryName(
                     System.Reflection.Assembly.GetExecutingAssembly().Location),
                    "LibSys.mdb");
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loaddatagridview();
        }

        private void loaddatagridview()
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "Select* from borrowerid order by borrowerid", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            gridBorrower.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand(
                "Select * from borrowerid where name like '%" + txtSearch.Text +
                "%' or contactNum like '%" + txtSearch.Text +
                "%' or borrowerid like '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            gridBorrower.DataSource = tab;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBorrowerID.Clear();
            txtName.Clear();
            txtContact.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowerID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation");
                return;
            }

            try
            {
                con.Open();

                OleDbCommand check = new OleDbCommand(
                    "SELECT COUNT(*) FROM borrowerid WHERE borrowerid='" + txtBorrowerID.Text + "'", con);
                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Borrower ID already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                OleDbCommand com = new OleDbCommand(
                    "insert into borrowerid values('" + txtBorrowerID.Text + "','"
                    + txtName.Text + "','" + txtContact.Text + "')", con);
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
                if (string.IsNullOrWhiteSpace(txtBorrowerID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtContact.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Validation");
                    return;
                }

                con.Open();

                OleDbCommand com = new OleDbCommand(
                    "UPDATE borrowerid SET borrowerid='" + txtBorrowerID.Text +
                    "', name='" + txtName.Text +
                    "', contactNum='" + txtContact.Text +
                    "' WHERE borrowerid='" + originalID + "'", con);

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
            if (gridBorrower.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.", "Delete");
                return;
            }

            try
            {
                string num = gridBorrower.CurrentRow.Cells["borrowerid"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this?",
                    "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand com = new OleDbCommand(
                        "Delete from borrowerid where borrowerid='" + num + "'", con);
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

        private void gridBorrower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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