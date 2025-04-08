using System;

class Program
{
    static void Main()
    {
        // Nhập số nguyên
        Console.Write("Nhap mot so nguyen: ");
        int so = int.Parse(Console.ReadLine());

        // Kiểm tra chẵn lẻ
        if (so % 2 == 0)
        {
            Console.WriteLine($"{so} la so chan.");
        }
        else
        {
            Console.WriteLine($"{so} la so le.");
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
