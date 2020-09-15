using System;
using static System.Console;
class TipCalculation
{
    static void Main()
    {
        double price;
        double tipRate;

        price = Convert.ToDouble(ReadLine());
        tipRate = Convert.ToDouble(ReadLine());

        WriteLine("Meal price: " + price.ToString("C"));
        WriteLine("Tip percent: " + tipRate.ToString("C"));


        DisplayTipInfo(price, tipRate);

        if (tipRate >= 1)
        {
            int tempVal = Convert.ToInt32(tipRate);
            DisplayTipInfo(price, tempVal);
        }

        ReadLine();
    }

    public static void DisplayTipInfo(double price, double tipRate)
    {
        if (tipRate < 1)
        {
            double tip = price * tipRate;
            WriteLine("Tip in dollars: " + tip.ToString("C"));
            WriteLine("Total bill: " + (price + tip).ToString("C"));
        }
    }
    public static void DisplayTipInfo(double price, int tipInDollars)
    {
        double tip;
        tip = tipInDollars;
        WriteLine("Tip in dollars: " + tip.ToString("C"));
        WriteLine("Total bill: " + (price + tip).ToString("C"));
    }
}