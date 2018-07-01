using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD
{
    static class ChucNang
    {
        public static void ThemSV()
        {
            string tuade = "";
            string Them = "";
            SinhVien sinhVien = new SinhVien();
            ThongbaoBatDau(Them);
            sinhVien.Nhap();
            sinhVien.Xuat(tuade);
            bool ketqua = XacnhanThuchien(Them);
            if (ketqua)
            {
                List<SinhVien> dsSinhvien = new List<SinhVien>();
                TapTin tapTin = new TapTin(dsSinhvien);
                tapTin.Ghifile();
            }

        }
        public static void ThongbaoBatDau(string Them)
        {

        }
        public static bool XacnhanThuchien(string Them)
        {
            return true;
        }
    }
    class SinhVien
    {
        public SinhVien()
        {
        }
        public void Nhap()
        {

        }
        public void Xuat(string tuade)
        {

        }
    }
    class TapTin
    {
        public TapTin(List<SinhVien> dsSinhVien)
        {
        }
        public void Ghifile() { }
    }
}
