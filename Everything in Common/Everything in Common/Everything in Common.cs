namespace Everything_in_Common
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int item = 0;
            int count = 0;

            for(int i = 0; i < arrOne.Length; i++)
            {
                
                if (arrOne[i] == arrTwo[i])
                {
                    sum += arrTwo[i];
                }
                else
                {
                    count++;
                    item = i;
                    break;
                }
                
            }


            if (count == 0)
            {
                Console.WriteLine("Arrays are identical.");
                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine("Arrays are not identical.");
                Console.WriteLine($"Found difference at {item} index");

            }

        }
    }
}