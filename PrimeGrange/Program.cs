public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap khoang a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap khoang b");
        int b = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (var i = a; i <= b; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine($"{i}");
                count += i;
            }
        }
            Console.WriteLine($"So nguyen to gom {count} so");
    }
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (var i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}