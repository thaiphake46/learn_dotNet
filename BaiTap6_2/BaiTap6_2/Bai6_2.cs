using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6_2
{
    internal class Bai6_2
    {
        static int ucln(int a, int b)
        {
            while(a * b != 0)
            {
                if(a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }

        static int bcnn(int a, int b)
        {
            return (a * b) / ucln(a, b);
        }

        static void giaiThua()
        {
            Console.WriteLine("- Tinh n! giai thua");
            Console.Write("- Nhap n: "); int n = Convert.ToInt32(Console.ReadLine());
            int giaithua = 1;
            if(n <= 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    giaithua *= i;
                }
                Console.WriteLine($"\t+ {n}! = {giaithua}");
            }
        }

        static void P1()
        {
            Console.WriteLine("- Tinh tong S(n):");
            Console.Write("- Nhap N: "); int n = Convert.ToInt32(Console.ReadLine());

            float tong1 = 0,
                  tong2 = 0,
                  tong3 = 0;

            Console.WriteLine("- Tinh tong S(n1): 1+2+3+4+ … +n");
            for (int i = 1; i <= n; i++)
            {
                tong1 += i;
            }
            Console.WriteLine($"\t+ Tong s(n1): {tong1}");
            Console.WriteLine();

            Console.WriteLine("- Tinh tong S(n2): 1^2 + 2^2 + … + n^2");
            for (int i = 0; i <= n; i++)
            {
                tong2 += i * i;
            }
            Console.WriteLine($"\t+ Tong s(n2): {tong2}");
            Console.WriteLine();

            Console.WriteLine("- Tinh tong S(n2): 1/2 + 1/4 + 1/6 + 1/8 + ... + 1/2n");
            for (int i = 1; i <= n; i++)
            {
                tong3 += (float)1 / (2 * i);
            }
            Console.WriteLine($"\t+ Tong s(n3): {tong3}");
            Console.WriteLine();

            Console.WriteLine("- Tim ucln, bcnn cua a, b");
            Console.Write("- Nhap a:"); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhap b:"); int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\t+ UCLN cua {a} va {b}: {ucln(a, b)}");
            Console.WriteLine($"\t+ BCNN cua {a} va {b}: {bcnn(a, b)}");
            Console.WriteLine();

            giaiThua();
        }

        static void P2()
        {

        }

        static void P3()
        {

        }

        class VanDongVien
        {
            private string hoten;
            private int tuoi;
            private string monthidau;
            private float cannang;
            private float chieucao;

            public VanDongVien() {}

            public VanDongVien(string ht, int t, string mtd, float cn, float cc)
            {
                hoten = ht;
                tuoi = t;
                monthidau = mtd;
                cannang = cn;
                chieucao = cc;
            }

            public string getHoten() { return this.hoten; }
            public int getTuoi() { return this.tuoi; }
            public string getMonthidau() { return this.monthidau; }
            public float getCannang() { return this.cannang; }
            public float getChieucao() { return this.chieucao; }

            public void hienThi()
            {
                Console.WriteLine($"\t+ Ho ten: {getHoten()}");
                Console.WriteLine($"\t+ Tuoi: {getTuoi()}");
                Console.WriteLine($"\t+ Mon thi dau: {getMonthidau()}");
                Console.WriteLine($"\t+ Can nang: {getCannang()}");
                Console.WriteLine($"\t+ Chieu cao: {getChieucao()}");
            }
        }

        static void P4()
        {
            VanDongVien p = new VanDongVien("Huy Thai", 20, "Bong da", 60, 170);
            p.hienThi();
            Console.WriteLine("- Nhap vao 1 ds vdv:");
            Console.Write("- Nhap so luong vdv: "); int n = Convert.ToInt32(Console.ReadLine());
            VanDongVien[] P = new VanDongVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t- Nhap thong tin vdv {i+1}:");
                Console.Write("\t\t+ Nhap ho ten: "); string ht = Console.ReadLine();
                Console.Write("\t\t+ Nhap tuoi: "); int t = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t\t+ Nhap mon thi dau: "); string mtd = Console.ReadLine();
                Console.Write("\t\t+ Nhap can nang: "); float cn = Convert.ToSingle(Console.ReadLine());
                Console.Write("\t\t+ Nhap chieu cao: "); float cc = Convert.ToSingle(Console.ReadLine());
                P[i] = new VanDongVien(ht,t,mtd,cn,cc);
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t- vdv{i+1}");
                P[i].hienThi();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            P1();
            P4();
        }
    }
}
