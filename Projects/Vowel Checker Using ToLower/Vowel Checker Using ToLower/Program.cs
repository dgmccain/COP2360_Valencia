using System;
using static System.Console;
class CountVowelsModularized
{
    public static void Main()
    {
        string entry;
        int vowelCount;
        bool flag = true;

        while (flag)
        {
            WriteLine("Enter a phrase: ");
            entry = ReadLine().ToLower();

            vowelCount = CountVowels(entry);
            WriteLine("\nThere are {0} vowels in that phrase.", vowelCount);
            WriteLine("Enter 999 to quit the program or any other number to continue: ");
            entry = ReadLine();
            int.TryParse(entry, out int result);
            {
                if (result == 999)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            Console.Clear();
        }
        WriteLine("\nYou quit the program...goodbye");
        ReadLine(); //pauses for viewing output...
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