using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanChi
{
    internal class InCanChi
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập năm dương lịch: ");
            int namDL = int.Parse(Console.ReadLine());

            String can = "";
            String chi = "";

            switch (namDL % 10)
            {
                case 0: can = "Canh"; break;    
                case 1: can = "Tân"; break;
                case 2: can = "Nhâm"; break;
                case 3: can = "Quý"; break;
                case 4: can = "Giáp"; break;
                case 5: can = "Ất"; break;
                case 6: can = "Bính"; break;
                case 7: can = "Đinh"; break;
                case 8: can = "Mậu"; break;
                case 9: can = "Kỷ"; break;
            }

            switch (namDL % 12)
            {
                case 0: chi = "Thân"; break;
                case 1: chi = "Dậu"; break;
                case 2: chi = "Tuất"; break;
                case 3: chi = "Hợi"; break;
                case 4: chi = "Tý"; break;
                case 5: chi = "Sửu"; break;
                case 6: chi = "Dần"; break;
                case 7: chi = "Mão"; break;
                case 8: chi = "Thìn"; break;
                case 9: chi = "Tỵ"; break;
                case 10: chi = "Ngọ"; break;
                case 11: chi = "Mùi"; break;
            }

            Console.WriteLine("Năm {0} là năm {1} {2}.", namDL, can, chi);
            Console.ReadKey();
        }
    }
}
