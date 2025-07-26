public class Program
{
    public static void Main(string[] args)
    {
        double money = 1;
        double month = 1;
        double interest_rate = 1.0;
        Console.WriteLine("Nhap gia  tri money: ");
        money = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so thang: ");
        month = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so ty gia: ");
        interest_rate = Convert.ToDouble(Console.ReadLine());
        double total_interest = 0;
        for (var i = 0; i < month; i++)
        {
            total_interest += money * (interest_rate / 100) / 12 * 3;

        }
        Console.WriteLine("Tong lai suat la: " + total_interest);
    }
}