using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Simple hardcoded credentials (you can replace with DB later)
            if (username == "admin" && password == "admin")
            {
                Form2 menu = new Form2();
                menu.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}