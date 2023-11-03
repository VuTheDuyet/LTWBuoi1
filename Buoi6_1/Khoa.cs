using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_1
{
    internal class Khoa
    {
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string GhiChu { get; set; }

        public Khoa() { }
        public Khoa(int makhoa, string tenkhoa, string ghichu)
        {
            this.MaKhoa = makhoa;
            this.TenKhoa = tenkhoa;
            this.GhiChu = ghichu;
        }

        public Khoa(string tenkhoa, string ghichu)
        {
            this.TenKhoa = tenkhoa;
            this.GhiChu = ghichu;
        }
    }
}
