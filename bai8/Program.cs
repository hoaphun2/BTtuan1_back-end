using System;

class Program
{
    static void Main()
    {
        // In bảng cửu chương từ 1 đến 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBang cuu chuong {i}:");

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
