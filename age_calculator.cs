namespace age_calculator
{
    class Program
    {
        public static void Main()
        {
            int current_year;
            int birth_year;

            Console.WriteLine("What year is it?");
            current_year = int.Parse(Console.ReadLine()!);

            Console.WriteLine("What year were you born?");
            birth_year = int.Parse(Console.ReadLine()!);

            int age = current_year - birth_year;

            Console.WriteLine($"You are {age} years old.");

        }
    }
}

