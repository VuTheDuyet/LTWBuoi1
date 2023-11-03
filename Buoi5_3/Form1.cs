using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_3
{
    public partial class Form1 : Form
    {
        string[] listLoaiSP = { "Áo nam", "Áo nữ", "Áo nam nữ", "Đồ bộ nam", "Đồ bộ nữ"};
        string[] listDonVi = { "Cái", "Bộ" };
        int rowChose = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = listLoaiSP;
            cbDonVi.DataSource = listDonVi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong, gia;
            try
            {
                if (!txtMaSP.Text.Length.Equals(5))
                {
                    throw new Exception("Mã SP ải 5 ký tự!");
                }
                if (this.checkMaSP(txtMaSP.Text) == false)
                {
                    throw new Exception("Mã SP đã tồn tại!");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên SP không được đẻ trống!");
                }
                if (!int.TryParse(txtSoLuong.Text, out soluong))
                {
                    throw new Exception("Số lượng không hợp lệ!");
                }
                if (!int.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Số lượng không hợp lệ!");
                }

                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string loai = cbLoaiSP.Text;
                string donvi = cbDonVi.Text;

                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[row].Cells["LoaiSP"].Value = loai;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["DonVi"].Value = donvi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        public bool checkMaSP(string masp)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masp)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowChose = e.RowIndex;
            if (rowChose != -1 && rowChose < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSP.Text = dgvDanhSach.Rows[rowChose].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowChose].Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowChose].Cells["SoLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowChose].Cells["Gia"].Value.ToString();
                string loaisp = dgvDanhSach.Rows[rowChose].Cells["LoaiSP"].Value.ToString();
                string donvi = dgvDanhSach.Rows[rowChose].Cells["DonVi"].Value.ToString();
                int i = 0;
                while (i < listLoaiSP.Length && listLoaiSP[i] != loaisp)
                {
                    i++;
                }
                cbLoaiSP.SelectedIndex = i;
                int j = 0;
                while (j < listDonVi.Length && listDonVi[j] != donvi)
                {
                    j++;
                }
                cbDonVi.SelectedIndex = j;
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int soluong, gia;
            try
            {
                if (rowChose == -1 || rowChose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SP!");
                }
                if (!txtMaSP.Text.Length.Equals(5))
                {
                    throw new Exception("Mã SP phải 5 ký tự!");
                }
                if (this.checkMaSP(txtMaSP.Text) == false && txtMaSP.Text != dgvDanhSach.Rows[rowChose].Cells["MaSP"].ToString())
                {
                    throw new Exception("Mã SP đã tồn tại!");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Chưa nhập tên!");
                }
                if (!int.TryParse(txtSoLuong.Text, out soluong))
                {
                    throw new Exception("Số lượng không hợp lệ!");
                }
                if (!int.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Giá không hợp lệ!");
                }

                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string loai = cbLoaiSP.Text;
                string donvi = cbDonVi.Text;

                dgvDanhSach.Rows[rowChose].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[rowChose].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[rowChose].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[rowChose].Cells["LoaiSP"].Value = loai;
                dgvDanhSach.Rows[rowChose].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowChose].Cells["DonVi"].Value = donvi;

                rowChose = -1;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
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
                if (rowChose == -1 || rowChose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SP!");
                }
                dgvDanhSach.Rows.RemoveAt(rowChose);
                rowChose = -1;
                btnSua.Enabled = false;
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string loaiLoc = cbLoaiSP.Text;
            for(int i=0; i<dgvDanhSach.Rows.Count-1; i++)
            {
                if (dgvDanhSach.Rows[i].Cells["LoaiSP"].Value.ToString()!= loaiLoc)
                {
                    dgvDanhSach.Rows.RemoveAt(i);
                }    
            }

        }
    }
}
