using System;
using System.Collections.Generic;

namespace QuanLyThueXe
{
    public class QUANLYXE
    {
        public Dictionary<string, XE> dsXe = new Dictionary<string, XE>();
        public void Nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhập H để nhập xe chở hàng, D để nhập xe du lịch, hoặc Q để thoát:");
                string choice = Console.ReadLine().ToUpper();
                if(choice == "Q") break;
                if(choice == "H")
                {
                    XE xe = new XECHOHANG();
                    xe.Nhap();
                    dsXe.Add(xe.BienSo, xe);                       
                }
                else if(choice == "D")
                {
                    XE xe = new XEDULICH();                   
                    xe.Nhap();
                    dsXe.Add(xe.BienSo, xe);                           
                }                
            }
           
        }

        public void XuatDanhSach()
        {
            Console.WriteLine("\n===DANH SÁCH XE===");
            if (dsXe.Count == 0)
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

        public void XoaXe()
        {
            Console.Write("Nhập biển số xe cần xóa: ");
            string bs = Console.ReadLine();
            if (dsXe.Remove(bs)) Console.WriteLine("Đã xóa xe thành công.");
            else Console.WriteLine("Không tìm thấy xe với biển số này.");
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
