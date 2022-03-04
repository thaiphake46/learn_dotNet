using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("- Nhap vao so lung phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("- Nhap vao mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t+ a[{i}]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("- In ra mang:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t+ a[{i}]: {a[i]}");
            }
        }
    }
}
