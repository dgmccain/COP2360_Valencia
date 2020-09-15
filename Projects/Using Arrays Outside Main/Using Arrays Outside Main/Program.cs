using System;
using static System.Console;
public class Averages
{
    public static void Main()
    {
        double avg;
        double[] array = new double[5];

        avg = Average(array);
        WriteLine("The average is {0}", avg);
    }

    public static double Average(params double[] numbers)
    {
        string entry;
        int count = 1;
        double total = 0;
        double result;

        for (int i = 0; i < numbers.Length; i++)
        {
            Write("Enter number {0}: ", count);
            entry = ReadLine();
            numbers[i] = Convert.ToDouble(entry);
            count++;
            total += numbers[i];
        }
        result = total / (numbers.Length);
        return result;
    }
}
