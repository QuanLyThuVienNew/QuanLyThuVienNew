namespace Library1
{
    partial class Sach
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NamXuatBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.cbMaDS = new System.Windows.Forms.ComboBox();
            this.cbMaKS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 245);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMa,
            this.clMDS,
            this.clMKS,
            this.clNamXB});
            this.dataGridView1.Location = new System.Drawing.Point(0, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 189);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 80;
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "MaSach";
            this.clMa.HeaderText = "MaSach";
            this.clMa.Name = "clMa";
            this.clMa.Width = 150;
            // 
            // clMDS
            // 
            this.clMDS.DataPropertyName = "MaDS";
            this.clMDS.HeaderText = "MaDS";
            this.clMDS.Name = "clMDS";
            this.clMDS.Width = 150;
            // 
            // clMKS
            // 
            this.clMKS.DataPropertyName = "MaKS";
            this.clMKS.HeaderText = "MaKS";
            this.clMKS.Name = "clMKS";
            this.clMKS.Width = 150;
            // 
            // clNamXB
            // 
            this.clNamXB.DataPropertyName = "NamXuatBan";
            this.clNamXB.HeaderText = "NamXuatBan";
            this.clNamXB.Name = "clNamXB";
            this.clNamXB.Width = 165;
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(12, 9);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(85, 40);
            this.Ten.TabIndex = 3;
            this.Ten.Text = "Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sách";
            // 
            // MaSach
            // 
            this.MaSach.Location = new System.Drawing.Point(119, 68);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(171, 20);
            this.MaSach.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Đầu Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Kệ Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Năm Xuất Bản";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.Location = new System.Drawing.Point(507, 103);
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.Size = new System.Drawing.Size(171, 20);
            this.NamXuatBan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tìm theo năm XB:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(507, 140);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 20);
            this.Search.TabIndex = 18;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(510, 183);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(89, 42);
            this.buttonXoa.TabIndex = 22;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(359, 183);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 42);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(196, 183);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(98, 42);
            this.buttonADD.TabIndex = 20;
            this.buttonADD.Text = "Lưu";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(54, 183);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(99, 42);
            this.buttonThem.TabIndex = 19;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // cbMaDS
            // 
            this.cbMaDS.FormattingEnabled = true;
            this.cbMaDS.Items.AddRange(new object[] {
            "DS1101",
            "DS1102",
            "DS1103",
            "DS1104",
            "DS1105",
            "DS1106",
            "DS1107",
            "DS1108",
            "DS1109",
            "DS1110"});
            this.cbMaDS.Location = new System.Drawing.Point(119, 103);
            this.cbMaDS.Name = "cbMaDS";
            this.cbMaDS.Size = new System.Drawing.Size(171, 21);
            this.cbMaDS.TabIndex = 23;
            this.cbMaDS.Text = "DS1101";
            // 
            // cbMaKS
            // 
            this.cbMaKS.FormattingEnabled = true;
            this.cbMaKS.Items.AddRange(new object[] {
            "KS1101",
            "KS1102",
            "KS1103",
            "KS1104",
            "KS1105",
            "KS1106",
            "KS1107",
            "KS1108",
            "KS1109",
            "KS1110"});
            this.cbMaKS.Location = new System.Drawing.Point(507, 68);
            this.cbMaKS.Name = "cbMaKS";
            this.cbMaKS.Size = new System.Drawing.Size(171, 21);
            this.cbMaKS.TabIndex = 24;
            this.cbMaKS.Text = "KS1101";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 428);
            this.Controls.Add(this.cbMaKS);
            this.Controls.Add(this.cbMaDS);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NamXuatBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sach";
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.Sach_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamXB;
        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NamXuatBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox cbMaDS;
        private System.Windows.Forms.ComboBox cbMaKS;
    }
}

