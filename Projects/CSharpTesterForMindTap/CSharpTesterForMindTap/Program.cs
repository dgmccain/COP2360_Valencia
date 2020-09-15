using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        const int ENTRANCE_FEE = 25;
        string lastYearContestantsAsString, thisYearContestantsAsString;
        int lastYearContestants, thisYearContestants;
        int thisYearRevenue;
        Write("Enter the number of contestants from last year: ");
        lastYearContestantsAsString = ReadLine();
        lastYearContestants = Convert.ToInt32(lastYearContestantsAsString);
        Write("Enter the number of contestants from this year: ");
        thisYearContestantsAsString = ReadLine();
        thisYearContestants = Convert.ToInt32(thisYearContestantsAsString);
        thisYearRevenue = ENTRANCE_FEE * thisYearContestants;
        WriteLine("This year's expected revenue is ${0}", thisYearRevenue);
        if (thisYearContestants > lastYearContestants)
        {
            WriteLine("There were more contestants this year");
        }
        if (thisYearContestants < lastYearContestants)
        {
            WriteLine("There were more contestants last year");
        }
    }
}
