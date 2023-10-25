namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bestSum = -1;
            int bestCount = 0;
            int bestStart = 1000;
            int[] bestDna = null;
            int turn = 0;
            int bestTurn = 0;

            while (true)
            {
                int count = 0;
                int sum = 0;
                int start = -1;

                string command = Console.ReadLine();
                if (command == null)
                {
                    continue;
                }

                if (command == "Clone them!")
                {
                    if (bestDna != null)
                    {
                        Console.WriteLine($"Best DNA sample {bestTurn} with sum: {bestSum}.");
                        Console.WriteLine(string.Join(" ", bestDna));
                    }
                    break;
                }

                int[] arr = command.Split("!", n + 1, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                turn++;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        if (start == -1)
                        {
                            start = i;
                        }
                        count++;
                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestDna = arr;
                            bestSum = sum;
                            bestTurn = turn;
                            bestStart = start;
                        }
                        else if (bestCount == count)
                        {
                            if (bestStart > start)
                            {
                                bestCount = count;
                                bestDna = arr;
                                bestSum = sum;
                                bestTurn = turn;
                                bestStart = start;
                            }
                            else if (bestStart == start)
                            {
                                if (bestSum < sum)
                                {
                                    bestCount = count;
                                    bestDna = arr;
                                    bestSum = sum;
                                    bestTurn = turn;
                                    bestStart = start;
                                }
                            }
                        }

                    }
                    else
                    {
                        count = 0;
                        start = -1;
                    }
                }


            }

        }
    }
}