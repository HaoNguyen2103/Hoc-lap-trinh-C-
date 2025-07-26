using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 4;
        int cols = 3;
        int[,] arr = new int[rows, cols];
        Random rnd = new Random();
        int sum = 0;

        // Khởi tạo mảng với giá trị ngẫu nhiên và tính tổng
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rnd.Next(0, 101);
                sum += arr[i, j];
            }
        }

        // Hiển thị mảng
        Console.WriteLine("Mảng số nguyên 4x3:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Hiển thị tổng
        Console.WriteLine("Tổng các phần tử trong mảng: " + sum);
    }
}