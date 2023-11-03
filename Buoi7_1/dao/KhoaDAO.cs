using Buoi7_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra2.dao
{
    internal class KhoaDAO
    {
        private Model1 db;

        public KhoaDAO()
        {
            db = new Model1();
        }

        // Lấy tất cả khoa
        public List<Khoa> GetAllKhoa()
        {
            return db.Khoas.ToList();
        }

        // Lấy khoa theo mã
        public Khoa GetKhoaByMaKhoa(int maKhoa)
        {
            return db.Khoas.FirstOrDefault(k => k.MaKhoa == maKhoa);
        }

        // Lấy khoa theo tên
        public Khoa GetKhoaByTenKhoa(string tenKhoa)
        {
            return db.Khoas.FirstOrDefault(k => k.TenKhoa == tenKhoa);
        }

        // Thêm khoa
        public void AddKhoa(Khoa khoa)
        {
            db.Khoas.Add(khoa);
            db.SaveChanges();
        }

        // Xóa khoa
        public void DeleteKhoa(int maKhoa)
        {
            Khoa khoa = db.Khoas.FirstOrDefault(k => k.MaKhoa == maKhoa);
            if (khoa != null)
            {
                db.Khoas.Remove(khoa);
                db.SaveChanges();
            }
        }

        // Cập nhật khoa
        public void UpdateKhoa(Khoa khoaUpdated)
        {
            Khoa khoa = db.Khoas.FirstOrDefault(k => k.MaKhoa == khoaUpdated.MaKhoa);
            if (khoa != null)
            {
                khoa.TenKhoa = khoaUpdated.TenKhoa;
                khoa.GhiChu = khoaUpdated.GhiChu;
                db.SaveChanges();
            }
        }
    }
}
