using System;
using static System.Console;
class TestScoreList
{
    static void Main()
    {
        int[] array;
        array = new int[8];
        int total = 0;
        int avg = 0;
        int difference = 0;

        WriteLine("Enter 8 values...");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(ReadLine());
            total += array[i];
        }
        avg = total / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            difference = avg - array[i];
            if (difference < 0)
            {
                difference = difference * -1;
            }
            WriteLine("{0} is {1} away from the average of {2}", array[i], difference, avg);
        }
        ReadLine();
    }
}