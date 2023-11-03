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
    public partial class frmMain : Form
    {
        public static ThanhVien thanhvien = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (thanhvien == null)
            {
                Form frm = new frmDangNhap();
                frm.ShowDialog();
            }
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "SinhVien";
            tab.Name = "tbSinhVien";
            tab.ImageIndex = 1;

            //Tạo form và add vào tabpage tên tab
            Form frm = new frmSinhVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);

            //Kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab vào TabControl
            if (!ExistTabPage(tabControlMain, "tbSinhVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }

            tabControlMain.SelectedTab = tabControlMain.TabPages["tbSinhVien"];
        }
        private bool ExistTabPage(TabControl control, string tabPageName)
        {
            bool check = false;
            for (int i = 0; i < control.TabPages.Count; i++)
            {
                if (control.TabPages[i].Name == tabPageName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void KhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Khoa";
            tab.Name = "tbKhoa";
            tab.ImageIndex = 1;

            //Tạo form và add vào tabpage tên tab
            Form frm = new frmKhoa();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);

            //Kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab vào TabControl
            if (!ExistTabPage(tabControlMain, "tbKhoa"))
            {
                tabControlMain.TabPages.Add(tab);
            }

            tabControlMain.SelectedTab = tabControlMain.TabPages["tbKhoa"];
        }
    }
}
