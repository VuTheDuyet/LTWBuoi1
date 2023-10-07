using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_3
{
    public partial class Form1 : Form
    {
        int stt = 1;
        string ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxThongTinSach_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try { 
            lblThongBao.Text = "";
            if (textBoxMS.Text.Length.Equals(0))
            {
                throw new Exception("Mã số sách không được để trống!");
            }
            if (textBoxMS.Text.Length < 6)
            {
                throw new Exception("Mã số sách không được bé hơn 6 kí tự");
            }
                if (textBoxTX.Text.Length.Equals(0))
            {
                throw new Exception("tên không được để trống!");
            }
            if (textBoxSL.Text.Length.Equals(0))
            {
                throw new Exception("Số Lượng không được để trống!");
            }
            if (textBoxG.Text.Length.Equals(0))
            {
                throw new Exception("Giá không được để trống!");
            }

                //lây Thong Tin
                string MSS = textBoxMS.Text;
            string Ten = textBoxTX.Text;
            string Gia = textBoxG.Text;
            string SoLuong = textBoxSL.Text;

            ds += "\n\r" + stt + "\t Mã Số Sinh Viên: " + MSS + "\t Họ tên: " + Ten + "\t Ngay Sinh: " + Gia + "\t Giới Tính: " + "\n\r";
            textBoxDS.Text = ds;
            stt += 1;
            textBoxMS.Text = "";
            textBoxTX.Text = "";
            textBoxG.Text = "";
            textBoxSL.Text = "";

        }catch(Exception ex)
            {
                 lblThongBao.Text = ex.Message;
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxDS.Text = "";
            stt = 1;
            ds = "";
        }
    }
}
