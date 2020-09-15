using System;
using static System.Console;
class SwimmingWaterTemperature
{
    static void Main()
    {
        string entry;
        int userTemp = 0;
        bool check;

        Write("Enter temperature: ");
        entry = ReadLine();
        userTemp = Convert.ToInt32(entry);

        do
        {
            try
            {
                if (userTemp <= 32 || userTemp >= 212)
                {
                    throw (new Exception("Value does not fall within the expected range."));
                }

                check = CheckComfort(userTemp);
                Write(userTemp);
                Write(" degrees is");
                if (check == false)
                {
                    Write(" not");
                }
                WriteLine(" comfortable for swimming.");
                WriteLine("Enter another temperature or 999 to quit");
                entry = ReadLine();
                userTemp = Convert.ToInt32(entry);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                WriteLine("Enter another temperature or 999 to quit");
                entry = ReadLine();
                userTemp = Convert.ToInt32(entry);
            }
        } while (userTemp != 999);
    }

    public static bool CheckComfort(int temp)
    {
        if (temp < 85 && temp > 75)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}