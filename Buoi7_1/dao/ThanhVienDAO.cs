using Buoi7_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1.dao
{
    internal class ThanhVienDAO
    {
        private Model1 _context;

        public ThanhVienDAO()
        {
            _context = new Model1();
        }

        public ThanhVien getRow(string username, string password)
        {
            return _context.ThanhViens.FirstOrDefault(tv => tv.TenDangNhap == username && tv.MatKhau == password);
        }
        public int getCount()
        {
            return _context.ThanhViens.Count();
        }
        public List<ThanhVien> getList()
        {
            return _context.ThanhViens.ToList();
        }
    }
}
