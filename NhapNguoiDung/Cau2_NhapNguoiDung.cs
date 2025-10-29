using System;
using System.Text;

namespace NhapNguoiDung
{
    internal class Cau2_NhapNguoiDung
    {
        static string NhapKhongRong(string thongBao)
        {
            string input;
            do
            {
                Console.Write(thongBao);
                input = Console.ReadLine();
                if (input.Length == 0)
                    Console.WriteLine("Khong duoc de trong, vui long nhap lai!");
            } while (input.Length == 0);
            return input;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string tiepTuc;

            do
            {
                string hoTen = NhapKhongRong("Nhap ho va ten: ");
                string maSV = NhapKhongRong("Nhap ma so sinh vien: ");
                string lop = NhapKhongRong("Nhap lop: ");
                string ngaySinh = NhapKhongRong("Nhap ngay sinh (dd/mm/yyyy): ");
                Console.WriteLine("\n===Thong tin sinh vien===");
                Console.WriteLine("{0,-20} {1, -15} {2, -10} {3, -12}", "Ho va ten", "Ma so SV", "Lop", "Ngay sinh");
                Console.WriteLine("{0,-20} {1, -15} {2, -10} {3, -12}", hoTen, maSV, lop, ngaySinh);
                Console.Write("Ban co muon tiep tuc (Y/N)? ");
                tiepTuc = Console.ReadLine().Trim().ToUpper();
            } while (tiepTuc == "Y");
                Console.ReadKey();
            }
    }
}
