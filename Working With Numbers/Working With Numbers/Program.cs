using System;

namespace Working_With_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Math operations + - * / %
            int num= 6;
            num++;
            // 7
            num--;
            //6
            Console.WriteLine(num);

            // Absolute Number. Output= 40
            Console.WriteLine(Math.Abs(-40));

            // Power. Output = 64
            Console.WriteLine(Math.Pow(4,3));
            // Power. Output = 68.92
            Console.WriteLine(Math.Pow(4.1, 3));

            // Square. Output = 5
            Console.WriteLine(Math.Sqrt(25));

            // Which one is bigger. Output = 55
            Console.WriteLine(Math.Max(25,55));

            // Which one is smaller. Output = 25
            Console.WriteLine(Math.Min(25, 55));

            // Round the Numbers. Output = 2
            Console.WriteLine(Math.Round(2.5));
            // Round the Numbers. Output = 3
            Console.WriteLine(Math.Round(2.6));


            // Generate Random Numbers
            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            Console.WriteLine(month);
            int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            Console.WriteLine(dice);
            int card = rnd.Next(52);     // creates a number between 0 and 51
            Console.WriteLine(card);

            Console.ReadLine();
        }
    }
}
