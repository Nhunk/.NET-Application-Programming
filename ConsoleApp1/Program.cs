using System;
using System.Text;

namespace XE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            QLXe ql = new QLXe();
            int chon;

            do
            {
                Console.WriteLine("\n===== MENU QUẢN LÝ XE =====");
                Console.WriteLine("1. Thêm xe mới");
                Console.WriteLine("2. Xuất danh sách xe");
                Console.WriteLine("3. Sửa thông tin xe theo biển số");
                Console.WriteLine("4. Xóa xe theo biển số");
                Console.WriteLine("5. Tìm kiếm xe theo biển số");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (chon)
                {
                    case 1: ql.ThemXe(); break;
                    case 2: ql.XuatDanhSach(); break;
                    case 3: ql.SuaXe(); break;
                    case 4: ql.XoaXe(); break;
                    case 5: ql.TimKiemXeTheoBienSo(); break;
                    case 0: Console.WriteLine("Thoát chương trình..."); break;
                    default: Console.WriteLine("❗ Lựa chọn không hợp lệ."); break;
                }

            } while (chon != 0);
        }
    }
}
