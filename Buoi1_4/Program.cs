using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 so nguyen a, b, c: ");
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());

            if (IsTriangle(a, b, c))
            {
                double p = a + b + c;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Day la 3 canh cua mot tam giac.");
                Console.WriteLine($"Chu vi cua tam giac: {p}");
                Console.WriteLine($"Dien tich cua tam giac: {s}");
            }
            else
            {
                Console.WriteLine("Khong phai la 3 canh cua mot tam giac.");
            }

            Console.ReadKey();
        }

        static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
