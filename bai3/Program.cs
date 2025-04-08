using System;

class Program
{
    static void Main()
    {
        // Nhập nhiệt độ Celsius
        Console.Write("Nhap nhiet đo (°C): ");
        double doC = double.Parse(Console.ReadLine());

        // Chuyển đổi sang Fahrenheit
        double doF = (doC * 9 / 5) + 32;

        // In kết quả
        Console.WriteLine($"{doC}°C tuong đuong {doF}°F");

        // Giữ màn hình console
        Console.ReadKey();
    }
}
