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
            int n;
            Console.Write("- Nhap so luong phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("- Nhap vao mang:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i]+": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + "i");
            }
        }
    }
}
