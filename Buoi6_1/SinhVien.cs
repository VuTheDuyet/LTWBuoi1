using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_1
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int MaKhoa { get; set; }
        public double DiemTB { get; set; }

        public SinhVien() { }
        public SinhVien(string masv, string hoten, int makhoa, Double diemtb)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.MaKhoa = makhoa;
            this.DiemTB = diemtb;
        }
    }
}
