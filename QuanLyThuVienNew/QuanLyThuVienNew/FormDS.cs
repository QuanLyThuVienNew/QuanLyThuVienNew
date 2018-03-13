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

namespace QuanLyThuVien
{
    public partial class FormDS : Form
    {
        public FormDS()
        {
            InitializeComponent();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string strConn = @"Data Source=CUONG;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn;
        public void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from DauSach", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaDS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMaDS"].Value);
                txtTenDS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clTenDS"].Value);
                cbbMaTG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMaTG"].Value);
                cbbMaNXB.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMaNXB"].Value);
                txtSoLuong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clSoLuong"].Value);
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMaDS.Enabled=false;
            bntLuu.Enabled = true;
            txtTenDS.Text = "";
            cbbMaTG.Text = "--Lựa chọn mã tác giả--";
            cbbMaNXB.Text = "--Lựa chọn mã nhà xuất bản--";
            txtSoLuong.Text = "";
            txtTenDS.Focus();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SuaDS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaDS", txtMaDS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@TenDS", txtTenDS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MaTG", cbbMaTG.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MaNXB", cbbMaNXB.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@SoLuong", txtSoLuong.Text);
            cmd.Parameters.Add(p);

            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                MessageBox.Show("Đã sửa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Không thể sửa", "Nontification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            //Sinh mã tự tăng
            int count1 = 0;
            count1 = dataGridView1.Rows.Count; //đếm tất cả các dòng trong datagridview rồi gán cho count
            string c1 = "";
            int c2 = 0;
            c1 = Convert.ToString(dataGridView1.Rows[count1 - 2].Cells[1].Value);
            c2 = Convert.ToInt32((c1.Remove(0, 4)));//loại bỏ kí tự TG
            if (c2 + 1 < 10)
            {
                txtMaDS.Text = "DS110" + (c2 + 1).ToString();
            }
            else if (c2 + 1 < 100)
            {
                txtMaDS.Text = "DS11" + (c2 + 1).ToString();
            }
            //Kiểm tra dữ liệu trước khi Thêm vào DataGridview
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtSoLuong;
                return;
            }
            if(cbbMaTG.Text.Trim()=="--Lựa chọn mã tác giả--")
            {
                MessageBox.Show("Bạn chưa lựa chọn mã tác giả !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = cbbMaTG;
                return;
            }
            if (cbbMaNXB.Text.Trim() == "--Lựa chọn mã nhà xuất bản--")
            {
                MessageBox.Show("Bạn chưa lựa chọn mã nhà xuất bản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = cbbMaNXB;
                return;
            }
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("ThemDS", conn);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo và gán giá trị cho các tham số đầu vào của thủ tục
            SqlParameter p = new SqlParameter("@MaDS", txtMaDS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@TenDS", txtTenDS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MaTG", cbbMaTG.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MaNXB", cbbMaNXB.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@SoLuong", txtSoLuong.Text);
            cmd.Parameters.Add(p);
            // Thực thi thủ tục
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Đã thêm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else { MessageBox.Show("không thể thêm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            bntLuu.Enabled = false;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin này ?", "Nontification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaDS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaDS", txtMaDS.Text);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Đã xóa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else MessageBox.Show("Không thể xóa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtMaDS.Text = "";
            txtTenDS.Text = "";
            cbbMaTG.Text = "--Lựa chọn mã tác giả--";
            cbbMaNXB.Text = "--Lựa chọn mã nhà xuất bản--";
            txtSoLuong.Text = "";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from DauSach where TenDS like '"+"%" + txtTim.Text + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["clSTT"].Value = e.RowIndex + 1;
        }

        private void FormDS_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }
    }
}
