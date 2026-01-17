namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "hello", "world", "Yaroslaves", "delegate" };

            Action<string> printUpper = s => Console.WriteLine("Upper: " + s.ToUpper());
            Action<string> printLength = s => Console.WriteLine("Length: " + s.Length);
            Action<string> addStars = s => Console.WriteLine("Stars: *" + s + "*");

            Action<string> combinedAction = printUpper;
            combinedAction += printLength;
            combinedAction += addStars;

            foreach (string str in strings)
            {
                Console.WriteLine("Result for string: " + str);
                combinedAction(str);
                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
