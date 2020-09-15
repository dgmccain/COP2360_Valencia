using System;
using static System.Console;
public class Averages
{
    public static void Main()
    {
        double avg;

        Average(out avg);
        WriteLine("The average is {0}", avg);
    }

    public static void Average(out double result)
    {
        const int SIZE = 3;
        string entry;
        double[] array = new double[SIZE];
        int count = 1;
        double total = 0;

        for (int i = 0; i < SIZE; i++)
        {
            Write("Enter number {0}: ", count);
            entry = ReadLine();
            array[i] = Convert.ToDouble(entry);
            count++;
            total += array[i];
        }
        result = total / (count - 1);
    }

}