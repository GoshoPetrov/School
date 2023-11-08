namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] wordArr = new string[word.Length];

            for(int i = 0; i < word.Length; i++)
            {
                wordArr[i] = word[i].ToString();
            }

            Console.WriteLine(MiddleChar(wordArr));
        }

        static string MiddleChar(string[] word)
        {
            string middleOne = null;
            string middleTwo = null;

            if(word.Length % 2 != 0)
            {
                middleOne = word[word.Length/2];
                middleTwo = null;
            }
            else
            {
                middleOne = word[word.Length / 2 - 1];
                middleTwo= word[word.Length / 2];
            }

            return middleOne + middleTwo;
        }
    }
}