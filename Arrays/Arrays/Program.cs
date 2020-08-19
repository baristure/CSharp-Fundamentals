using System;

// For the other array methods -> Min, Max, Sum
using System.Linq;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 2, 4, 6, 10, 20, 30 };

            myNumbers[1] = 1000;
            // Excpected output=1000
            Console.WriteLine(myNumbers[1]);

            //Length of Array
            Console.WriteLine(myNumbers.Length);

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            int[] myNumbers2 = { 11, 3, 5, 9, 1, 7 };
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            // Sort Arrays

            // Sort by ascending order
            Array.Sort(myNumbers2);
            foreach (int i in myNumbers2)
            {
                Console.WriteLine(i);
            }

            // sort by alphabetically
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            Console.ReadLine();
        }
    }
}
