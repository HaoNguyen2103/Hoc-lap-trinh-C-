class Program
{
    static void Main(string[] args)
    {
        string gradel = "A";
        string result = gradel switch
        {
            "A" => "Excellent",
            "B" => "Good",
            "C" => "Average",
            "D" => "Below Average",
            "F" => "Fail",
            _ => "Unknown Grade"
        };
        Console.WriteLine($"Grade: {gradel}, Result: {result}");
    }
}