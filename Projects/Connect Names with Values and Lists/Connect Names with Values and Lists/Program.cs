using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        string entryString;
        int numThisYear;
        int numLastYear;
        char listKey;
        int singing = 0;
        int dancing = 0;
        int music = 0;
        int other = 0;
        int flag = 0;

        Write("Enter number of contestants last year >> ");
        entryString = ReadLine();
        numLastYear = Convert.ToInt32(entryString);
        while (numLastYear < MIN_CONTESTANTS || numLastYear > MAX_CONTESTANTS)
        {
            WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
            Write("Enter number of contestants last year >> ");
            entryString = ReadLine();
            numLastYear = Convert.ToInt32(entryString);
        }

        Write("Enter number of contestants this year >> ");
        entryString = ReadLine();
        numThisYear = Convert.ToInt32(entryString);
        while (numThisYear < MIN_CONTESTANTS || numThisYear > MAX_CONTESTANTS)
        {
            WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
            Write("Enter number of contestants this year >> ");
            entryString = ReadLine();
            numThisYear = Convert.ToInt32(entryString);
        }

        string[] namesArray = new string[numThisYear];
        char[] codesArray = new char[numThisYear];
        for (int i = 0; i < numThisYear; i++)
        {
            if (flag == 0)
            {
                WriteLine("Enter a contestant's name...");
                namesArray[i] = ReadLine().ToLower();
                WriteLine("Enter {0}'s code...", namesArray[i]);
            }
            codesArray[i] = Convert.ToChar(ReadLine().ToLower());
            if (codesArray[i] == 's')
            {
                singing = singing + 1;
                codesArray[i] = 's';
                flag = 0;
            }
            else if (codesArray[i] == 'd')
            {
                dancing = dancing + 1;
                codesArray[i] = 'd';
                flag = 0;
            }
            else if (codesArray[i] == 'm')
            {
                music = music + 1;
                codesArray[i] = 'm';
                flag = 0;
            }
            else if (codesArray[i] == 'o')
            {
                other = other + 1;
                codesArray[i] = 'o';
                flag = 0;
            }
            else
            {
                WriteLine("{0} is not a valid code", codesArray[i]);
                WriteLine("Enter another code...");
                i--;
                flag = 1;
            }
        }
        WriteLine("The types of talent are:");
        WriteLine("Singing: {0}", singing);
        WriteLine("Dancing: {0}", dancing);
        WriteLine("Musical instrument: {0}", music);
        WriteLine("Other: {0}", other);

        do
        {
            WriteLine("Enter talent code to view names or type 'z' to quit:");
            listKey = Convert.ToChar(ReadLine().ToLower());
            if (listKey == 's')
            {
                WriteLine("contestants with talent Singing are:");
            }
            else if (listKey == 'd')
            {
                WriteLine("contestants with talent Dancing are:");
            }
            else if (listKey == 'm')
            {
                WriteLine("contestants with talent Musical instrument are:");
            }
            else if (listKey == 'o')
            {
                WriteLine("contestants with talent Other are:");
            }
            for (int i = 0; i < codesArray.Length; i++)
            {
                if (codesArray[i] == listKey)
                {
                    WriteLine("{0}", namesArray[i]);
                }
            }
        } while (listKey != 'z');
    }
}