using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Xml.Serialization;
using System.Xml;

namespace InfoAboutBook
{
    [Serializable]
    public class Books
    {

        public List<Book> BookList { get; set; } = new List<Book>();
        public Books() { }
        public Books(List<Book> bookList) { BookList = bookList; }

    }

    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Book() { }
        public Book(string? Title, string Author, string Genre, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.Year = Year;
        }
    }
}