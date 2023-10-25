namespace Something_in_Common
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();
            string n = null;

            for(int i = 0; i < arrTwo.Length; i++)
            {
                for(int j = 0; j < arrOne.Length; j++)
                {

                    if (arrOne[j] == arrTwo[i])
                    {
                        n = arrTwo[i];
                        Console.Write($"{n} ");
                    }
                }

            }
        }
    }
}