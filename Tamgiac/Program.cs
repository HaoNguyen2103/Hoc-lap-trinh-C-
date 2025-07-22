class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap gia tri a");
        int a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Nhap gia tri b");
        int b = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Nhap gia tri c");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("La canh cua tam giac");
            }
            else
            {
                Console.WriteLine("Khong phai canh cua tam giac");
            }
        }
        else
        {
            Console.WriteLine("Do dai cac canh phai lon hon 0");
        }
        
    }
}