using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyMang1Chieu
{
    internal class XuLyMang1Chieu
    {

        //a. Nhập mảng
        static int[] NhapMang()
        {
            Console.Write("a. Nhập n số phần tử của mảng (n>0): ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        //b. Xuất mảng
        static void XuatMang(int[] a)
        {
            foreach(int item in a)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        //c. Tổng trung bình cộng các phần tử trong mảng
        static double TBC(int[] a)
        {
            int tong = 0;
            foreach (int i in a)
                tong += i;
            return (double)tong / a.Length;
        }

        //f. Kiểm tra số nguyên tố
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
            
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int[] arr = NhapMang();

            Console.WriteLine("\nb. Mảng đã nhập:");
            XuatMang(arr);

            double tbc = TBC(arr);
            Console.WriteLine("\nc. Trung bình cộng các phần tử trong mảng: " + tbc);

            int[] arrTang = (int[])arr.Clone();
            Array.Sort(arrTang);
            Console.WriteLine("\nd. Mảng sau khi sắp xếp tăng dần:");
            XuatMang(arrTang);

            int[] arrGiam = (int[])arr.Clone();
            Array.Sort(arrGiam);
            Array.Reverse(arrGiam);
            Console.WriteLine("\nd. Mảng sau khi sắp xếp giảm dần:");
            XuatMang(arrGiam);

            int[] arrDaoNguoc = (int[])arr.Clone();
            Array.Reverse(arrDaoNguoc);
            Console.WriteLine("\nd. Mảng sau khi đảo ngược:");
            XuatMang(arrDaoNguoc);

            List<int> primes = new List<int>(); //Không quan tâm đến kích thước mảng
            foreach (int num in arr)
                if (KiemTraNguyenTo(num)) 
                    primes.Add(num);
            if (primes.Count > 0)
            {
                Console.WriteLine("\nf. Các số nguyên tố trong mảng:");
                XuatMang(primes.ToArray());
            }
            else
                Console.WriteLine("\nf. Không có số nguyên tố trong mảng.");

            Console.Write("\ne. Nhập số cần tìm kiếm: ");
            int x = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(arr, x);
            if (index != -1)
                Console.WriteLine("Số {0} được tìm thấy tại vị trí index: {1}", x, index);
            else
                Console.WriteLine("Số {0} không có trong mảng.", x);

            Console.ReadKey();

        }
    }
}
