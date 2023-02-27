class secprogram
{
    static void Main(string[] args)
    {
        Func<int, int, int, double> arithmeticMean = delegate (int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        };
        Console.WriteLine("Введіть тpи числа:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        double result = arithmeticMean(num1, num2, num3);
        Console.WriteLine("Середнє арифметичне {0}, {1} і {2} дорівнює {3}.", num1, num2, num3, result);
        Console.ReadKey();
    }
}