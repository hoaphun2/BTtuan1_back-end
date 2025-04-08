using System;

class Program
{
    // Hàm kiểm tra số nguyên tố
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        // Nhập số phần tử trong mảng
        Console.Write("Nhap so phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());

        // Khai báo mảng
        int[] mang = new int[n];

        // Nhập giá trị các phần tử vào mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phun tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        // Kiểm tra và hiển thị các phần tử là số nguyên tố
        Console.WriteLine("\nCac phan tu la so nguyen to trong mang la:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(mang[i]))
            {
                Console.WriteLine($"Chi so: {i}, Gia tri: {mang[i]}");
            }
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
