using System;

namespace Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","JK Rowling",400,9.0);
            Book book2 = new Book("Lord of The Rings", "Tolkien", 700,5.0);

            book2.title = "The Hobbit";
            Console.WriteLine(book1.BookAwards());
            Console.WriteLine(book2.BookAwards());


            Console.ReadLine();
        }
    }
}
