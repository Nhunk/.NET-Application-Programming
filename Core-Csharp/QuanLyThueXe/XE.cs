using System;

namespace QuanLyThueXe
{
    public class XE
    {
        string bienSo;
        string tenXe;
        int trongTai;
        DateTime ngayDangKiem;
        int tieuChuanBang;

        public string BienSo { get => bienSo; set => bienSo = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public int TrongTai { get => trongTai; set => trongTai = value; }
        public DateTime NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
        public int TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

        public virtual void Nhap()
        {
            Console.Write("Nhập biển số: ");
            this.bienSo = Console.ReadLine();
            Console.Write("Nhập tên xe: ");
            this.tenXe = Console.ReadLine();
            Console.Write("Nhập trọng tải (kg): ");
            this.trongTai = int.Parse(Console.ReadLine());
            while(true)
            {
                Console.Write("Nhập ngày đăng kiểm (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                try
                {
                    this.ngayDangKiem = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Định dạng ngày không hợp lệ. Vui lòng nhập lại.");
                }
            }
            Console.Write("Nhập tiêu chuẩn bằng: ");
            this.tieuChuanBang = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Biển số: {this.bienSo}");
            Console.WriteLine($"Tên xe: {this.tenXe}");
            Console.WriteLine($"Trọng tải: {this.trongTai}");
            Console.WriteLine($"Ngày đăng kiểm: {this.ngayDangKiem:dd/MM/yyyy}");
            Console.WriteLine($"Tiêu chuẩn bằng: {this.tieuChuanBang}");
        }
    }
}
