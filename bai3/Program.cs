using System;

class Program
{
    // Hàm đếm số lượng số âm và số dương trong mảng
    static void DemSoLuongSoAmVaSoDuong(int[] mang, out int soLuongSoAm, out int soLuongSoDuong)
    {
        soLuongSoAm = 0;
        soLuongSoDuong = 0;

        foreach (int so in mang)
        {
            if (so < 0)
            {
                soLuongSoAm++;
            }
            else if (so > 0)
            {
                soLuongSoDuong++;
            }
        }
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
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        // Đếm số âm và số dương trong mảng
        int soLuongSoAm, soLuongSoDuong;
        DemSoLuongSoAmVaSoDuong(mang, out soLuongSoAm, out soLuongSoDuong);

        // Hiển thị kết quả
        Console.WriteLine($"\nSo luong so am: {soLuongSoAm}");
        Console.WriteLine($"So luong so duong: {soLuongSoDuong}");

        // Giữ màn hình console
        Console.ReadKey();
    }
}
