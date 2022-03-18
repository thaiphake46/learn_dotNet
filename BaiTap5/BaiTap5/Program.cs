using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    internal class Program
    {
        struct SinhVien
        {
            public int MSSV;
            public string hoTen;
            public double diemToan;
            public double diemTriet;
            public double diemNet;
        }

        static bool isWhiteSpace(string c)
        {
            return c == " ";
        }

        static SinhVien nhapDL()
        {
            SinhVien infoStudent;
            Console.Write("- Nhap MSSV: ");
            infoStudent.MSSV = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhap ho ten: ");
            infoStudent.hoTen = Console.ReadLine();
            infoStudent.hoTen = infoStudent.hoTen.Trim();
            string[] ht = infoStudent.hoTen.Split(' ');
            foreach (string s in ht)
            {
                Console.WriteLine(s);
            }
            int len = ht.Length;
            Console.Write("- Nhap diem toan: ");
            do
            {
                infoStudent.diemToan = Convert.ToDouble(Console.ReadLine());
            } while (infoStudent.diemToan < 0 || infoStudent.diemToan > 10);
            Console.Write("- Nhap diem triet: ");
            do
            {
                infoStudent.diemTriet = Convert.ToDouble(Console.ReadLine());
            } while (infoStudent.diemTriet < 0 || infoStudent.diemTriet > 10);
            Console.Write("- Nhap diem net: ");
            do
            {
                infoStudent.diemNet = Convert.ToDouble(Console.ReadLine());
            } while (infoStudent.diemNet < 0 || infoStudent.diemNet > 10);
            return infoStudent;
        }

        static void Main(string[] args)
        {
            SinhVien infoS = nhapDL();
            Console.WriteLine("+ MSSV: " + infoS.MSSV);
            Console.WriteLine("+ Ho ten: " + infoS.hoTen);
            Console.WriteLine("+ Diem toan: " + infoS.diemToan);
            Console.WriteLine("+ Diem triet: " + infoS.diemTriet);
            Console.WriteLine("+ Diem net: " + infoS.diemNet);
        }
    }
}
