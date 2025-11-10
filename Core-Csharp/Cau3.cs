using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập tháng (1-12): ");
        int thang = int.Parse(Console.ReadLine());
        int nam;
        int soNgay;

        switch (thang)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                soNgay = 31;
                break;
            case 4: case 6: case 9: case 11:
                soNgay = 30;
                break;
            case 2:
                Console.Write("Nhập năm: ");
                nam = int.Parse(Console.ReadLine());
                // Kiểm tra năm nhuận
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                    soNgay = 29;
                else
                    soNgay = 28;
                break;
            default:
                Console.WriteLine("Tháng không hợp lệ!");
                return;
        }

        Console.WriteLine($"Tháng {thang} có {soNgay} ngày.");
    }
}
