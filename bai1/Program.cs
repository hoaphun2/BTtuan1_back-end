using System;

class Program
{
    // Hàm tính tổng các số chẵn trong mảng
    static int TinhTongCacSoChan(int[] mang)
    {
        int tong = 0;
        foreach (int so in mang)
        {
            if (so % 2 == 0)
            {
                tong += so;
            }
        }
        return tong;
    }

    static void Main()
    {
        // Mảng ví dụ
        int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Gọi hàm và in kết quả
        int tongSoChan = TinhTongCacSoChan(mang);
        Console.WriteLine($"Tong cac so chan trong mang la: {tongSoChan}");

        // Giữ màn hình console
        Console.ReadKey();
    }
}
