using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_1
{
    public partial class Form1 : Form
    {
        string[] danhSachKhoa = { "CNTT", "QTKD", "Kế Toán", "Ngoại ngữ" };
        int rowchose = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự!");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Họ tên ít nhất 2 ký tự!");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                //Đưa dữ liệu vào lưới
                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                rowchose = e.RowIndex;
                txtMaSV.Text = dgvDanhSach.Rows[rowchose].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowchose].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[rowchose].Cells["NgaySinh"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowchose].Cells["Khoa"].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            loadKhoa();
        }
        private void loadKhoa()
        {
            cbKhoa.DataSource = danhSachKhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchose == -1 || rowchose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã dinh viên phải đúng 10 Ký tự!");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Họ tên ít nhất 2 ký tự!");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                dgvDanhSach.Rows[rowchose].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowchose].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowchose].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowchose].Cells["Khoa"].Value = khoa;

                rowchose = -1;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                if (rowchose == -1 || rowchose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                dgvDanhSach.Rows.RemoveAt(rowchose);
                rowchose = -1;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không!",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
