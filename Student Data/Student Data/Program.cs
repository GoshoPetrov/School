namespace Student_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

            Information(name, grade);
        }

        static void Information (string name, int grade)
        {
            Console.WriteLine($"{name} is studying in {grade} grade.");
        }
    }
}