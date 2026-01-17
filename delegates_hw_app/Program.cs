namespace delegates_hw_app
{
    public delegate double Calc(double a, double b);
    public class Program
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => (b != 0) ? a / b :
            throw new Exception("Divide by zero...");
        static void Main(string[] args)
        {
            Calc calc = new Calc(Subtract);
            CalculatorDisplay(Add, 14, 10);
            CalculatorDisplay(Subtract, 14, 10);
            CalculatorDisplay(Divide, 14, 10);
            CalculatorDisplay(Multiply, 14, 10);
            Console.ReadKey();
        }
        public static void CalculatorDisplay(Calc calc, double a, double b) =>
            Console.WriteLine($"Result: {calc(a, b)}");
    }
}
