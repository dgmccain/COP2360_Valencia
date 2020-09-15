using System;
using static System.Console;




class TestClassidiedAd
{
    static void Main()
    {
        ClassifiedAd obj1 = new ClassifiedAd("Colgate");
        ClassifiedAd obj2 = new ClassifiedAd("NationWide is on your side");

        ReadLine();
    }
}
class ClassifiedAd
{
    public string Message
    {
        get
        {
            return Message;
        }
        set
        {
            Message = "Enter advertisement: ";
        }
    }
    public string Advertisement
    {
        get
        {
            return Advertisement;
        }
        set
        {
            Advertisement = ReadLine();
        }
    }
}







/*
class TestClassifiedAd
{
    static void Main()
    {
        string entry;
        string advertisement;

        WriteLine("Enter your advertisement: ");
        entry = ReadLine();
        advertisement = entry;

        ClassifiedAd obj1 = new ClassifiedAd(advertisement);

        WriteLine("Enter your advertisement: ");
        entry = ReadLine();
        advertisement = entry;

        ClassifiedAd obj2 = new ClassifiedAd(advertisement);

        ReadLine();
    }
    static string GetAd()
    {
        string entry;
        WriteLine("Enter your advertisement: ");
        entry = ReadLine();
        return entry;
    }
}

class ClassifiedAd()
{
    public void ClassifiedAd(string advertisement)
    {
    Advert = advertisement;
        int wordCount = 1;
        double price;
        double pricePerWord = 0.09;

        WriteLine("Enter your advertisement: ");
        entry = ReadLine();
        for (int i = 0; i < entry.Length; i++)
        {
            if (entry[i] == ' ')
            {
                wordCount++;
            }
        }
        price = wordCount * pricePerWord;
        WriteLine("The price for your ad is ${0}", price);
    }
}
*/

/*
class CarDemo
{
    static void Main()
    {
        string entry;
        string name;
        double value;
        Write("Enter the name of the car: ");
        entry = ReadLine();
        name = entry;
        Write("Enter the MPG of the car: ");
        entry = ReadLine();
        value = Convert.ToDouble(entry);

        Car obj1 = new Car(name, value);
        Display("\nOriginal entered info for car 1...", obj1);
        ++obj1;
        Display("\nNew info for car 1...", obj1);

        Write("\nEnter the name of the car: ");
        entry = ReadLine();
        name = entry;

        Car obj2 = new Car(name);
        Display("\nOriginal entered info for car 2...", obj2);
        ++obj2;
        Display("\nNew info for car 2...", obj2);

        ReadLine(); //pauses after being run...
    }
    public static void Display(string statusMessage, Car c)
    {
        WriteLine(statusMessage);
        WriteLine("Model: {0} and MPG: {1}", c.Model, c.Mpg);
    }
}
class Car
{
    public Car (string name, double value)
    {
        Model = name;
        Mpg = value;
    }
    public Car (string name) : this(name, 20)
    {
    }
    public string Model { get; set; }
    public double Mpg { get; set; }
    public static Car operator ++(Car s)
    {
        ++s.Mpg;
        return s;
    }
}
*/
