using System;

class Program
{
    static void Main()
    {
        // Nhập tên
        Console.Write("Nhap ten cua ban: ");
        string ten = Console.ReadLine();

        // Nhập tuổi
        Console.Write("Nhap tuoi cua ban: ");
        int tuoi = int.Parse(Console.ReadLine());

        // Xuất kết quả
        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");

        // Giữ màn hình console
        Console.ReadKey();
    }
}
