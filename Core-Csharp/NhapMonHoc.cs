using System;
using System.Collections.Generic;
using System.Text;

namespace NhapMonHoc
{
    internal class NhapMonHoc
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Dictionary<string, string> dsMonHoc = new Dictionary<string, string>();

            while (true)
            {
                Console.Write("Nhập '1' để thêm môn, '0' để dừng nhập: ");
                if (!int.TryParse(Console.ReadLine(), out int chon)) continue;

                if (chon == 0)   break;

                if (chon == 1)
                {
                    Console.Write("Nhập mã môn học: ");
                    string maMon = Console.ReadLine();

                    if (dsMonHoc.ContainsKey(maMon))
                    {
                        Console.WriteLine("Mã môn đã tồn tại");
                        continue;
                    }

                    Console.Write("Nhập tên môn học: ");
                    string tenMon = Console.ReadLine();

                    // Thêm vào dictionary
                    dsMonHoc.Add(maMon, tenMon);
                    Console.WriteLine("Đã thêm thành công\n");
                }
                else  Console.WriteLine("Vui lòng nhập 1 hoặc 0");
               }

            // Kiểm tra và thêm "Kỹ thuật thương mại điện tử" nếu chưa có
            string monKT = "Kỹ thuật thương mại điện tử";
            bool kt = dsMonHoc.ContainsValue(monKT);

            if (!kt)
            {
                dsMonHoc.Add("IS385", monKT);
                Console.WriteLine("\nĐã thêm môn Kỹ thuật thương mại điện tử");
            }
            else Console.WriteLine("\nĐã có môn Kỹ thuật thương mại điện tử");

            // Đếm số lượng môn học hiện tại
            Console.WriteLine();
            Console.WriteLine("Số lượng môn học hiện tại: " + dsMonHoc.Count);

            // Xóa môn CS464 nếu có
            if (dsMonHoc.ContainsKey("CS464"))
            {
                dsMonHoc.Remove("CS464");
                Console.WriteLine("Đã xoá mã CS464");
            }

            //In danh sách môn học
            Console.WriteLine();
            Console.WriteLine("Danh sách môn học học kì hè 2023-2024:");
            foreach (var mon in dsMonHoc)
            {
                Console.WriteLine("- " + mon.Key + ": " + mon.Value);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
