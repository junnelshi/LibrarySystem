using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class MasterFiles : Form
    {
        public MasterFiles()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book books = new Book();
            books.Show();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void reportBorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report("Borrower");
            report.Show();
        }

        private void reportBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report("Book");
            report.Show();
        }

        private void reportTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report("Transaction");
            report.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MasterFiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}