namespace Task5
{
    public class Student
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, double grade)
        {
            Name = name;
            AverageGrade = grade;
        }
    }
    public class Program
    {
        public static List<Student> FilterStudents(List<Student> students, Predicate<Student> condition)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in students)
            {
                if (condition(student))
                    result.Add(student);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Anna", 80),
                new Student("Alex", 70),
                new Student("Bob", 78),
                new Student("Yaroslav", 90),
                new Student("Petro", 60),
                new Student("Andrew", 76)
            };

            Predicate<Student> highGrade = s => s.AverageGrade > 75;
            List<Student> highGradeStudents = FilterStudents(students, highGrade);

            Predicate<Student> nameStartsWithA = s => s.Name.StartsWith("A");
            List<Student> studentsWithA = FilterStudents(students, nameStartsWithA);

            Console.WriteLine("Students with average grade > 75:");
            foreach (Student s in highGradeStudents)
                Console.WriteLine($"Name: {s.Name}, Average Grade: {s.AverageGrade}");

            Console.WriteLine("\nStudents with names starting with 'A':");
            foreach (Student s in studentsWithA)
                Console.WriteLine($"Name: {s.Name}, Average Grade: {s.AverageGrade}");
            Console.ReadKey();
        }
    }
}
