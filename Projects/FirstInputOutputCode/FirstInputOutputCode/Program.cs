using System;
using static System.Console;
class MonthNames
{
    enum Month
    {
        JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY,
        AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    }
    static void Main()
    {
     string userNumAsString;
     int userNum;
     Month userMonth;
        Write("Enter a number representing a month: ");
        userNumAsString = ReadLine();
        userNum = Convert.ToInt32(userNumAsString);
        userMonth = (Month)userNum;
        Write("You entered {0} which represents the month of {1}\n",
        userNum, userMonth);
    }
}