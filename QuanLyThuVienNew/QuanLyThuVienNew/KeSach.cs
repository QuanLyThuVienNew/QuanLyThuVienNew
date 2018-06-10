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
namespace Library1
{
    public partial class KeSach : Form
    {
        public KeSach()
        {
            InitializeComponent();
        }
        string strConn = @"Data Source=CUONG;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KeSach", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SuaKeSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Ma", MaKS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@Ten", TenKS.Text);
            cmd.Parameters.Add(p);

           

            p = new SqlParameter("@ViTri",ViTri.Text);
            cmd.Parameters.Add(p);


            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            else MessageBox.Show("Không sửa được!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muôn xóa bản ghi đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaKeSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;



                SqlParameter p = new SqlParameter("@Ma", MaKS.Text);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["clSTT"].Value = e.RowIndex + 1;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            //sinh ma tu tang
            int count1 = 0;
            count1 = dataGridView1.Rows.Count;//dem cac dong trong datagridview roi gan cho count
            string c1 = "";
            int c2 = 0;
            c1 = Convert.ToString(dataGridView1.Rows[count1 - 2].Cells[1].Value);

            c2 = Convert.ToInt32(c1.Remove(0, 4));
            if (c2 + 1 < 10)
            {
                MaKS.Text = "KS110" + (c2 + 1).ToString();
            }
            else if (c2 + 1 < 100)
            {
                MaKS.Text = "KS11" + (c2 + 1).ToString();

            }

            SqlCommand cmd = new SqlCommand("ThemKeSach", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Ma", MaKS.Text);
            cmd.Parameters.Add(p);

          

            p = new SqlParameter("@Ten", TenKS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@ViTri", ViTri.Text);
            cmd.Parameters.Add(p);

            
            // Thực thi thủ tục
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            MaKS.Enabled = false;
            TenKS.Text = "";
            buttonADD.Enabled = true;

            ViTri.Text = "";
           
            MaKS.Focus();
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from KeSach where TenKS like '" + "%" + TimKiem.Text + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void KeSach_Load_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                MaKS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMa"].Value);
                TenKS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clTen"].Value);
                ViTri.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clVT"].Value);


            }
        }
    }
}
