using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmPhieuMuon : Form
    {
        string strConn = @"Data Source=DESKTOP-4J073UK;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(); // khoi tao mot doi tuong ket noi
        int chon;
        

        public frmPhieuMuon()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            DataLoadPhieuMuon();
            this.loadDBComboboxMaDocGia();
            btnLuu.Enabled = false;
            txtPhieuMuon.Enabled = false;
        }
        public void DataLoadPhieuMuon()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from PhieuMuon ",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhieuMuon.DataSource = dt;

            
        }
        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuMuon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void dgvPhieuMuon_Click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0){
                txtPhieuMuon.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["MaPM"].Value);
                cboDG.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["MaDG"].Value);
                dtNgayMuon.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["NgayMuon"].Value);
                dtNgayHen.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["NgayHenTra"].Value);
            }
        }
        public void loadDBComboboxMaDocGia() {
            //conn.Open();
            SqlCommand cmd = new SqlCommand("select MaDG from PhieuMuon",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboDG.DataSource = ds.Tables[0];
            cboDG.ValueMember = "MaDG";
            
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            chon = 1;
            int count1 = 0;
            count1 = dgvPhieuMuon.Rows.Count; //d?m t?t c? các dòng trong datagridview r?i gán cho count
            string c1 = "";
            int c2 = 0;
            c1 = Convert.ToString(dgvPhieuMuon.Rows[count1 - 2].Cells[1].Value);
            c2 = Convert.ToInt32((c1.Remove(0,4)));//lo?i b? kí t? TG
            if (c2 + 1 < 10)
            {
                 txtPhieuMuon.Text = "PM110" + (c2 + 1).ToString();
            }
            else if (c2 + 1 < 100)
            {
                txtPhieuMuon.Text = "PM11" + (c2 + 1).ToString();
            }
            MessageBox.Show(txtPhieuMuon.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            chon = 2;
            //

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chon = 3;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            

            switch(chon){
                case 1:{

                    SqlCommand cmd = new SqlCommand("Sp_AddPhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                    cmd.Parameters.Add(p);

                    p = new SqlParameter("@MaDG", cboDG.Text);
                    cmd.Parameters.Add(p);

                    p = new SqlParameter(@"NgayMuon", dtNgayMuon.Text);
                    cmd.Parameters.Add(p);

                    p = new SqlParameter(@"NgayHenTra", dtNgayHen.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count >= 1)
                    {
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới");
                    }
                    DataLoadPhieuMuon();
                    break;
                }
                case 2:{
                    SqlCommand cmd = new SqlCommand("Sp_UpdatePhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                    cmd.Parameters.Add(p);

                    p = new SqlParameter("@MaDG", cboDG.Text);
                    cmd.Parameters.Add(p);

                    p = new SqlParameter(@"NgayMuon", dtNgayMuon.Text);
                    cmd.Parameters.Add(p);

                    p = new SqlParameter(@"NgayHenTra", dtNgayHen.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count >= 1)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa được");
                    }
                    DataLoadPhieuMuon();
                    break;
                }
                case 3: {
                    SqlCommand cmd = new SqlCommand("Sp_DeletePhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                    cmd.Parameters.Add(p);

                    int count = cmd.ExecuteNonQuery();
                    if (count >= 1)
                    {
                        MessageBox.Show("Xóa thành công ");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được ");
                    }
                    DataLoadPhieuMuon();
                    break;
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            txtPhieuMuon.Text = "";
            cboDG.Text = "";
            dtNgayMuon.Text = "";
            dtNgayHen.Text = "";
        }

        private void dgvPhieuMuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuMuon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();            
            SqlDataAdapter da = new SqlDataAdapter("select * from PhieuMuon where MaDG like '" + "%" + txtTimKiem.Text + "%'",conn);
            da.Fill(dt);
            dgvPhieuMuon.DataSource = dt;
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
