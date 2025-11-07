using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe
{
    internal class KHACHHANG : NGUOI
    {
        string maKhachHang;
        string hangBangLai;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HangBangLai { get => hangBangLai; set => hangBangLai = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập mã khách hàng: ");
            this.maKhachHang = Console.ReadLine();
            Console.Write("Nhập hạng bằng lái: ");
            this.hangBangLai = Console.ReadLine();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Mã khách hàng: {this.maKhachHang}");
            base.Xuat();
            Console.WriteLine($"Hạng bằng lái: {this.hangBangLai}");
        }
    }
}
