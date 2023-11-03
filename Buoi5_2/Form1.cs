using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_2
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        String[] listKhoa = { "Công nghệ thông tin", "Kế toán", "Ngoại ngữ", "Điện tử" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listKhoa;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if(!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã SV phải 10 ký tự!");
                }
                if (this.checkMaSV(txtMaSV.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã tồn tại!");
                }
                if(txtHoTen.Text.Length.Equals(0)) 
                {
                    throw new Exception("Họ tên không được đẻ trống!");
                }
                if(!double.TryParse(txtDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm không hợp lệ!");
                }

                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["Diem"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        public bool checkMaSV(string masv)
        {
            if(dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for(int row = 0;row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if(rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDiem.Text = dgvDanhSach.Rows[rowindex].Cells["Diem"].Value.ToString();
                string tenkhoa = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while (i < listKhoa.Length && listKhoa[i] != tenkhoa)
                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;
            }
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if(rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                if (!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã SV phải 10 ký tự!");
                }
                if (this.checkMaSV(txtMaSV.Text) ==  false && txtMaSV.Text != dgvDanhSach.Rows[rowindex].Cells["MaSV"].ToString())
                {
                    throw new Exception("Mã SV đã tồn tại!");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Chưa nhập họ tên!");
                }
                if (!double.TryParse(txtDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm không hợp lệ!");
                }

                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;

                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["Diem"].Value = diemtb;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;

                rowindex = -1;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
                rowindex = -1;
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
