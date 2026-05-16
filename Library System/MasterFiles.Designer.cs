namespace LibrarySystem
{
    partial class MasterFiles
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.masterFilesToolStripMenuItem,
                this.transactionToolStripMenuItem,
                this.reportsToolStripMenuItem,
                this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;

            // masterFilesToolStripMenuItem
            this.masterFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.booksToolStripMenuItem,
                this.borrowerToolStripMenuItem});
            this.masterFilesToolStripMenuItem.Name = "masterFilesToolStripMenuItem";
            this.masterFilesToolStripMenuItem.Text = "Master Files";

            // booksToolStripMenuItem
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Text = "Book";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);

            // borrowerToolStripMenuItem
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Text = "Borrower";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);

            // transactionToolStripMenuItem
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);

            // reportsToolStripMenuItem
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.reportBorrowerToolStripMenuItem,
                this.reportBookToolStripMenuItem,
                this.reportTransactionToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Text = "Reports";

            // reportBorrowerToolStripMenuItem
            this.reportBorrowerToolStripMenuItem.Name = "reportBorrowerToolStripMenuItem";
            this.reportBorrowerToolStripMenuItem.Text = "Borrower";
            this.reportBorrowerToolStripMenuItem.Click += new System.EventHandler(this.reportBorrowerToolStripMenuItem_Click);

            // reportBookToolStripMenuItem
            this.reportBookToolStripMenuItem.Name = "reportBookToolStripMenuItem";
            this.reportBookToolStripMenuItem.Text = "Book";
            this.reportBookToolStripMenuItem.Click += new System.EventHandler(this.reportBookToolStripMenuItem_Click);

            // reportTransactionToolStripMenuItem
            this.reportTransactionToolStripMenuItem.Name = "reportTransactionToolStripMenuItem";
            this.reportTransactionToolStripMenuItem.Text = "Transaction";
            this.reportTransactionToolStripMenuItem.Click += new System.EventHandler(this.reportTransactionToolStripMenuItem_Click);

            // exitToolStripMenuItem
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LW LibSys - Library System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MasterFiles_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}