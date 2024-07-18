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
        public void ConsoleBooks(List<Book> bookList)
        {
            Console.WriteLine("All BookList: ");
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title - {book.Title} \n\t Genre - {book.Genre} \n\t Author - {book.Author} \n\t Year- {book.Year}");
            }
        }
     
    }

}
