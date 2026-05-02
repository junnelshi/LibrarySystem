using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 books = new Form3();
            books.Show();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 borrower = new Form4();
            borrower.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Reports submenu placeholder
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports module coming soon.", "Reports");
        }

        // Handle form close - show login again
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 transaction = new Form5();
            transaction.Show();
        }
    }
}