using System;
using static System.Console;
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