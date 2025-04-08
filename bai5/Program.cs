using System;

class Program
{
    static void Main()
    {
        // Nhập số thứ nhất
        Console.Write("Nhap so thu nhat: ");
        double so1 = double.Parse(Console.ReadLine());

        // Nhập số thứ hai
        Console.Write("Nhap so thu hai: ");
        double so2 = double.Parse(Console.ReadLine());

        // Tính tổng và tích
        double tong = so1 + so2;
        double tich = so1 * so2;

        // Hiển thị kết quả
        Console.WriteLine($"Tong cua {so1} va {so2} la: {tong}");
        Console.WriteLine($"Tich cua {so1} va {so2} la: {tich}");

        // Giữ màn hình console
        Console.ReadKey();
    }
}
