using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class Program
    {
        public static void tongBinhPhuong()
        {
            Console.WriteLine("- Tinh tong binh phuong hai so");
            int a, b;
            Console.Write("- Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            int tongBinhPhuong = a * a + b * b;
            Console.WriteLine($"- Tong binh phuong {a}, {b}: {tongBinhPhuong}");
        }

        public static void tongPhanso()
        {
            double tong = 0;
            Console.WriteLine("- Tinh tong phan so:");
            Console.Write("- Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                tong += (double)1 / i;
            }
            Console.WriteLine($"- Tong: {tong}");
        }

        public static void mang()
        {
            int n;
            Console.Write("- Nhap vao so luong phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("- In ra so am:");
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("- In ra so le:");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }

        class PhanSo
        {
            protected int tuSo;
            protected int mauSo;

            PhanSo()
            {
                tuSo = 0;
                mauSo = 1;
            }

            ~PhanSo()
            {
                tuSo = 0;
                mauSo = 1;
            }

            //public void getTuSo(int tuSo)
            //{
            //    this.tuSo = tuSo;
            //}

            //public void getMauSo(int mauSo)
            //{
            //    this.mauSo = mauSo;
            //}

            public void set()
            {
                Console.Write("- Nhap tu so: ");
                this.tuSo = Convert.ToInt32(Console.ReadLine());
                Console.Write("- Nhap mau so: ");
                this.mauSo = Convert.ToInt32(Console.ReadLine());
            }

            public void get()
            {
                Console.Write(tuSo + "/" + mauSo);
            }

            public PhanSo Cong(PhanSo obj1, PhanSo obj2)
            {
                PhanSo obj3 = new PhanSo();
                obj3.tuSo = obj1.tuSo * obj2.mauSo + obj1.mauSo * obj2.tuSo;
                obj3.mauSo = obj1.mauSo * obj2.mauSo;
                return obj3;
            }

            public PhanSo Tru(PhanSo obj1, PhanSo obj2)
            {
                PhanSo obj3 = new PhanSo();
                obj3.tuSo = obj1.tuSo * obj2.mauSo - obj1.mauSo * obj2.tuSo;
                obj3.mauSo = obj1.mauSo * obj2.mauSo;
                return obj3;
            }

            public PhanSo Nhan(PhanSo obj1, PhanSo obj2)
            {
                PhanSo obj3 = new PhanSo();
                obj3.tuSo = obj1.tuSo * obj2.tuSo;
                obj3.mauSo = obj1.mauSo * obj2.mauSo;
                return obj3;
            }
            public PhanSo Chia(PhanSo obj1, PhanSo obj2)
            {
                PhanSo obj3 = new PhanSo();
                obj3.tuSo = obj1.tuSo * obj2.mauSo;
                obj3.mauSo = obj1.mauSo * obj2.tuSo;
                return obj3;
            }
        }

        static void Main(string[] args)
        {
            //tongBinhPhuong();
            //tongPhanso();
            //mang();
            PhanSo ps1 = new PhanSo();
            //obj1.set();
            //obj2.set();

            //obj3 = obj3.Cong(obj1, obj2);
            //obj3.get();
            //obj3 = obj3.Tru(obj1, obj2);
            //obj3.get();
            //obj3 = obj3.Nhan(obj1, obj2);
            //obj3.get();
            //obj3 = obj3.Chia(obj1, obj2);
            //obj3.get();
        }
    }
}
