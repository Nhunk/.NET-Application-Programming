using System;


namespace QuanLyThueXe
{
    internal class NHANVIEN : NGUOI
    {
        string maNhanVien;
        DateTime ngayVaoCoQuan;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public DateTime NgayVaoCoQuan { get => ngayVaoCoQuan; set => ngayVaoCoQuan = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập mã nhân viên: ");
            this.maNhanVien = Console.ReadLine();
            while (true)
            {
                Console.Write("Nhập ngày vào cơ quan (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                try
                {
                    this.ngayVaoCoQuan = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Định dạng ngày không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
                }
            }
        }
        public override void Xuat()
        {
            Console.WriteLine($"Mã nhân viên: {this.maNhanVien}");
            base.Xuat();
            Console.WriteLine($"Ngày vào cơ quan: {this.ngayVaoCoQuan:dd/MM/yyyy}");
        }
    }
}
