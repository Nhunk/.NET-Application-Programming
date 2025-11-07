using System;

namespace ChuoiInHoa
{
    internal class Cau1_ChuoiInHoa
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string input = Console.ReadLine();

            int soChuCai = 0, soChuSo = 0;
            int i = 0;

            while (i < input.Length)
            {
                char c = input[i];
                if (char.IsLetter(c)) soChuCai++;
                if (char.IsDigit(c)) soChuSo++;
                i++;
            }

            Console.WriteLine($"So ky tu: {input.Length}");
            Console.WriteLine($"So chu cai: {soChuCai}");
            Console.WriteLine($"So chu so: {soChuSo}");
            Console.WriteLine("Chuoi sau khi in hoa: " + input.ToUpper());

            Console.ReadKey();
        }
    }
}
