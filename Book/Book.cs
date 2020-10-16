using System;
using System.Net;

namespace BookClass
{
    public class Book
    {
        public string Title { get; }

        public string Author { get; }

        public int PageNumber { get; }

        public string Isbn13 { get; }

        public Book(string _title, string _author, int _pageNumber, string _isbn13)
        {
            if (_title.Length < 2)
                throw new ArgumentOutOfRangeException(Title,"The title should be minimum 2 characters long");
            if (_author.Length==0)
                throw new ArgumentNullException(Author,"The book should have an author");
            if (_pageNumber < 10 || _pageNumber > 1000)
                throw new ArgumentOutOfRangeException(paramName:PageNumber.ToString(),"The number of pages should be between 10 and 1000");
            if (_isbn13.Length != 13)
                throw new ArgumentOutOfRangeException(Isbn13,"The Isbn should have exactly 13 characters");
            Title = _title;
            Author = _author;
            PageNumber = _pageNumber;
            Isbn13 = _isbn13;
        }

    }
}
