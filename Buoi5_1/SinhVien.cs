using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_1
{
    internal class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public int MaKhoa { get; set; }
        public double DiemTB { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string mssv, string hoTen, int maKhoa,double diemTB)
        {
            this.MSSV = mssv;
            this.HoTen = hoTen;
            this.MaKhoa =maKhoa;
            this.DiemTB = diemTB;
        }

    }
    
}
