using System;

namespace QuanLyThueXe
{
    internal class XEDULICH : XE
    {
        int soChoNgoi;
        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số chỗ ngồi: ");
            this.soChoNgoi = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("Loại xe: Du lịch:");
            base.Xuat();
            Console.WriteLine($"Số chỗ ngồi: {this.soChoNgoi}");
        }
    }
}
