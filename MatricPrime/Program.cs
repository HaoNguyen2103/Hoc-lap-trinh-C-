public class Program
{
    public static void Main(string[] args)
    {
        int[,] a = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        for (var i = 0; i < a.GetLength(0); i++)
        {
            for (var j = 0; j < a.GetLength(1); j++)
            {
                Console.WriteLine($"Element at ({i}, {j}) = {a[i, j]}  ");
            }
        }
        for (var i = 0; i < a.GetLength(0); i++)
        {
            for (var j = 0; j < a.GetLength(1); j++)
            {
                if (isPrime(a[i, j]))
                {
                    Console.WriteLine($"Element at ({i}, {j}) is prime: {a[i, j]}");
                }
            }
        }
    }
    public static bool isPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}