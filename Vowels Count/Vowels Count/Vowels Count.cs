namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(VowelsLetters(word));
        }

        static int VowelsLetters(string word)
        {
            int count = 0;

            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A' || word[i] == 'o' || word[i] == 'O' || word[i] == 'u' || word[i] == 'U' || word[i] == 'i' || word[i] == 'I' || word[i] == 'e' || word[i] == 'E')
                {
                    count++;
                }

            }

            return count;
        }
    }
}