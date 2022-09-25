using System;

namespace CTDLGT_BT1
{
    class CTDLGT_Bai01
    {
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.WriteLine("Thong tin svA:");
            svA.Xuat();
            Console.WriteLine("Thong tin svB:");
            SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6F);
            svB.Xuat();
            SinhVien svC = new SinhVien(svB);
            svC.Nhap();
            Console.WriteLine("Thong tin svC:");
            svC.Xuat();
            Console.WriteLine("Thong tin svB sau khi update:");
            svB.Xuat();

        }

        static void TestMangSinhVien()
        {
            MangSinhVien dssv = new MangSinhVien();
            dssv.Nhap();
            Console.WriteLine("Danh sach sinh vien:");
            dssv.Xuat();
        }
        static void Main(string[] args)
        {
            TestSinhVien();
        }
    }
}
