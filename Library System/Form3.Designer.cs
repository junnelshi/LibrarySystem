namespace LibrarySystem
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(80, 27);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(200, 22);
            this.txtBookID.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(80, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(80, 87);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(310, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(310, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(400, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.grid1);
            this.groupBox2.Location = new System.Drawing.Point(20, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Records";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(70, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.ColumnHeadersHeight = 29;
            this.grid1.Location = new System.Drawing.Point(10, 55);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.RowHeadersWidth = 51;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid1.Size = new System.Drawing.Size(490, 270);
            this.grid1.TabIndex = 2;
            this.grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellClick);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(556, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.TextBox txtBookID, txtTitle, txtAuthor, txtSearch;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnSave, btnUpdate, btnDelete;
        private System.Windows.Forms.DataGridView grid1;
    }
}