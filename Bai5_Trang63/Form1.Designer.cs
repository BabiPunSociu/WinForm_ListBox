namespace Bai5_Trang63
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenNgoaiNgu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstKetQua = new System.Windows.Forms.ListBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(40, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập tên ngoại ngữ:";
			// 
			// txtTenNgoaiNgu
			// 
			this.txtTenNgoaiNgu.Location = new System.Drawing.Point(262, 37);
			this.txtTenNgoaiNgu.Name = "txtTenNgoaiNgu";
			this.txtTenNgoaiNgu.Size = new System.Drawing.Size(508, 22);
			this.txtTenNgoaiNgu.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(40, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(263, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Danh sách các ngoại ngữ:";
			// 
			// lstKetQua
			// 
			this.lstKetQua.FormattingEnabled = true;
			this.lstKetQua.ItemHeight = 16;
			this.lstKetQua.Location = new System.Drawing.Point(48, 129);
			this.lstKetQua.Name = "lstKetQua";
			this.lstKetQua.Size = new System.Drawing.Size(721, 244);
			this.lstKetQua.TabIndex = 3;
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(46, 403);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(125, 28);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.Text = "&Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			this.btnAddNew.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnAddNew.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(208, 403);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(119, 28);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			this.btnRemove.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnRemove.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(371, 403);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(99, 28);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnSearch.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnSearch.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(623, 403);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(147, 28);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "&Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnExit.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnExit.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(498, 403);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(99, 28);
			this.btnSort.TabIndex = 8;
			this.btnSort.Text = "&Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			this.btnSort.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnSort.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.lstKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenNgoaiNgu);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chương trình ListBox";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNgoaiNgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKetQua;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSort;
    }
}

