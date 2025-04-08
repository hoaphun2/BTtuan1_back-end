using System;

class Program
{
    static void Main()
    {
        // Nhập số nguyên dương n
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        // Kiểm tra n hợp lệ
        if (n < 0)
        {
            Console.WriteLine("Vui long nhap so nguyen duong!");
        }
        else
        {
            long giaiThua = 1;

            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }

            Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
