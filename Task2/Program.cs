using System;

namespace Task2
{
    public class Program
    {
        public static List<int> FilterNumbers(List<int> numbers, Func<int, bool> condition)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (condition(number))
                    result.Add(number);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 5, 12, 15, 18, 7, 9, 22, 30 };

            List<int> evenNumbers = FilterNumbers(numbers, n => n % 2 == 0);
            List<int> greaterThan10 = FilterNumbers(numbers, n => n > 10);
            List<int> divisibleBy3 = FilterNumbers(numbers, n => n % 3 == 0);

            Console.Write("Even numbers: ");
            foreach (int n in evenNumbers)
                Console.Write(n + " ");
            Console.WriteLine();

            Console.Write("Numbers greater than 10: ");
            foreach (int n in greaterThan10)
                Console.Write(n + " ");
            Console.WriteLine();

            Console.Write("Numbers divisible by 3: ");
            foreach (int n in divisibleBy3)
                Console.Write(n + " ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
