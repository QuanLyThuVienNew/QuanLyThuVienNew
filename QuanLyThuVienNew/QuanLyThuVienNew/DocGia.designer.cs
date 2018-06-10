namespace TUNG
{
    partial class DocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TenDG = new System.Windows.Forms.TextBox();
            this.MaDG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNo,
            this.clMa,
            this.clTen,
            this.clNS,
            this.clAdd,
            this.clSDT});
            this.dataGridView1.Location = new System.Drawing.Point(0, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 181);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // clNo
            // 
            this.clNo.HeaderText = "STT";
            this.clNo.Name = "clNo";
            this.clNo.Width = 40;
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "MaDG";
            this.clMa.HeaderText = "Mã độc giả";
            this.clMa.Name = "clMa";
            // 
            // clTen
            // 
            this.clTen.DataPropertyName = "TenDG";
            this.clTen.HeaderText = "Tên độc giả";
            this.clTen.Name = "clTen";
            this.clTen.Width = 200;
            // 
            // clNS
            // 
            this.clNS.DataPropertyName = "NgaySinh";
            this.clNS.HeaderText = "Ngày sinh";
            this.clNS.Name = "clNS";
            // 
            // clAdd
            // 
            this.clAdd.DataPropertyName = "DiaChi";
            this.clAdd.HeaderText = "Địa chỉ";
            this.clAdd.Name = "clAdd";
            this.clAdd.Width = 150;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "SDT";
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SDT
            // 
            this.SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.Location = new System.Drawing.Point(473, 138);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(190, 26);
            this.SDT.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "SĐT";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(473, 101);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(190, 26);
            this.Address.TabIndex = 36;
            // 
            // ngaySinh
            // 
            this.ngaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaySinh.Location = new System.Drawing.Point(473, 63);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(190, 26);
            this.ngaySinh.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày sinh";
            // 
            // TenDG
            // 
            this.TenDG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDG.Location = new System.Drawing.Point(127, 138);
            this.TenDG.Name = "TenDG";
            this.TenDG.Size = new System.Drawing.Size(171, 26);
            this.TenDG.TabIndex = 29;
            // 
            // MaDG
            // 
            this.MaDG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDG.Location = new System.Drawing.Point(127, 63);
            this.MaDG.Name = "MaDG";
            this.MaDG.Size = new System.Drawing.Size(171, 26);
            this.MaDG.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã độc giả";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(251, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 36);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Lưu";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(594, 190);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 36);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(423, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 36);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(69, 190);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(82, 36);
            this.buttonThem.TabIndex = 22;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản lý độc giả";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(473, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(190, 26);
            this.Search.TabIndex = 39;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tìm kiếm";
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ngaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TenDG);
            this.Controls.Add(this.MaDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DocGia";
            this.RightToLeftLayout = true;
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.DateTimePicker ngaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TenDG;
        private System.Windows.Forms.TextBox MaDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;



    }
}