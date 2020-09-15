using System;
using static System.Console;
class CountVowelsModularized
{
    public static void Main()
    {
        string entry;
        int vowelCount;

        WriteLine("Enter a phrase...");
        entry = ReadLine().ToLower();

        vowelCount = CountVowels(entry);
        WriteLine("There are {0} vowels in that phrase.", vowelCount);
    }
    public static int CountVowels(string phrase)
    {
        int count = 0;
        bool vowelChecker = false;

        for (int i = 0; i < phrase.Length; i++)
        {

            if (phrase[i] == 'a' || phrase[i] == 'e' ||
                phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u')
            {
                vowelChecker = true;
            }
            else
            {
                vowelChecker = false;
            }
            if (vowelChecker)
            {
                count++;
            }
        }
        return count;
    }
}
