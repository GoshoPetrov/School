namespace Nothing_in_Comon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int n = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        n = arr[i];
                        Console.WriteLine(string.Join(" ", n, arr[j]));
                        
                    }
                }
            }
        }
    }
}