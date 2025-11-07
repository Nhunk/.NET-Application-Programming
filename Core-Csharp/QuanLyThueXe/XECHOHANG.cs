using System;

namespace QuanLyThueXe
{
    internal class XECHOHANG : XE
    {
        double trongTaiChoPhep;
        public double TrongTaiChoPhep { get => trongTaiChoPhep; set => trongTaiChoPhep = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập trọng tải cho phép (kg): ");
            this.trongTaiChoPhep = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Loại xe: Chở hàng:");
            base.Xuat();
            Console.WriteLine($"Trọng tải cho phép: {this.trongTaiChoPhep}");
        }
    }
}
