namespace Task4
{
    public class Program
    {
        public static List<int> TransformNumbers(List<int> numbers, Func<int, int> operation)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                result.Add(operation(number));
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 20; i++)
                numbers.Add(i);

            Func<int, int> square = n => n * n;
            Func<int, int> multiplyBy2 = n => n * 2;
            Func<int, int> subtract5 = n => n - 5;

            List<int> squaredNumbers = TransformNumbers(numbers, square);
            List<int> doubledNumbers = TransformNumbers(numbers, multiplyBy2);
            List<int> subtractedNumbers = TransformNumbers(numbers, subtract5);

            Console.Write("Squared numbers: ");
            foreach (int n in squaredNumbers)
                Console.Write(n + " ");
            Console.WriteLine();

            Console.Write("Doubled numbers: ");
            foreach (int n in doubledNumbers)
                Console.Write(n + " ");
            Console.WriteLine();

            Console.Write("Subtracted 5: ");
            foreach (int n in subtractedNumbers)
                Console.Write(n + " ");
            Console.WriteLine(); Console.ReadKey();
        }
    }
}
