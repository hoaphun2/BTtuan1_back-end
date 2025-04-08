using System;

class Program
{
    static void Main()
    {
        // Nhập năm
        Console.Write("Nhap mot nam: ");
        int nam = int.Parse(Console.ReadLine());

        // Kiểm tra năm nhuận
        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
        {
            Console.WriteLine($"{nam} la nam nhuan.");
        }
        else
        {
            Console.WriteLine($"{nam} khong phai la nam nhuan.");
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
