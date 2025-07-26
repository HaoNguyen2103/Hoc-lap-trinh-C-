public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hien thi cac so nguyen to tu 1 den 100");
        for (var i = 2; i < 100; i++)
        {
            if (isPrime(i))
            {
                Console.WriteLine(" " + i);
            }
        }
    }
    static bool isPrime(int n)
    {
        if (n < 2) return false;
        for (var i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}