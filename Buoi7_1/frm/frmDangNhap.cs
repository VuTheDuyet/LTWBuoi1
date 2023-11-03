using Buoi7_1.dao;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Bổ sung E
            ThanhVienDAO thanhvienDAO = new ThanhVienDAO();
            ThanhVien tv = thanhvienDAO.getRow(username, password);

            if (tv == null)
            {
                MessageBox.Show("Không đúng!");
            }
            else
            {
                frmMain.thanhvien = tv;
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
