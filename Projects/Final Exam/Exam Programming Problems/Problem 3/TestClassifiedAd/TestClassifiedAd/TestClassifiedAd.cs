using System;
using static System.Console;




class TestClassidiedAd
{
    static void Main()
    {
        ClassifiedAd obj1 = new ClassifiedAd("Colgate", 1);
        ClassifiedAd obj2 = new ClassifiedAd("Nationwide is on your side", 5);
        string quitKey;

        Display("Sample Advertisement: ", obj1);
        WriteLine();
        obj1.DisplayPrice(obj1.Advertisement, obj1.Price);
        WriteLine();
        Display("Sample Advertisement: ", obj2);
        WriteLine();
        obj2.DisplayPrice(obj2.Advertisement, obj2.Price);
        WriteLine();

        do
        {
            WriteLine("Enter your ad here: ");
            ClassifiedAd obj3 = new ClassifiedAd(ReadLine());
            WriteLine();
            obj3.DisplayPrice(obj3.Advertisement, obj3.Price);
            WriteLine();

            WriteLine("Would you like to enter another ad? If not, type 'quit' to exit: ");
            quitKey = ReadLine().ToLower();
            Console.Clear();
        } while (quitKey != "quit");

        WriteLine("You chose to quit the program");
        ReadLine();

    }
    static void Display(string message, ClassifiedAd ad)
    {
        WriteLine(message);
        WriteLine(ad.Advertisement);
    }
}
class ClassifiedAd
{
    public ClassifiedAd(string advert)
    {
        Advertisement = advert;
        int wordCount = 1;

        for (int i = 0; i < advert.Length; i++)
        {
            if (advert[i] == ' ')
            {
                wordCount++;
            }
        }
        Price = wordCount * 0.09;
    }
    public ClassifiedAd(string advert, int words)
    {
        Advertisement = advert;
        Price = words * 0.09;
    }
    public string Advertisement
    {
        get;
        set;
    }
    public double Price
    {
        get;
    }
    public void DisplayPrice(string advert, double price)
    {
        WriteLine("*** Advertisement: ''{0}'' will cost ${1} ***", advert, price);
    }
}