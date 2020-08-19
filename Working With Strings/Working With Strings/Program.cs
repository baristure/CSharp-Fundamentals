using System;

namespace Working_With_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // New Line
            Console.WriteLine("Hello\nWorld!");

            // Pass the quotation mark inside of string
            Console.WriteLine("Hello\"World!");

            // Length of string variables
            string phrase = "Barış Türe";
            Console.WriteLine(phrase.Length);

            // Convert to UpperCase
            Console.WriteLine(phrase.ToUpper());

            // Convert to LowerCase
            Console.WriteLine(phrase.ToLower());

            // Check the Phrase Contains the string. Expected output is true
            Console.WriteLine(phrase.Contains("Barış"));

            // Access the input character in the string. Expected output is "B"
            Console.WriteLine(phrase[0]);

            // Access the input character's first location in the string. Expected output is "2"
            // If this phrase does not contain this input expected output is "-1"
            Console.WriteLine(phrase.IndexOf('r'));


            //Substring method. Expected outputs are "Türe" and "Tü".
            Console.WriteLine(phrase.Substring(phrase.IndexOf("T")));
            Console.WriteLine(phrase.Substring(phrase.IndexOf("T"),2));

            Console.ReadLine();
        }
    }
}
