class Program
{
    delegate double Calculation(double a, double b);

    static void Main(string[] args)
    {
        Calculation ADD = (a, b) => a + b;
        Calculation SUB = (a, b) => a - b;
        Calculation MUL = (a, b) => a * b;
        Calculation DIV = (a, b) => {
                if (a == 0 || b == 0)
                {
                    throw new DivideByZeroException("На нуль ділити не можна.");
                }
                return a / b;
            };
            Console.WriteLine("Введіть перше число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Виберіть дію +, -, *, / :");
            string nums = Console.ReadLine();
            double numres;
            switch (nums)
            {
                case "+":
                    numres = ADD(a, b);
                    break;
                case "-":
                    numres = SUB(a, b);
                    break;
                case "*":
                    numres = MUL(a, b);
                    break;
                case "/":
                    numres = DIV(a, b);
                    break;
                default:
                    throw new ArgumentException("Невідома операція .");
            }
            Console.WriteLine("Відповідь: " + numres);
        

    Console.ReadLine();
    }
}
