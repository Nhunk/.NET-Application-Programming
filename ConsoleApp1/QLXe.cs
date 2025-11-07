using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XE
{
    internal class QLXe
    {
        private Dictionary<string, Xe> dsXe = new Dictionary<string, Xe>();
        public void ThemXe()
        {
            Xe xe = new Xe();
            xe.Nhap();

            if(dsXe.ContainsKey(xe.BienSo))
            {
                Console.WriteLine("Xe với biển số này đã tồn tại.");
            }
            else
            {
                dsXe.Add(xe.BienSo, xe);
                Console.WriteLine("Đã thêm xe thành công.");
            }
        }

        public void XuatDanhSach()
        {
            Console.WriteLine("\n===DANH SÁCH XE===");
            if(dsXe.Count == 0)
            {
                Console.WriteLine("Chưa có xe nào trong danh sách.");
                return;
            }
            foreach (var xe in dsXe.Values)
            {
                xe.Xuat();
                Console.WriteLine("-------------------");
            }
        }

        public void SuaXe()
        {
            Console.Write("Nhập biển số xe cần sửa: ");
            string bs = Console.ReadLine();
            if ((!dsXe.ContainsKey(bs)){ }
            {
                Console.WriteLine("Không tìm thấy xe với biển số này.");
                return;
            }
            Xe xeCu = dsXe[bs];
            Console.WriteLine("Nhập thông tin mới cho xe:");
            Xe xeMoi = new Xe();
            xeMoi.Nhap();

            if(xeMoi.BienSo != bs)
            {
                dsXe.Remove(bs);
                if(dsXe.ContainsKey(xeMoi.BienSo))
                {
                    Console.WriteLine("Xe với biển số mới đã tồn tại. Hủy bỏ việc sửa.");
                    dsXe.Add(bs, xeCu);
                    return;
                }
                dsXe.Add(xeMoi.BienSo, xeMoi);
            }
            else
            {
                dsXe[bs] = xeMoi;
            }
            Console.WriteLine("Đã sửa thông tin xe thành công.");
        }

        public void XoaXe()
        {
            Console.Write("Nhập biển số xe cần xóa: ");
            string bs = Console.ReadLine();
            if(dsXe.Remove(bs))
            {
                Console.WriteLine("Đã xóa xe thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy xe với biển số này.");
            }
        }

        public void TimKiemXeTheoBienSo()
        {
            Console.Write("Nhập biển số cần tìm: ");
            string bs = Console.ReadLine();

            if (dsXe.ContainsKey(bs))
            {
                Console.WriteLine("Đã tìm thấy xe: ");
                dsXe[bs].Xuat();
            }
            else Console.WriteLine("Không tìm thấy!");
        }
    }
}
