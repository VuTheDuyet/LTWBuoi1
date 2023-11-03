using Buoi7_1.dao;
using KiemTra2.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_1.frm
{
    public partial class frmSinhVien : Form
    {
        private SinhVienDAO sinhVienDAO = new SinhVienDAO();
        private KhoaDAO khoaDAO = new KhoaDAO();
        int rowindex = -1;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            List<Khoa> khoas = khoaDAO.GetAllKhoa();
            cbKhoa.DataSource = khoas;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";

            LoadDataToDGV();
        }
        private void LoadDataToDGV()
        {
            try
            {
                List<SinhVien> sinhViens = sinhVienDAO.GetAllSinhVien();
                dgvDanhSach.DataSource = sinhViens;
                dgvDanhSach.Columns["Khoa"].Visible = false;

                // Tạo một cột mới cho tên khoa
                if (!dgvDanhSach.Columns.Contains("TenKhoaColumn"))
                {
                    DataGridViewComboBoxColumn tenKhoaColumn = new DataGridViewComboBoxColumn();
                    tenKhoaColumn.Name = "TenKhoaColumn";
                    tenKhoaColumn.HeaderText = "Khoa";
                    tenKhoaColumn.DataSource = khoaDAO.GetAllKhoa();
                    tenKhoaColumn.DisplayMember = "TenKhoa";
                    tenKhoaColumn.ValueMember = "MaKhoa";
                    tenKhoaColumn.DataPropertyName = "MaKhoa";
                    dgvDanhSach.Columns.Add(tenKhoaColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        public bool checkMaSV(string masv)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }
                if (!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã SV phải 10 ký tự!");
                }
                if (this.checkMaSV(txtMaSV.Text) == false && txtMaSV.Text != dgvDanhSach.Rows[rowindex].Cells["MaSV"].ToString())
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

                SinhVien sinhVien = sinhVienDAO.GetSinhVienByMaSV(txtMaSV.Text);
                if (sinhVien == null)
                {
                    throw new Exception("Sinh viên không tồn tại!");
                }

                sinhVien.HoTen = txtHoTen.Text;
                sinhVien.DiemTB = diemtb;
                sinhVien.MaKhoa = (int)cbKhoa.SelectedValue;

                sinhVienDAO.UpdateSinhVien(sinhVien);
                LoadDataToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSV.Text))
                {
                    throw new Exception("Chưa chọn sinh viên!");
                }

                sinhVienDAO.DeleteSinhVien(txtMaSV.Text);
                LoadDataToDGV();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã SV phải 10 ký tự!");
                }
                if (this.checkMaSV(txtMaSV.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã tồn tại!");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được đẻ trống!");
                }
                if (!double.TryParse(txtDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm không hợp lệ!");
                }

                SinhVien sinhVien = new SinhVien
                {
                    MaSV = txtMaSV.Text,
                    HoTen = txtHoTen.Text,
                    DiemTB = diemtb,
                    MaKhoa = (int)cbKhoa.SelectedValue
                };

                sinhVienDAO.AddSinhVien(sinhVien);
                LoadDataToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {

                SinhVien selectedSinhVien = (SinhVien)dgvDanhSach.Rows[rowindex].DataBoundItem;

                txtMaSV.Text = selectedSinhVien.MaSV;
                txtHoTen.Text = selectedSinhVien.HoTen;
                txtDiem.Text = selectedSinhVien.DiemTB.ToString();

                cbKhoa.SelectedValue = selectedSinhVien.MaKhoa;
            }

            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
