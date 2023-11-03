using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_1
{
    internal class Khoa
    {
        public string MaKhoa { get; set; }
        public string MaKhob { get; set; }
        public string GhiChu { get; set; }

        public Khoa() { }

        public Khoa(string maKhoa, string maKhob, string ghiChu)
        {
            this.MaKhoa = maKhoa;
            this.MaKhob = maKhob;
            this.GhiChu = ghiChu;
        }
    }
}
