using System;

class Program
{
    static void Main()
    {
        // Nhập số nguyên từ bàn phím
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());

        // Kiểm tra số nguyên tố
        if (n < 2)
        {
            Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
        else
        {
            bool laSoNguyenTo = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
