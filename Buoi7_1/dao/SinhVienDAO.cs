using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1.dao
{
    internal class SinhVienDAO
    {
        private Model1 db;

        public SinhVienDAO()
        {
            db = new Model1();
        }

        // Lấy tất cả sinh viên
        public List<SinhVien> GetAllSinhVien()
        {
            return db.SinhViens.ToList();
        }

        // Lấy sinh viên theo mã
        public SinhVien GetSinhVienByMaSV(string maSV)
        {
            return db.SinhViens.FirstOrDefault(sv => sv.MaSV == maSV);
        }

        // Lấy sinh viên theo họ tên
        public List<SinhVien> GetSinhVienByHoTen(string hoTen)
        {
            return db.SinhViens.Where(sv => sv.HoTen.Contains(hoTen)).ToList();
        }

        // Lấy sinh viên theo khoa
        public List<SinhVien> GetSinhVienByMaKhoa(int maKhoa)
        {
            return db.SinhViens.Where(sv => sv.MaKhoa == maKhoa).ToList();
        }

        // Thêm sinh viên
        public void AddSinhVien(SinhVien sinhVien)
        {
            db.SinhViens.Add(sinhVien);
            db.SaveChanges();
        }

        // Xóa sinh viên
        public void DeleteSinhVien(string maSV)
        {
            SinhVien sinhVien = db.SinhViens.FirstOrDefault(sv => sv.MaSV == maSV);
            if (sinhVien != null)
            {
                db.SinhViens.Remove(sinhVien);
                db.SaveChanges();
            }
        }

        // Cập nhật sinh viên
        public void UpdateSinhVien(SinhVien sinhVienUpdated)
        {
            SinhVien sinhVien = db.SinhViens.FirstOrDefault(sv => sv.MaSV == sinhVienUpdated.MaSV);
            if (sinhVien != null)
            {
                sinhVien.HoTen = sinhVienUpdated.HoTen;
                sinhVien.DiemTB = sinhVienUpdated.DiemTB;
                sinhVien.MaKhoa = sinhVienUpdated.MaKhoa;
                db.SaveChanges();
            }
        }
    }
}
