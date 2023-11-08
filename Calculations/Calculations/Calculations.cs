namespace Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            
            if(input == "add")
            {
                Add(input, numOne, numTwo);
            }
            else if(input == "multiply")
            {
                Multiply(input, numOne, numTwo);
            }
            else if( input == "subtract")
            {
                Subtract(input, numOne, numTwo);
            }
            else if(input == "divide")
            {
                Divide(input, numOne, numTwo);
            }
        }

        static void Add(string input, int numOne, int numTwo)
        {
            Console.WriteLine(numOne + numTwo);
        }

        static void Multiply(string input, int numOne, int numTwo)
        {
            Console.WriteLine(numOne * numTwo);
        }

        static void Subtract(string input, int numOne, int numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }

        static void Divide(string input, int numOne, int numTwo)
        {
            Console.WriteLine(numOne / numTwo);
        }

    }
}