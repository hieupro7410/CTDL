using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT1
{
    class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTb;
        private string loai;
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string ChuyenNganh { get; set; }
        public int NamSinh { get; set; }
        public float DiemTb { get; set; }
        public string Loai { get; set; }

        public SinhVien() { }
        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTb)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTb = diemTb;
            XepLoai(diemTb);
        }

        public SinhVien(SinhVien sv) 
        {
            maSo = sv.maSo;
            hoTen = sv.hoTen;
            chuyenNganh = sv.chuyenNganh;
            namSinh = sv.namSinh;
            diemTb = sv.diemTb;
            Loai = sv.Loai;

        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap ma so: ");
            maSo = Console.ReadLine();
            Console.WriteLine("Nhap chuyen nganh: ");
            chuyenNganh = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            KiemTraNamSinh(namSinh);
            Console.WriteLine("Nhap diem TB: ");
            diemTb = float.Parse(Console.ReadLine());
            KiemTraDiemTB(diemTb);
            XepLoai(diemTb);
        }

        public bool KiemTraNamSinh(int namSinh)
        {
            while (DateTime.Now.Year - namSinh < 17 || DateTime.Now.Year - namSinh > 70 )
            {
                Console.WriteLine("Nhap lai nam sinh: ");
                namSinh = Convert.ToInt32(Console.ReadLine());
            }
            return false;
        }
        public bool KiemTraDiemTB(float diemTB)
        {
            while (diemTB < 0 || diemTB > 10)
            {
                Console.WriteLine("Nhap lai diem TB: ");
                diemTB = Int32.Parse(Console.ReadLine());
            }
            return false;
        }
        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Ma so: {maSo}");
            Console.WriteLine($"Chuyen Nganh: {chuyenNganh}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Diem TB: {diemTb}");
            Console.WriteLine($"Xep loai: {loai}");
            Console.WriteLine();
        }

        public void XepLoai(float diemTB)
        {
            
                if (diemTb < 5)
                {
                    loai = "Kem";
                }
                else if (5 <= diemTb && diemTb < 7)
                {
                    loai = "Trung binh";
                }
                else if (7 <= diemTb && diemTb < 8)
                {
                    loai = "Kha";
                }
                else loai = "Gioi";
            
        }
    }
}
