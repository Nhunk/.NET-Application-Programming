using System;
using System.Collections.Generic;


namespace QuanLyThueXe
{
    public class SOHOPDONG 
    {
        private Dictionary<string, HOPDONGCHOTHUE> dsHopDong = new Dictionary<string, HOPDONGCHOTHUE>();

        public void Luu(HOPDONGCHOTHUE hd)
        {
            if (dsHopDong.ContainsKey(hd.SoHopDong))
                Console.WriteLine("Số hợp đồng đã tồn tại!");
            else
            {
                dsHopDong.Add(hd.SoHopDong, hd);
                Console.WriteLine("Đã lưu hợp đồng!");
            }
        }

        public void XuatTatCa()
        {
            Console.WriteLine("\n===== DANH SÁCH HỢP ĐỒNG =====");
            if(dsHopDong.Count == 0)
            {
                Console.WriteLine("Chưa có hợp đồng nào trong danh sách.");
                return;
            }
            foreach (var hd in dsHopDong.Values)
                hd.Xuat();
        }

        public void Tim()
        {
            Console.Write("Nhập số hợp đồng cần tìm: ");
            string sohd = Console.ReadLine();

            if (dsHopDong.ContainsKey(sohd))
                dsHopDong[sohd].Xuat();
            else
                Console.WriteLine("Không tìm thấy hợp đồng!");
        }

        public void Xoa()
        {
            Console.WriteLine("Nhập số hợp đồng cần xóa: ");
            string sohd = Console.ReadLine();
            if (dsHopDong.Remove(sohd))
                Console.WriteLine("Đã xóa hợp đồng!");
            else
                Console.WriteLine("Không tìm thấy hợp đồng cần xóa!");
        }
    }

}
