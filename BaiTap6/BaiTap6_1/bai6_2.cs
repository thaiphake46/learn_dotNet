using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6_1
{
    internal class bai6_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Tinh tong S(n):");
            Console.Write("- Nhap N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("- Tinh tong S(n1): 1+2+3+4+ … +n");
            int tong1 = 0,
                tong2 = 0,
                tong3 = 0;
            for(int i = 1; i <= n; i++)
            {
                tong1 += i;
            }
            Console.WriteLine($"Tong s(n1): {tong1}");
        }
    }
}
