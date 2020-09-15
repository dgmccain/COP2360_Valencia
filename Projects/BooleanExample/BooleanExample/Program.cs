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

            lastYearContestantsAsString = ReadLine();
            lastYearContestants = Convert.ToInt32(lastYearContestantsAsString);
            thisYearContestantsAsString = ReadLine();
            thisYearContestants = Convert.ToInt32(thisYearContestantsAsString);
            WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", lastYearContestants, thisYearContestants);
            
            thisYearRevenue = ENTRANCE_FEE * thisYearContestants;
            WriteLine("Revenue expected this year is ${0}", thisYearRevenue);
            
            bool statement = thisYearContestants > lastYearContestants;
            WriteLine("It is {0} that this year's competition is bigger than last year's", statement);
    }
}
