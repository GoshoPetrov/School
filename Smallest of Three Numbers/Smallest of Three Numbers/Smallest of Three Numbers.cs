namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            Console.WriteLine(TheSmallestNum(numOne, numTwo, numThree));
        }

        static int TheSmallestNum(int numOne, int numTwo, int numThree)
        {
            int smallNum = 0;
            if(numOne < numTwo && numOne < numThree)
            {
                smallNum = numOne;
            }
            else if (numTwo < numOne && numTwo < numThree)
            {
                smallNum = numTwo;
            }
            else if (numThree < numOne && numThree < numTwo)
            {
                smallNum = numThree;
            }
            else
            {

                smallNum = numOne;
            }

            
            return smallNum;
        }
    }
}