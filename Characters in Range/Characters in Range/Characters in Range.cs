namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharsBetween(start, end);
        }

        static void CharsBetween(char start, char end)
        {
            int startChar = Math.Min(start, end);
            int endChar = Math.Max(start, end);

            for(int i = ++startChar; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}