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
    public partial class QLTGForm : Form
    {
        public QLTGForm()
        {
            InitializeComponent();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string strConn = @"Data Source=NGOCXINH\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn1;
        public void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from TacGia", conn1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void QLTGForm_Load(object sender, EventArgs e)
        {
            conn1 = new SqlConnection(strConn);
            conn1.Open();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaTG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clMaTG"].Value);
                txtTenTG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clTenTG"].Value);
                txtGhiChu.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clGhiChu"].Value);
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMaTG.Enabled = false;
            bntLuu.Enabled = true;
            txtTenTG.Text = "";
            txtGhiChu.Text = "";
            txtTenTG.Focus();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SuaTG", conn1);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaTG", txtMaTG.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@TenTG", txtTenTG.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@GhiChu", txtGhiChu.Text);
            cmd.Parameters.Add(p);

            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                MessageBox.Show("?� s?a", "Th�ng tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Kh�ng th? s?a", "Nontification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("B?n c� ch?c mu?n x�a th�ng tin n�y ?", "Nontification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaTG", conn1);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTG", txtMaTG.Text);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("?� x�a", "Th�ng tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else MessageBox.Show("Kh�ng th? x�a", "Th�ng tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtGhiChu.Text = "";
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            //Sinh m� t? t?ng
            int count1 = 0;
            count1 = dataGridView1.Rows.Count; //??m t?t c? c�c d�ng trong datagridview r?i g�n cho count
            string c1 = "";
            int c2 = 0;
            c1 = Convert.ToString(dataGridView1.Rows[count1 - 2].Cells[1].Value);
            c2 = Convert.ToInt32((c1.Remove(0, 4)));//lo?i b? k� t? TG
            if (c2 + 1 < 10)
            {
                txtMaTG.Text = "TG110" + (c2 + 1).ToString();
            }
            else if (c2 + 1 < 100)
            {
                txtMaTG.Text = "TG11" + (c2 + 1).ToString();
            }
            //Ki?m tra d? li?u tr??c khi Th�m v�o DataGridview
            if (txtTenTG.Text.Trim() == "")
            {
                MessageBox.Show("Kh�ng ???c ?? tr?ng !", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = txtTenTG;
                return;
            }
            // Khai b�o v� kh?i t?o ??i t??ng Command, truy?n v�o t�n th? t?c t??ng ?ng
            SqlCommand cmd = new SqlCommand("ThemTG", conn1);
            // Khai b�o ki?u th?c thi l� Th?c thi th? t?c
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai b�o v� g�n gi� tr? cho c�c tham s? ??u v�o c?a th? t?c
            // Khai b�o tham s? th? nh?t @Name - l� t�n tham s? ???c t?o trong th? t?c
            SqlParameter p = new SqlParameter("@MaTG", txtMaTG.Text);
            cmd.Parameters.Add(p);
            // Kh?i t?o tham s? th? 2 trong th? t?c l� @Name
            p = new SqlParameter("@TenTG", txtTenTG.Text);
            cmd.Parameters.Add(p);
            // Kh?i t?o tham s? th? 3 trong th? t?c l� @Color
            p = new SqlParameter("@GhiChu", txtGhiChu.Text);
            cmd.Parameters.Add(p);
            // Th?c thi th? t?c
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("?� th�m", "Th�ng tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else { MessageBox.Show("kh�ng th? th�m", "Th�ng tin", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            bntLuu.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            conn1 = new SqlConnection(strConn);
            conn1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TacGia where TenTG like '" +"%"+ txtTimKiem.Text + "%'", conn1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn1.Close();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["clSTT"].Value = e.RowIndex + 1;
        }
    }
 }
