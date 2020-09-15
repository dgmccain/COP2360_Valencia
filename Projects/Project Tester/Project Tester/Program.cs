using System;

namespace Project_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2016, 3, 1);
            startDate = startDate.AddMonths(3);

            Console.WriteLine(startDate);
            Console.ReadLine();
        }
    }
}
