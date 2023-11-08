namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            RectangleArea(x, y);
            Console.WriteLine(RectangleArea(x, y));
        }

        static int RectangleArea(int x, int y)
        {
            int sum = x * y;
            return sum;
        }

        static int RectangleAreaShort(int x, int y) => x * y;
        
    }
}