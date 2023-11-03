using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_1
{
    internal class SinhVienDao
    {
        SqlConnection conn = null;
        SqlCommand cmd = null; 
        SqlDataAdapter apt = null; 
        KetNoi kn = new KetNoi(); 
        public SinhVienDao() { 
            conn = kn.GetConnect(); 
            if (conn.State == ConnectionState.Closed) 
            { 
                conn.Open(); 
            } 
        } //Một số phương thức khác

        public DataTable getList(int? makhoa = null)
        {
            string sql = null;
            if (makhoa != null)
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen,SinhVien.DiemTB,Khoa.TenKhoa";
                sql += "FROM SinhVien INNER JOIN KHoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaKhoa'" + makhoa + "'";
            }
            cmd=new SqlCommand(sql, conn);
            apt=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        //truy van tra ve so luong 
        public int getCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
    }
}
