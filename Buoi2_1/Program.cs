﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Nhap tong so sinh vien: ");
            int n=Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[n];
            Console.WriteLine("\n ======> Nhập danh sách sinh viên <=========");
            for (int i = 0;i<n;i++) {
                Console.Write("Nhap sinh viên thứ {0}", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapSV();

            }
            Console.WriteLine("=====> XUAT DANH SANH>====");
            foreach (SinhVien sv in arrSinhVien)
            {
                sv.XuatSV();
            }    
            Console.ReadKey();
        }
    }
}
