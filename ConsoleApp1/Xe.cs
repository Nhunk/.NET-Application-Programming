using System;
using System.Text;

namespace XE
{
    class Xe //Chỉ được sử dụng public và internal khi khai báo class, mặc định là internal
    {
        string bienSo; //Mặc định là private
        string tenXe;
        int trongTai;
        string ngayDangKiem;
        int tieuChuanBang;

        public string BienSo { get => bienSo; set => bienSo = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public int TrongTai { get => trongTai; set => trongTai = value; }
        public string NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
        public int TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

        public void Nhap()
        {
            Console.WriteLine("NHẬP THÔNG TIN XE");
            Console.Write("Nhập biển số: ");
            bienSo = Console.ReadLine();
            Console.Write("Nhập tên xe: ");
            tenXe = Console.ReadLine();
            Console.Write("Nhập trọng tải (kg): ");
            trongTai = int.Parse(Console.ReadLine());
            Console.Write("Nhập ngày đăng kiểm (dd/MM/yyyy): ");
            ngayDangKiem = Console.ReadLine();
            Console.Write("Nhập tiêu chuẩn bằng: ");
            tieuChuanBang = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Biển số: " + bienSo);
            Console.WriteLine("Tên xe: " + tenXe);
            Console.WriteLine("Trọng tải: " + trongTai);
            Console.WriteLine("Ngày đăng kiểm: " + ngayDangKiem);
            Console.WriteLine("Tiêu chuẩn bằng: " + tieuChuanBang);
        }
    }
}


