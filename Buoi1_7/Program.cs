using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_7
{
    internal class Program
    {
        static bool ktNguyento(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Console.WriteLine($"Cac so nguyen to tu 1 den {n}:");
                for (int i = 1; i <= n; i++)
                {
                    if (ktNguyento(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen duong.");
            }

            Console.ReadKey();
        }
    }
}
