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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }
        string strConn = @"Data Source=DESKTOP-4J073UK;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sach", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            }

        private void Sach_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            MaSach.Enabled = false;
            cbMaDS.Text="DS1101";
            buttonADD.Enabled = true;

            cbMaKS.Text = "KS1101";
            NamXuatBan.Text = "";
            MaSach.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SuaSach" +
                "", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Ma", MaSach.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MDS", cbMaDS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MKS", cbMaKS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@NamXB", NamXuatBan.Text);
            cmd.Parameters.Add(p);

            

            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            else MessageBox.Show("Không sửa được!");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muôn xóa bản ghi đang chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;



                SqlParameter p = new SqlParameter("@Ma", MaSach.Text);
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

        private void buttonADD_Click(object sender, EventArgs e)
        {
            //sinh ma tu tang
            int count1 = 0;
            count1 = dataGridView1.Rows.Count;//dem cac dong trong datagridview roi gan cho count
            string c1 = "";
            int c2 = 0;
            c1 = Convert.ToString(dataGridView1.Rows[count1 - 2].Cells[1].Value);

            c2 = Convert.ToInt32(c1.Remove(0, 3));
            if (c2 + 1 < 10)
            {
                MaSach.Text = "S110" + (c2 + 1).ToString();
            }
            else if (c2 + 1 < 100)
            {
                MaSach.Text = "S11" + (c2 + 1).ToString();

            }

            SqlCommand cmd = new SqlCommand("ThemSach", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@Ma", MaSach.Text);
            cmd.Parameters.Add(p);


            p = new SqlParameter("@MDS", cbMaDS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MKS", cbMaKS.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@NamXB", NamXuatBan.Text);
            cmd.Parameters.Add(p);
            // Thực thi thủ tục
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Sach where NamXuatBan like '" + "%" + Search.Text + "%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["clSTT"].Value = e.RowIndex + 1;
        }


        private void Sach_Load_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                MaSach.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMa"].Value);
                cbMaDS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMDS"].Value);
                cbMaKS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMKS"].Value);
                NamXuatBan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clNamXB"].Value);

            }
        }
    }
   
}

