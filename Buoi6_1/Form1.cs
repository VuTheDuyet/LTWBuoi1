using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_1
{
    public partial class Form1 : Form
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO khDAO = new KhoaDAO();
        //Khai báo cờ hiệu thêm và cập nhật
        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSinhVien.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSinhVien();
        }
        private void loadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDAO.getList();
        }
        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khDAO.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        private void TongSinhVien()
        {
            txtTongSinhVien.Text = svDAO.getCount().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSinhVien.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSinhVien.Enabled = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex == -1 || rowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }

                txtMaSinhVien.Text = dgvDanhSach.Rows[rowIndex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowIndex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowIndex].Cells["TenKhoa"].Value.ToString();
                txtDiem.Text = dgvDanhSach.Rows[rowIndex].Cells["DiemTB"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;

                if (txtMaSinhVien.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên 10 ký tự số");
                }

                if (!double.TryParse(txtDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm sinh viên số");
                }

                string masv = txtMaSinhVien.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());

                SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb);

                switch (insertupdate)
                {
                    case "insert":
                        svDAO.InsertTwo(sv);
                        loadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        break;

                    case "update":
                        svDAO.UpdateTwo(sv);
                        loadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSinhVien.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không đúng");
                }

                string masv = txtMaSinhVien.Text;
                svDAO.DeleteTwo(masv);
                loadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDanhSach.DataSource = svDAO.getList(makhoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
