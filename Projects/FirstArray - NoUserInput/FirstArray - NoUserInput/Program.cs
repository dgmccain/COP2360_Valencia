using System;
using static System.Console;
class TestScoreList
{
    static void Main()
    {
        int[] array = new int[8] { 100, 87, 79, 62, 88, 93, 70, 95 };
        int total = 0;
        int avg = 0;
        int difference = 0;
        int count = -1;

        for (int i = 0; i < array.Length; i++)
        {
            total += array[i];
        }
        avg = total / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            count++;
            difference = avg - array[i];
            WriteLine("Test # {0}:  {1} From average:  {2}", count, array[i], difference);
        }
    }
}
