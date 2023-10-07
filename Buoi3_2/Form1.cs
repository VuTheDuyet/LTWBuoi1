using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_2
{
    public partial class Form1 : Form
    {
        string ds = "";
        int stt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lblThongBao.Text = "";
                if (tbxMSSV.Text.Length.Equals(0))
                {
                    throw new Exception("Mã số sinh viên không được để trống!");
                }
                if (textBoxName.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống!");
                }
                if (textBoxNgaySinh.Text.Length.Equals(0))
                {
                    throw new Exception("Ngày Sinh không được để trống!");
                }

                //lây Thong Tin
                string MSSV = tbxMSSV.Text;
                string HoTen = textBoxName.Text;
                string NgaySInh = textBoxNgaySinh.Text;
                string GioiTinh = (radioButtonNam.Checked)?"Nam":"Nữ";
                string SoThich = null;
                if (checkBoxDuLich.Checked)
                {
                    SoThich += "Du Lịch";
                }
                if (checkBoxMuaSam.Checked)
                {
                    SoThich += "Mua Sắm";
                }
                if (checkBoxTheThao.Checked)
                {
                    SoThich += "Thể Thao";
                }
                if (SoThich!=null)
                {
                    SoThich = "\tSở Thích :" + SoThich;
                }

                ds +="\n\r" + stt + "\t Mã Số Sinh Viên: " + MSSV + "\t Họ tên: " + HoTen + "\t Ngay Sinh: " + NgaySInh + "\t Giới Tính: " + GioiTinh + SoThich+"\n\r";
                tbxDanhSach.Text = ds;
                stt += 1;
                tbxMSSV.Text = "";
                textBoxName.Text = "";
                textBoxNgaySinh.Text = "";
                
            }
            catch(
            Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            tbxDanhSach.Text = "";
            stt = 1;
            ds = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxNgaySinh_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }
    }
}
