using System;

namespace Understanding_Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = new string[200, 10];
            int lists = names.GetLength(0); // set GetLength(0) to get 200...
                                            // the 0 is names[0,...] which is equal to 200...
                                            // set GetLength(1) to get 10...
                                            // the 1 is names[...,0] which is equal to 10...
            int elementsInArray1 = names.GetLength(0);
            int elementsInArray2 = names.GetLength(1);
            int totalElements = elementsInArray1 * elementsInArray2; // research if there is a way to use the
                                                                     // GetLength() function to find the total
                                                                     // elements in the entire array without having
                                                                     // to create variables elementsInArray1 and
                                                                     // elementsInArray2 and multiply them together...

            Console.WriteLine(lists); // output attached to above comments...
            Console.WriteLine("Elements in first portion of array: {0}", elementsInArray1);
            Console.WriteLine("Elements in second portion of array: {0}", elementsInArray2);
            Console.WriteLine("Total number of elements in entire multi-dimensional array: {0}", totalElements);
            Console.ReadLine();
        }
    }
}
