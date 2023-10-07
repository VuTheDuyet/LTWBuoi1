using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                txtKetQua.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try {
                double a, b;
                if(!double.TryParse(txtSoA.Text,out a))
                {
                    throw new Exception("số a không được để trống hoặc Phải số");

                }
                if(!double.TryParse(txtSoB.Text,out b))
                {
                    throw new Exception("số b không được để trống hoặc Phải số");

                }
                txtKetQua.Text = (a+b).ToString();
            } catch (Exception ex)
            {
                txtKetQua.Text=ex.Message;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
