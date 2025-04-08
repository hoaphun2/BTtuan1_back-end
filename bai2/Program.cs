using System;

class Program
{
    static void Main()
    {
        // Nhập chiều dài
        Console.Write("Nhap chieu dai: ");
        double chieuDai = double.Parse(Console.ReadLine());

        // Nhập chiều rộng
        Console.Write("Nhap chieu rong: ");
        double chieuRong = double.Parse(Console.ReadLine());

        // Tính diện tích
        double dienTich = chieuDai * chieuRong;

        // Hiển thị kết quả
        Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}");

        // Giữ màn hình console
        Console.ReadKey();
    }
}
