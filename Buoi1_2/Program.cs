using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến
            int day, month, year;
            //Thông báo nhập số a
            Console.Write("Nhap so thang: ");
            //Nhập gia trị cho biến a: Ép kiểu
            month = Convert.ToInt32(Console.ReadLine());
            while (month <1 || month > 12)
            {
                Console.Write("thang khong ton tai Nhap lai so thang: ");
                month = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Nhap so nam: ");
            //Nhập gia trị cho biến b: Ép kiểu
            year = Int32.Parse(Console.ReadLine());
            while (year < 1)
            {
                Console.Write("nam khong ton tai Nhap lai so nam: ");
                month = Convert.ToInt32(Console.ReadLine());
            }
            //Tính tổng hiệu, tích, thương
            day = 0;
            switch(month)
            {
                case 1:
                    day = 31;
                    break;
                case 2:
                    if(year%4==0)
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                case 3:
                    day = 31;
                    break;
                case 4:
                    day = 30;
                    break;
                case 5:
                    day = 31;
                    break;
                case 6:
                    day = 30;
                    break;
                case 7:
                    day = 31;
                    break;
                case 8:
                    day = 31;
                    break;
                case 9:
                    day = 30;
                    break;
                case 10:
                    day = 31;
                    break;
                case 11:
                    day = 30;
                    break;
                case 12:
                    day = 31;
                    break;
            }
            //Xuất kết quả
            Console.WriteLine("so ngay trong thamg do la = " + day);
            //Dừng màn hình để xem
            Console.ReadKey();
        }
    }
}
