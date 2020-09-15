using System;
using static System.Console;
class Movie
{
    static void Main()
    {
        /*Values for if the program is asking the user to enter data
         *for checking and evaluating with predetermined info/data...

         string[] movies = new string[] {"Titanic", "The Matrix",
                                        "Transformers", "Iron Man",
                                        "Aquaman", "Pacific Rim"};
         int[] runTimes = mew int[] {182, 136,
                                    144, 126,
                                    142, 132};
        */
        string key;
        string movieName; //use if predetermined data is not needed...
        int runTime; //use if predetermined data is not needed...

        Write("Do you know how long the movie is? Enter Yes or No: ");
        key = ReadLine().ToLower();
        if (key == "no")
        {
            DisplayMovie(out movieName);
        }
        else if (key == "yes")
        {
            DisplayMovie(out movieName, out runTime); //potentially delete variable runTime above and
                                                      //add "int" after "out" on this line instead. The
                                                      //same can be done with variable movieName...
        }
        else
        {
            WriteLine("INVALID INPUT");
        }
    }
    public static void DisplayMovie(out string movie, out int time)
    {
        string entry;

        WriteLine("Enter the movie: ");
        entry = ReadLine();
        movie = entry;
        WriteLine("Enter the time: ");
        entry = ReadLine();
        time = Convert.ToInt32(entry);
        WriteLine("The movie {0} has a running time of {1} minutes.", movie, time);
    }

    // Overload in case of user only entering movie name...
    public static void DisplayMovie(out string movie)
    {
        int defaultTime = 90;
        string entry;

        WriteLine("Enter the movie: ");
        entry = ReadLine();
        movie = entry;
        WriteLine("The movie {0} has a running time of {1} minutes.", movie, defaultTime);
    }
}