using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string charName = "Barış";
            int charAge;
            charAge = 29;
            Console.WriteLine("Hello, I'm " + charName);
            Console.WriteLine("I'm " + charAge);

            charName = "John";
            char grade = 'A';
            double gpa = 3.5;
            // float,decimal
            bool isReal = true;
            Console.WriteLine("My best friend is " + charName +". He is a " +grade+" class developer");
            Console.WriteLine("His GPA is " + gpa +". Yes, that's"+ isReal);
            Console.ReadLine();
        }
    }
}
