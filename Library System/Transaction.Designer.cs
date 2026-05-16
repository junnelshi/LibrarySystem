namespace LibrarySystem
{
    partial class Transaction
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBorrower = new System.Windows.Forms.ComboBox();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.dtpBorrowed = new System.Windows.Forms.DateTimePicker();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBorrower = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gridTransaction = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout(); this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            this.SuspendLayout();

            this.groupBox1.Controls.Add(this.lblBorrower); this.groupBox1.Controls.Add(this.cboBorrower);
            this.groupBox1.Controls.Add(this.lblBook); this.groupBox1.Controls.Add(this.cboBook);
            this.groupBox1.Controls.Add(this.lblBorrowed); this.groupBox1.Controls.Add(this.dtpBorrowed);
            this.groupBox1.Controls.Add(this.lblReturned); this.groupBox1.Controls.Add(this.dtpReturned);
            this.groupBox1.Controls.Add(this.lblStatus); this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.btnAdd); this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate); this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12); this.groupBox1.Size = new System.Drawing.Size(560, 200); this.groupBox1.Text = "Transaction Details";

            this.lblBorrower.AutoSize = true; this.lblBorrower.Location = new System.Drawing.Point(10, 30); this.lblBorrower.Text = "Borrower";
            this.cboBorrower.Location = new System.Drawing.Point(110, 27); this.cboBorrower.Size = new System.Drawing.Size(200, 23); this.cboBorrower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblBook.AutoSize = true; this.lblBook.Location = new System.Drawing.Point(10, 60); this.lblBook.Text = "Book";
            this.cboBook.Location = new System.Drawing.Point(110, 57); this.cboBook.Size = new System.Drawing.Size(200, 23); this.cboBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblBorrowed.AutoSize = true; this.lblBorrowed.Location = new System.Drawing.Point(10, 90); this.lblBorrowed.Text = "Date Borrowed";
            this.dtpBorrowed.Location = new System.Drawing.Point(110, 87); this.dtpBorrowed.Size = new System.Drawing.Size(200, 23); this.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblReturned.AutoSize = true; this.lblReturned.Location = new System.Drawing.Point(10, 120); this.lblReturned.Text = "Date Returned";
            this.dtpReturned.Location = new System.Drawing.Point(110, 117); this.dtpReturned.Size = new System.Drawing.Size(200, 23); this.dtpReturned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblStatus.AutoSize = true; this.lblStatus.Location = new System.Drawing.Point(10, 150); this.lblStatus.Text = "Status";
            this.txtStatus.Location = new System.Drawing.Point(110, 147); this.txtStatus.Size = new System.Drawing.Size(200, 23);

            this.btnAdd.Location = new System.Drawing.Point(330, 27); this.btnAdd.Size = new System.Drawing.Size(75, 23); this.btnAdd.Text = "Add"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnSave.Location = new System.Drawing.Point(420, 27); this.btnSave.Size = new System.Drawing.Size(75, 23); this.btnSave.Text = "Save"; this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnUpdate.Location = new System.Drawing.Point(330, 57); this.btnUpdate.Size = new System.Drawing.Size(75, 23); this.btnUpdate.Text = "Update"; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Location = new System.Drawing.Point(420, 57); this.btnDelete.Size = new System.Drawing.Size(75, 23); this.btnDelete.Text = "Delete"; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.groupBox2.Controls.Add(this.lblSearch); this.groupBox2.Controls.Add(this.txtSearch); this.groupBox2.Controls.Add(this.gridTransaction);
            this.groupBox2.Location = new System.Drawing.Point(12, 220); this.groupBox2.Size = new System.Drawing.Size(560, 300); this.groupBox2.Text = "Transaction Records";

            this.lblSearch.AutoSize = true; this.lblSearch.Location = new System.Drawing.Point(10, 25); this.lblSearch.Text = "Search";
            this.txtSearch.Location = new System.Drawing.Point(70, 22); this.txtSearch.Size = new System.Drawing.Size(420, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.gridTransaction.Location = new System.Drawing.Point(10, 55); this.gridTransaction.Size = new System.Drawing.Size(535, 230);
            this.gridTransaction.AllowUserToAddRows = false; this.gridTransaction.ReadOnly = true;
            this.gridTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransaction_CellClick);

            this.ClientSize = new System.Drawing.Size(590, 540);
            this.Controls.Add(this.groupBox1); this.Controls.Add(this.groupBox2);
            this.Name = "Transaction"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.groupBox1.ResumeLayout(false); this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false); this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1, groupBox2;
        private System.Windows.Forms.Label lblBorrower, lblBook, lblBorrowed, lblReturned, lblStatus, lblSearch;
        private System.Windows.Forms.ComboBox cboBorrower, cboBook;
        private System.Windows.Forms.DateTimePicker dtpBorrowed, dtpReturned;
        private System.Windows.Forms.TextBox txtStatus, txtSearch;
        private System.Windows.Forms.Button btnAdd, btnSave, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView gridTransaction;
    }
}
