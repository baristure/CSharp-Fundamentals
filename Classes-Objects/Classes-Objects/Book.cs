using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Objects
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public double rating;
        public Book()
        {

        }
        public Book(string aTitle, string aAuthor, int aPages, double aRating)
        {
            title =aTitle;
            author = aAuthor;
            pages = aPages;
            rating = aRating;
        }

        public bool BookAwards()
        {
            if(rating >= 8.0)
            {
                return true;
            }
            return false;
        }
    }
}
