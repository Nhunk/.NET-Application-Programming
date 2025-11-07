using System;

namespace QuanLyThueXe
{
    public class NGUOI
    {
        long soCM;
        string hoTen;
        string SDT;

        public long SoCM { get => soCM; set => soCM = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
         public virtual void Nhap()
        {
            Console.Write("Nhập số chứng minh nhân dân: ");
            this.soCM = long.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            this.SDT = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Số CMND: {this.soCM}");
            Console.WriteLine($"Họ tên: {this.hoTen}");
            Console.WriteLine($"Số điện thoại: {this.SDT}");
        }
    }
}
