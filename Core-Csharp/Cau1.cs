using System;

class Program
{
    static int Nhap()
    {
        int n;
        do
        {
            Console.Write("Nhập số nguyên n (n ≥ 0): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out n) && n >= 0)
                break;
            else
                Console.WriteLine("Dữ liệu không hợp lệ, vui lòng nhập lại!");
        } while (true);
        return n;
    }

    static void Main()
    {
        int n = Nhap();

        int tongWhile = 0;
        int i = 1;
        while (i <= n)
        {
            tongWhile += i;
            i++;
        }

        int tongFor = 0;
        for (int j = 1; j <= n; j++)
        {
            tongFor += j;
        }

        Console.WriteLine($"Tổng 1 → {n} (while): {tongWhile}");
        Console.WriteLine($"Tổng 1 → {n} (for): {tongFor}");
    }
}
