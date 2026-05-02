namespace LibrarySystem
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            this.SuspendLayout();

            // groupBox1 - Transaction Details
            this.groupBox1.Controls.Add(this.lblBorrower);
            this.groupBox1.Controls.Add(this.cboBorrower);
            this.groupBox1.Controls.Add(this.lblBook);
            this.groupBox1.Controls.Add(this.cboBook);
            this.groupBox1.Controls.Add(this.lblBorrowed);
            this.groupBox1.Controls.Add(this.dtpBorrowed);
            this.groupBox1.Controls.Add(this.lblReturned);
            this.groupBox1.Controls.Add(this.dtpReturned);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";

            // lblBorrower
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.Location = new System.Drawing.Point(10, 30);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Text = "Borrower";

            // cboBorrower
            this.cboBorrower.Location = new System.Drawing.Point(110, 27);
            this.cboBorrower.Name = "cboBorrower";
            this.cboBorrower.Size = new System.Drawing.Size(200, 23);
            this.cboBorrower.TabIndex = 0;
            this.cboBorrower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblBook
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(10, 60);
            this.lblBook.Name = "lblBook";
            this.lblBook.Text = "Book";

            // cboBook
            this.cboBook.Location = new System.Drawing.Point(110, 57);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(200, 23);
            this.cboBook.TabIndex = 1;
            this.cboBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblBorrowed
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Location = new System.Drawing.Point(10, 90);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Text = "Date Borrowed";

            // dtpBorrowed
            this.dtpBorrowed.Location = new System.Drawing.Point(110, 87);
            this.dtpBorrowed.Name = "dtpBorrowed";
            this.dtpBorrowed.Size = new System.Drawing.Size(200, 23);
            this.dtpBorrowed.TabIndex = 2;
            this.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblReturned
            this.lblReturned.AutoSize = true;
            this.lblReturned.Location = new System.Drawing.Point(10, 120);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Text = "Date Returned";

            // dtpReturned
            this.dtpReturned.Location = new System.Drawing.Point(110, 117);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(200, 23);
            this.dtpReturned.TabIndex = 3;
            this.dtpReturned.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Status";

            // txtStatus
            this.txtStatus.Location = new System.Drawing.Point(110, 147);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.TabIndex = 4;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(330, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(420, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(330, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(420, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // groupBox2 - Transaction Records
            this.groupBox2.Controls.Add(this.lblSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.gridTransaction);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Records";

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(10, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Search";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(70, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 23);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // gridTransaction
            this.gridTransaction.Location = new System.Drawing.Point(10, 55);
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.Size = new System.Drawing.Size(535, 230);
            this.gridTransaction.TabIndex = 10;
            this.gridTransaction.AllowUserToAddRows = false;
            this.gridTransaction.ReadOnly = true;
            this.gridTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransaction_CellClick);
            this.gridTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransaction_CellDoubleClick);

            // Form5
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form5";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cboBorrower;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cboBook;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.DateTimePicker dtpBorrowed;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.DateTimePicker dtpReturned;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gridTransaction;
    }
}