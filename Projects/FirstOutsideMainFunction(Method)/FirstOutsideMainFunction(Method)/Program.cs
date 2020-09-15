using System;
using static System.Console;
class PaintingEstimate
{
    static void Main()
    {
        double length;
        double width;
        WriteLine("Enter length of room in feet: ");
        length = Convert.ToDouble(ReadLine());
        WriteLine("Enter width of room in feet: ");
        width = Convert.ToDouble(ReadLine());

        ComputeCost(length, width);

        ReadLine();
    }

    public static double ComputeCost(double length, double width)
    {
        double cost;
        cost = (length * 9 * 6 * 2) + (width * 9 * 6 * 2);
        WriteLine("The total cost is {0}", cost.ToString("C"));
        return 0;
    }
}