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
    public partial class frmKhoa : Form
    {
        private KhoaDAO khoaDAO = new KhoaDAO();
        private int rowindex = -1;
        public frmKhoa()
        {
            InitializeComponent();
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadDataToDGV();
        }
        private void LoadDataToDGV()
        {
            try
            {
                List<Khoa> khoas = khoaDAO.GetAllKhoa();
                dgvDanhSach.DataSource = khoas;
                dgvDanhSach.Columns["SinhViens"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKhoa.Text))
                {
                    throw new Exception("Chưa nhập mã khoa!");
                }
                if (string.IsNullOrEmpty(txtTenKhoa.Text))
                {
                    throw new Exception("Chưa nhập tên khoa!");
                }

                Khoa khoa = new Khoa
                {
                    MaKhoa = int.Parse(txtMaKhoa.Text),
                    TenKhoa = txtTenKhoa.Text,
                    GhiChu = txtGhiChu.Text
                };

                khoaDAO.AddKhoa(khoa);
                LoadDataToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count)
                {
                    throw new Exception("Chưa chọn khoa!");
                }
                if (string.IsNullOrEmpty(txtMaKhoa.Text))
                {
                    throw new Exception("Chưa nhập mã khoa!");
                }
                if (string.IsNullOrEmpty(txtTenKhoa.Text))
                {
                    throw new Exception("Chưa nhập tên khoa!");
                }

                Khoa khoaUpdated = new Khoa
                {
                    MaKhoa = int.Parse(txtMaKhoa.Text),
                    TenKhoa = txtTenKhoa.Text,
                    GhiChu = txtGhiChu.Text
                };

                khoaDAO.UpdateKhoa(khoaUpdated);
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
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count)
                {
                    throw new Exception("Chưa chọn khoa!");
                }

                int maKhoa = int.Parse(dgvDanhSach.Rows[rowindex].Cells["MaKhoa"].Value.ToString());
                khoaDAO.DeleteKhoa(maKhoa);
                LoadDataToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
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

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {

                Khoa selectedKhoa = (Khoa)dgvDanhSach.Rows[rowindex].DataBoundItem;

                txtMaKhoa.Text = selectedKhoa.MaKhoa.ToString();
                txtTenKhoa.Text = selectedKhoa.TenKhoa;
                txtGhiChu.Text = selectedKhoa.GhiChu;

            }

            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
