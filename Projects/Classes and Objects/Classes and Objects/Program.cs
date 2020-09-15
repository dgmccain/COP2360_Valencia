using System;
using static System.Console;
class TipCalculation
{
    static void Main()
    {
        double price;
        double doubleTip;
        int intTip;
        string entry;

        Write("Enter price: $");
        entry = ReadLine();
        price = Double.Parse(entry);

        Write("Enter tip: $");
        entry = ReadLine();
        if (int.TryParse(entry, out intTip))
        {
            DisplayTipInfo(price, intTip);
        }
        else if (double.TryParse(entry, out doubleTip))
        {
            DisplayTipInfo(price, doubleTip);
        }

        ReadLine();
    }
    public static void DisplayTipInfo(double price, double tipRate)
    {
        if (tipRate < 1)
        {
            double tip = price * tipRate;

            Write("Meal price: " + price.ToString("C"));
            WriteLine(". Tip percent: " + tipRate.ToString("0.##"));
            Write("Tip in dollars: " + tip.ToString("C"));
            WriteLine(".  Total bill " + (price + tip).ToString("C"));
        }
        else
        {
            double tipPercent = tipRate / price;

            Write("Meal price: " + price.ToString("C"));
            WriteLine(". Tip percent: " + tipPercent);
            Write("Tip in dollars: " + tipRate.ToString("C"));
            WriteLine(".  Total bill " + (price + tipRate).ToString("C"));
        }
    }
    public static void DisplayTipInfo(double price, int tip)
    {
        double tipPercent = tip / price;

        Write("Meal price: " + price.ToString("C"));
        WriteLine(". Tip percent: " + tipPercent);
        Write("Tip in dollars: " + tip.ToString("0.##"));
        WriteLine(".  Total bill " + (price + tip).ToString("C"));
    }
}