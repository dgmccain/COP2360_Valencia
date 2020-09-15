using System;
using static System.Console;

class FlexibleArrayMethodProgram
{
    public static void Main()
    {
        int[] array1 = new int[5];
        int[] array2 = new int[7];
        int[] array3 = new int[10];
        int sum1;
        int sum2;
        int sum3;
        int total;
        string sumMessage1 = "The sum of array ";
        string sumMessage2 = " is:";
        int count = 1;
        int garbageNum;
        char quitKey;

        do
        {
            sum1 = FindSum(count, sumMessage1, sumMessage2, array1);
            count++;
            sum2 = FindSum(count, sumMessage1, sumMessage2, array2);
            count++;
            sum3 = FindSum(count, sumMessage1, sumMessage2, array3);
            count++;
            garbageNum = FindSum(count, sumMessage1, sumMessage2, array3);
            total = sum1 + sum2 + sum3;
            WriteLine(total);
            WriteLine("Type 'q' to quit the program: ");
            quitKey = Convert.ToChar(ReadLine());
        } while (quitKey != 'q' || quitKey != 'Q');
        Clear();
        WriteLine("You quit the program.");
        ReadLine();
    }
    public static int FindSum(int count, string mes1, string mes2, params int[] array)
    {
        int result = 0;
        if (count < 4)
        {
            Write("Enter ");
            Write(array.Length);
            WriteLine(" numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine();
            Write("Array ");
            Write(count);
            WriteLine(" info...");
            Write("Numbers in array ");
            Write(count);
            WriteLine(" are:");
            foreach (int num in array)
            {
                Write(num);
                Write(" ");
                result += num;
            }
            WriteLine();
            Write(mes1);
            Write(count);
            WriteLine(mes2);
            WriteLine(result);
            WriteLine();
        }
        else
        {
            Write("The total sum of all arrays is ");
        }
        return result;
    }
}
