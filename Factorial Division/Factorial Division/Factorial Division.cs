namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"{SumOfFactorial(numOne, numTwo):F02}");
        }

        static decimal SumOfFactorial(int numOne, int numTwo)
        {
            decimal sumOne = 1;
            decimal sumTwo = 1;

            for(int i = numOne; i > 1; i--) 
            {
                sumOne *= i;
            }

            for(int j = numTwo; j > 1; j--)
            {
                sumTwo *= j;
            }

            return sumOne / sumTwo;
        }
    }
}