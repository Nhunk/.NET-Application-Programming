using System;
using System.Text;

namespace XuLyMang2Chieu
{
    internal class XuLyMang2Chieu
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[,] a = new int[2, 3];

            Console.WriteLine("Nhập mảng 2 chiều 2x3: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMảng 2 chiều đã nhập:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Tính tổng từng hàng
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int tongHang = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    tongHang += a[i, j];
                }
                Console.WriteLine("Tổng hàng {0}: {1}", i, tongHang);
            }

            //Tính tổng từng cột
            for (int j = 0; j < a.GetLength(1); j++)
            {
                int tongCot = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    tongCot += a[i, j];
                }
                Console.WriteLine("Tổng cột {0}: {1}", j, tongCot);
            }

            //Tìm phần tử lớn nhất mảng 2 chiều
            int maxval = a[0, 0];
            int maxRow = 0, maxCol = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > maxval)
                    {
                        maxval = a[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine("\nPhần tử lớn nhất là a[{0},{1}] = {2}", maxRow, maxCol, maxval);
            Console.ReadKey();
        }
    }
}
