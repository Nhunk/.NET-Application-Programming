using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int i = 0;

        Console.WriteLine("Nhập 5 số nguyên:");

        while (i < 5)
        {
            Console.Write($"Số thứ {i + 1}: ");
            string input = Console.ReadLine();

          
            if (int.TryParse(input, out int value))
            {
                numbers[i] = value;
                i++;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập lại");
            }
        }


        int max = numbers[0];
        for (int j = 1; j < numbers.Length; j++)
        {
            if (numbers[j] > max)
                max = numbers[j];
        }

        Console.WriteLine($"\n Số lớn nhất trong 5 số là: {max}");
    }
}
