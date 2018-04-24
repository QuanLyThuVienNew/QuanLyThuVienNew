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
using QuanLyThuVien;

namespace QLTV
{
    public partial class frmCTMuonTra : Form
    {
        string strConn = @"Data Source=DESKTOP-4J073UK;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        int chon;
        public frmCTMuonTra()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            //LoadCTMuonTra();
            //DataLoadPhieuMuon();
            DataLoadPhieuMuon2();
            btnLuu.Enabled = false;
            loadDBCombobox();
            loadDBComboboxMaDocGia();
            txtPhieuMuon.Enabled = false;
            txtMaPM.Enabled = false;
        }
        //private void LoadCTMuonTra()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("select * from CTMuonTra",conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;

        //}

        //public void DataLoadPhieuMuon()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("Select * from PhieuMuon ", conn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvPhieuMuon.DataSource = dt;


        //}

        public void DataLoadPhieuMuon2()
        {
            SqlDataAdapter da = new SqlDataAdapter("select pm.MaPM,MaDG,NgayMuon,NgayHenTra,MaSach,TrangThai,NgayTra,GhiChu from PhieuMuon pm inner join CTMuonTra ctmt on pm.MaPM = ctmt.MaPM", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            //SqlDataAdapter da1 = new SqlDataAdapter("Select * from PhieuMuon ", conn);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //dataGridView2.DataSource = dt1;


        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        txtMaPM.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaPM"].Value);
        //        cboMaSach.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaSach"].Value);
        //        dtNgayTra.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NgayTra"].Value);
        //        txtTrangThai.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TrangThai"].Value);
        //        rtbGHICHU.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GhiChu"].Value);
        //    }
        //}
        public void loadDBCombobox()
        {
           

            SqlCommand cmd1 = new SqlCommand("select MaSach from Sach", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cboMaSach.DataSource = ds1.Tables[0];
            cboMaSach.ValueMember = "MaSach";
        }
        public void loadDBComboboxMaDocGia()
        {
            //conn.Open();
            SqlCommand cmd = new SqlCommand("select MaDG from PhieuMuon", conn);
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
            count1 = dataGridView2.Rows.Count; //d?m t?t c? các dòng trong datagridview r?i gán cho count
            string c1 = "";
            int c2 = 0;
            c1 = Convert.ToString(dataGridView2.Rows[count1 - 2].Cells[1].Value);
            c2 = Convert.ToInt32((c1.Remove(0, 4)));//lo?i b? kí t? TG
            if (c2 + 1 < 10)
            {
                txtPhieuMuon.Text = "PM110" + (c2 + 1).ToString();
                txtMaPM.Text = "PM110" + (c2 + 1).ToString();
            }
            else if (c2 + 1 < 100)
            {
                txtPhieuMuon.Text = "PM11" + (c2 + 1).ToString();
                txtMaPM.Text = "PM11" + (c2 + 1).ToString();
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            chon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch(chon){
                case 1:
                    {
                        
                        SqlCommand cmd1 = new SqlCommand("Sp_AddPhieuMuon", conn);
                        cmd1.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                        cmd1.Parameters.Add(p1);

                        p1 = new SqlParameter("@MaDG", cboDG.Text);
                        cmd1.Parameters.Add(p1);

                        p1 = new SqlParameter(@"NgayMuon", dtNgayMuon.Text);
                        cmd1.Parameters.Add(p1);

                        p1 = new SqlParameter(@"NgayHenTra", dtNgayHen.Text);
                        cmd1.Parameters.Add(p1);
                        int count1 = cmd1.ExecuteNonQuery();
                        if (count1 >= 1)
                        {
                            MessageBox.Show("Thêm phiếu mới thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm phiếu mới");
                        }


                        SqlCommand cmd = new SqlCommand("Sp_AddCTMuonTra", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaPM", txtMaPM.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@MaSach", cboMaSach.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@NgayTra", dtNgayTra.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@TrangThai", txtTrangThai.Text);
                        cmd.Parameters.Add(p);

                        DateTime ngayhen = dtNgayHen.Value;
                        DateTime ngaytra = dtNgayTra.Value;
                        if(ngayhen < ngaytra){
                            MessageBox.Show("aaaaaaaaaaaaaa");
                            rtbGHICHU.Text = "Trả muộn";
                        }

                        p = new SqlParameter("@GhiChu", rtbGHICHU.Text);
                        cmd.Parameters.Add(p);
                        int count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                        {
                            MessageBox.Show("Thêm mới chi tiết mượn trả thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm  chi tiết mượn trả mới");
                        }
                        DataLoadPhieuMuon2();
                        //DataLoadPhieuMuon();
                        //LoadCTMuonTra();
                        break;
                    }
                case 2:
                    {
                        SqlCommand cmd1 = new SqlCommand("Sp_UpdatePhieuMuon", conn);
                        cmd1.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                        cmd1.Parameters.Add(p1);

                        p1 = new SqlParameter("@MaDG", cboDG.Text);
                        cmd1.Parameters.Add(p1);

                        p1 = new SqlParameter(@"NgayMuon", dtNgayMuon.Text);
                        cmd1.Parameters.Add(p1);

                        p1 = new SqlParameter(@"NgayHenTra", dtNgayHen.Text);
                        cmd1.Parameters.Add(p1);
                        int count1 = cmd1.ExecuteNonQuery();
                        if (count1 >= 1)
                        {
                            MessageBox.Show("Sửa thành phiếu mượn công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa phiếu mượn được");
                        }
                       


                        SqlCommand cmd = new SqlCommand("Sp_UpdateCTMuonTra", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaPM", txtMaPM.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@MaSach", cboMaSach.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@NgayTra", dtNgayTra.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@TrangThai", txtTrangThai.Text);
                        cmd.Parameters.Add(p);
                        DateTime ngayhen = dtNgayHen.Value;
                        DateTime ngaytra = dtNgayTra.Value;
                        if (ngayhen < ngaytra)
                        {
                            MessageBox.Show("aaaaaaaaaaaaaa");
                            rtbGHICHU.Text = "Trả muộn";
                        }
                        p = new SqlParameter("@GhiChu", rtbGHICHU.Text);
                        cmd.Parameters.Add(p);
                        int count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                        {
                            MessageBox.Show("Sửa chi tiết phiếu mượn thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa chi tiết phiếu mượn được");
                        }
                        //DataLoadPhieuMuon();
                        //LoadCTMuonTra();
                        DataLoadPhieuMuon2();
                        break;
                    }
                case 3:
                    {
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

                        //SqlCommand cmd1 = new SqlCommand("Sp_DeleteCTMuonTra", conn);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p1 = new SqlParameter("@MaPM", txtMaPM.Text);
                        //cmd.Parameters.Add(p1);
                        //int count1 = cmd1.ExecuteNonQuery();
                        //if (count1 >= 1)
                        //{
                        //    MessageBox.Show("Xoá thành công");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Không thể xoá được");
                        //}
                        //LoadCTMuonTra();
                        DataLoadPhieuMuon2();
                        break;
                    }
                    
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"> Phiếu mượn </param>
        /// <param name="e"></param>
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select pm.MaPM,MaDG,NgayMuon,NgayHenTra,MaSach,TrangThai,NgayTra,GhiChu from PhieuMuon pm inner join CTMuonTra ctmt on pm.MaPM = ctmt.MaPM where pm.MaPM like '" + "%" + txtTimKiem.Text + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void dgvPhieuMuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dgvPhieuMuon.Rows[e.RowIndex].Cells["stt1"].Value = e.RowIndex + 1;
        }

       

        //private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        txtPhieuMuon.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["MaPM1"].Value);
        //        cboDG.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["MaDG"].Value);
        //        dtNgayMuon.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["NgayMuon"].Value);
        //        dtNgayHen.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["NgayHenTra"].Value);
        //    }
        //}

        

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtPhieuMuon.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MaPM"].Value);
                cboDG.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MaDG"].Value);
                dtNgayMuon.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["NgayMuon"].Value);
                dtNgayHen.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["NgayHenTra"].Value);
                txtMaPM.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MaPM"].Value);
                cboMaSach.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MaSach"].Value);
                dtNgayTra.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["NgayTra"].Value);
                txtTrangThai.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["TrangThai"].Value);
                rtbGHICHU.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["GhiChu"].Value);
            }
        }

        private void frmCTMuonTra_Load(object sender, EventArgs e)
        {

        }
        //int chon1;
        //private void btnThem1_Click(object sender, EventArgs e)
        //{
        //    btnThem1.Enabled = false;
        //    btnSua1.Enabled = false;
        //    btnXoa1.Enabled = false;
        //    btnLuu1.Enabled = true;
        //    chon1 = 1;
        //    int count1 = 0;
        //    count1 = dgvPhieuMuon1.Rows.Count; //d?m t?t c? các dòng trong datagridview r?i gán cho count
        //    string c1 = "";
        //    int c2 = 0;
        //    c1 = Convert.ToString(dgvPhieuMuon1.Rows[count1 - 2].Cells[1].Value);
        //    c2 = Convert.ToInt32((c1.Remove(0, 4)));//lo?i b? kí t? TG
        //    if (c2 + 1 < 10)
        //    {
        //        txtPhieuMuon.Text = "TG110" + (c2 + 1).ToString();
        //    }
        //    else if (c2 + 1 < 100)
        //    {
        //        txtPhieuMuon.Text = "TG11" + (c2 + 1).ToString();
        //    }
        //    MessageBox.Show(txtPhieuMuon.Text);
        //}

        //private void btnSua1_Click(object sender, EventArgs e)
        //{
        //    btnThem1.Enabled = false;
        //    btnSua1.Enabled = false;
        //    btnXoa1.Enabled = false;
        //    btnLuu1.Enabled = true;
        //    chon1 = 2;
        //}

        //private void btnXoa1_Click(object sender, EventArgs e)
        //{
        //    btnThem1.Enabled = false;
        //    btnSua1.Enabled = false;
        //    btnXoa1.Enabled = false;
        //    btnLuu1.Enabled = true;
        //    chon1 = 3;
        //}

        //private void btnLuu1_Click(object sender, EventArgs e)
        //{
        //    switch(chon1){
        //        case 1:{

        //            SqlCommand cmd = new SqlCommand("Sp_AddPhieuMuon", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
        //            cmd.Parameters.Add(p);

        //            p = new SqlParameter("@MaDG", cboDG.Text);
        //            cmd.Parameters.Add(p);

        //            p = new SqlParameter(@"NgayMuon", dtNgayMuon.Text);
        //            cmd.Parameters.Add(p);

        //            p = new SqlParameter(@"NgayHenTra", dtNgayHen.Text);
        //            cmd.Parameters.Add(p);
        //            int count = cmd.ExecuteNonQuery();
        //            if (count >= 1)
        //            {
        //                MessageBox.Show("Thêm phiếu mới thành công");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không thể thêm phiếu mới");
        //            }
        //            DataLoadPhieuMuon();
        //            break;
        //        }
        //        case 2:{
        //            SqlCommand cmd = new SqlCommand("Sp_UpdatePhieuMuon", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
        //            cmd.Parameters.Add(p);

        //            p = new SqlParameter("@MaDG", cboDG.Text);
        //            cmd.Parameters.Add(p);

        //            p = new SqlParameter(@"NgayMuon", dtNgayMuon.Text);
        //            cmd.Parameters.Add(p);

        //            p = new SqlParameter(@"NgayHenTra", dtNgayHen.Text);
        //            cmd.Parameters.Add(p);
        //            int count = cmd.ExecuteNonQuery();
        //            if (count >= 1)
        //            {
        //                MessageBox.Show("Sửa thành công");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không thể sửa được");
        //            }
        //            DataLoadPhieuMuon();
        //            break;
        //        }
        //        case 3: {
        //            SqlCommand cmd = new SqlCommand("Sp_DeletePhieuMuon", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
        //            cmd.Parameters.Add(p);

        //            int count = cmd.ExecuteNonQuery();
        //            if (count >= 1)
        //            {
        //                MessageBox.Show("Xóa thành công ");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không xóa được ");
        //            }
        //            DataLoadPhieuMuon();
        //            break;
        //        }
        //    }
        //    btnThem1.Enabled = true;
        //    btnSua1.Enabled = true;
        //    btnXoa1.Enabled = true;
        //    btnLuu1.Enabled = false;

        //    txtPhieuMuon.Text = "";
        //    cboDG.Text = "";
        //    dtNgayMuon.Text = "";
        //    dtNgayHen.Text = "";
        
        //}

        //private void dgvPhieuMuon1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        txtPhieuMuon.Text = Convert.ToString(dgvPhieuMuon1.CurrentRow.Cells["MaPM"].Value);
        //        cboDG.Text = Convert.ToString(dgvPhieuMuon1.CurrentRow.Cells["MaDG"].Value);
        //        dtNgayMuon.Text = Convert.ToString(dgvPhieuMuon1.CurrentRow.Cells["NgayMuon"].Value);
        //        dtNgayHen.Text = Convert.ToString(dgvPhieuMuon1.CurrentRow.Cells["NgayHenTra"].Value);
        //    }
        //}
    }
}
