using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV;
using TUNG;
using Library1;

namespace QuanLyThuVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra các điều kiện trước khi đăng nhập
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtTen;
                return;
            }
            if (txtMk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtMk;
                return;
            }

            //Tên tài khoản và mật khẩu
            if (this.txtTen.Text.CompareTo("admin") == 0 && this.txtMk.Text.CompareTo("123456") == 0)
            {
                groupBox1.Visible = false;
                đăngNhậpToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = true;
                danhMụcQuảnLýToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không đúng. Hãy thử lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtTen.Focus();
            txtTen.Text = "";
            txtMk.Text = "";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                đăngNhậpToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = false;
                danhMụcQuảnLýToolStripMenuItem.Enabled = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                this.Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMk.PasswordChar = (char)0;
            }
            else
            {
                txtMk.PasswordChar = '●';
            }
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            txtTen.Text = "";
            txtMk.Text = "";
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTGForm tg = new QLTGForm();
            tg.Show();
        }

        private void quảnLýĐầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDS ds = new FormDS();
            ds.Show();   
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.Show();
        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuon pm = new frmPhieuMuon();
            pm.Show();
        }

        private void chiTiếtMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTMuonTra ct = new frmCTMuonTra();
            ct.Show();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NXB xb = new NXB();
            xb.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.Show();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeSach ks = new KeSach();
            ks.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
