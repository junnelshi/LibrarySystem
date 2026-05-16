namespace LibrarySystem
{
    partial class Borrower
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridBorrower = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout(); this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrower)).BeginInit();
            this.SuspendLayout();

            this.groupBox1.Controls.Add(this.label1); this.groupBox1.Controls.Add(this.label2); this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBorrowerID); this.groupBox1.Controls.Add(this.txtName); this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.btnAdd); this.groupBox1.Controls.Add(this.btnEdit); this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate); this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(20, 20); this.groupBox1.Size = new System.Drawing.Size(516, 180); this.groupBox1.Text = "Borrower Details";

            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(10, 30); this.label1.Text = "Borrower ID";
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(10, 60); this.label2.Text = "Name";
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(10, 90); this.label3.Text = "Contact";

            this.txtBorrowerID.Location = new System.Drawing.Point(90, 27); this.txtBorrowerID.Size = new System.Drawing.Size(200, 22);
            this.txtName.Location = new System.Drawing.Point(90, 57); this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtContact.Location = new System.Drawing.Point(90, 87); this.txtContact.Size = new System.Drawing.Size(200, 22);

            this.btnAdd.Location = new System.Drawing.Point(310, 25); this.btnAdd.Size = new System.Drawing.Size(75, 23); this.btnAdd.Text = "Add"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Location = new System.Drawing.Point(310, 55); this.btnEdit.Size = new System.Drawing.Size(75, 23); this.btnEdit.Text = "Edit"; this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnSave.Location = new System.Drawing.Point(400, 25); this.btnSave.Size = new System.Drawing.Size(75, 23); this.btnSave.Text = "Save"; this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnUpdate.Location = new System.Drawing.Point(400, 55); this.btnUpdate.Size = new System.Drawing.Size(75, 23); this.btnUpdate.Text = "Update"; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Location = new System.Drawing.Point(310, 85); this.btnDelete.Size = new System.Drawing.Size(75, 23); this.btnDelete.Text = "Delete"; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.groupBox2.Controls.Add(this.label4); this.groupBox2.Controls.Add(this.txtSearch); this.groupBox2.Controls.Add(this.gridBorrower);
            this.groupBox2.Location = new System.Drawing.Point(20, 215); this.groupBox2.Size = new System.Drawing.Size(516, 340); this.groupBox2.Text = "Borrower Records";

            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(15, 25); this.label4.Text = "Search";
            this.txtSearch.Location = new System.Drawing.Point(70, 22); this.txtSearch.Size = new System.Drawing.Size(420, 22);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.gridBorrower.AllowUserToAddRows = false;
            this.gridBorrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBorrower.ColumnHeadersHeight = 29;
            this.gridBorrower.Location = new System.Drawing.Point(10, 55);
            this.gridBorrower.ReadOnly = true;
            this.gridBorrower.RowHeadersWidth = 51;
            this.gridBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBorrower.Size = new System.Drawing.Size(490, 270);
            this.gridBorrower.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBorrower_CellClick);

            this.ClientSize = new System.Drawing.Size(556, 587);
            this.Controls.Add(this.groupBox1); this.Controls.Add(this.groupBox2);
            this.Name = "Borrower"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            this.groupBox1.ResumeLayout(false); this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false); this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrower)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1, groupBox2;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.TextBox txtBorrowerID, txtName, txtContact, txtSearch;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnSave, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView gridBorrower;
    }
}
