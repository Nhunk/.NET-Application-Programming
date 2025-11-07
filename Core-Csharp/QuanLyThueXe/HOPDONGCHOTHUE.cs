using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe
{
     public class HOPDONGCHOTHUE : IThanhTien
    {
        string soHopDong;
        DateTime ngayThue;
        int soNgayThue;
        double donGia;
        KHACHHANG khachHang;
        NHANVIEN nhanVien;
        QUANLYXE quanLyXe;
        XE xeDuocThue;

        public string SoHopDong { get => soHopDong; set => soHopDong = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        internal XE XeDuocThue { get => xeDuocThue; set => xeDuocThue = value; }
        internal KHACHHANG KhachHang { get => khachHang; set => khachHang = value; }
        internal NHANVIEN NhanVien { get => nhanVien; set => nhanVien = value; }
        internal QUANLYXE QuanLyXe { get => quanLyXe; set => quanLyXe = value; }

        public HOPDONGCHOTHUE(QUANLYXE qlx)
        {
            this.quanLyXe = qlx;
        }

        public void Nhap()
        {
            Console.Write("Nhập biển số xe cần thuê: ");
            string bienSo = Console.ReadLine();

            if (!quanLyXe.dsXe.ContainsKey(bienSo))
            {
                Console.WriteLine("Xe với biển số này không tồn tại trong hệ thống.");
                return;
            }
            xeDuocThue = quanLyXe.dsXe[bienSo];

            Console.WriteLine("--- Nhập thông tin khách hàng ---");
            khachHang = new KHACHHANG();
            khachHang.Nhap();

            Console.WriteLine("--- Nhập thông tin nhân viên lập hợp đồng ---");
            nhanVien = new NHANVIEN();
            nhanVien.Nhap();

            Console.Write("Nhập số hợp đồng: ");
            soHopDong = Console.ReadLine();
            while (true)
            {                
                Console.Write("Nhập ngày thuê (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                try
                {
                    this.ngayThue = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Định dạng ngày không hợp lệ. Vui lòng nhập lại.");
                }
            }
            Console.Write("Nhập số ngày thuê: ");
            soNgayThue = int.Parse(Console.ReadLine());

        }
        public void TinhDonGia()
        {
            if (xeDuocThue is XECHOHANG)
                donGia = 500;
            else if (xeDuocThue is XEDULICH dl)
            {
                if (dl.SoChoNgoi < 5)
                    donGia = 500;
                else if (dl.SoChoNgoi <= 7)
                    donGia = 700;
                else
                    donGia = 1000;
            }
        }
        public double ThanhTien()
        {
            TinhDonGia();
            return donGia * soNgayThue;
        }

        public void Xuat()
        {
            TinhDonGia();
            Console.WriteLine($"\n=== HỢP ĐỒNG {SoHopDong} ===");
            Console.WriteLine($"Ngày thuê: {NgayThue.ToShortDateString()} - Số ngày: {SoNgayThue}");
            Console.WriteLine($"Đơn giá: {donGia} - Thành tiền: {ThanhTien()}");
            Console.WriteLine("\n-- Thông tin xe --");
            xeDuocThue?.Xuat();
            Console.WriteLine("\n-- Khách hàng --");
            khachHang?.Xuat();
            Console.WriteLine("\n-- Nhân viên lập hợp đồng --");
            nhanVien?.Xuat();
            Console.WriteLine("=============================\n");
        }       
    }
}
