using System;

class Program
{
    static void Main()
    {
        // Nhập một số
        Console.Write("Nhap mot so: ");
        double so = double.Parse(Console.ReadLine());

        // Kiểm tra dương, âm, hay bằng 0
        if (so > 0)
        {
            Console.WriteLine($"{so} la so duong.");
        }
        else if (so < 0)
        {
            Console.WriteLine($"{so} la so am.");
        }
        else
        {
            Console.WriteLine("So vua nhap la 0.");
        }

        // Giữ màn hình console
        Console.ReadKey();
    }
}
