using System;

namespace QuanLyThueXe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=System.Text.Encoding.UTF8;
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            QUANLYXE qlx = new QUANLYXE();
            SOHOPDONG shd = new SOHOPDONG();
            HOPDONGCHOTHUE hd = new HOPDONGCHOTHUE(qlx);

            int chon;
            do
            {
                Console.WriteLine("\n===== MENU CHÍNH =====");
                Console.WriteLine("1. Nhập danh sách xe");
                Console.WriteLine("2. Xuất danh sách xe");
                Console.WriteLine("3. Tìm xe");
                Console.WriteLine("4. Xoá xe");
                Console.WriteLine("5. Lập hợp đồng cho thuê xe");
                Console.WriteLine("6. Xuất danh sách hợp đồng");
                Console.WriteLine("7. Tìm kiếm hợp đồng");
                Console.WriteLine("8. Xoá hợp đồng");
                Console.WriteLine("0. Thoát");
                Console.Write("=> Nhập lựa chọn: ");
                chon = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (chon)
                {
                    case 1:
                        qlx.Nhap();
                        break;
                    case 2:
                        qlx.XuatDanhSach();
                        break;
                    case 3:
                        qlx.TimKiemXeTheoBienSo();
                        break;
                    case 4:
                        qlx.XoaXe();
                        break;
                    case 5:
                        hd.Nhap();
                        if (!string.IsNullOrWhiteSpace(hd.SoHopDong) && hd.XeDuocThue != null)
                        {
                            shd.Luu(hd);
                        }
                        break;
                    case 6:
                        shd.XuatTatCa();
                        break;
                    case 7:
                        shd.Tim();
                        break;
                    case 8:                        
                        shd.Xoa();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
