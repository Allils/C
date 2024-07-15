using InfoAboutBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DisplayInfo
    {
        public void DisplayBooks(List<Book> bookList)
        {
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title - {book.Title} \t Genre - ({book.Genre}) \t Author - {book.Author} \t Year- {book.Year}");
            }
        }
    }

}
