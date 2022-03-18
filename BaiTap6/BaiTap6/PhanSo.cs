using System;

namespace BaiTap6
{
    internal partial class Program
    {
        class PhanSo
        {
            private int tuSo;
            private int mauSo;

            PhanSo()
            {

            }

            ~PhanSo()
            {

            }

            public void getTuSo(int tuSo)
            {
                this.tuSo = tuSo;
            }

            public void getMauSo(int mauSo)
            {
                this.mauSo = mauSo;
            }

            public void set()
            {
                Console.Write("- Nhap tu so: ");
                getTuSo(Convert.ToInt32(Console.ReadLine()));
                Console.Write("- Nhap mau so: ");
                getMauSo(Convert.ToInt32(Console.ReadLine()));
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
    }
}
