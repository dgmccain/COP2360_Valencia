using System;
using static System.Console;

class CountVowelsProgram
{
    public static void Main(string[] args)
    {
        string entry;
        int vowelCount;
        bool flag = true;

        while (flag)
        {
            WriteLine("Enter a phrase: ");
            entry = ReadLine().ToLower(); //phrase for checking vowels...

            vowelCount = CountVowels(entry);
            WriteLine("\nThere are {0} vowels in that phrase.", vowelCount);
            WriteLine("Enter 'q' to quit the program: ");
            entry = ReadLine();
            char.TryParse(entry, out char result); //check if user enters char data type...
            {
                if (result == 'q' || result == 'Q') //cannot use result.ToLower() in TryParse...
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            Console.Clear(); //clear screen between outputs...
        }
        WriteLine("You quit the program...goodbye");
        ReadLine(); //pauses for viewing output...
    }
    public static int CountVowels(string phrase)
    {
        int count = 0;
        bool vowelChecker = false;

        for (int i = 0; i < phrase.Length; i++) //phrase.Length means no array(s) needed for phrase input...
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
