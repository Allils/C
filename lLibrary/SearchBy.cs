using InfoAboutBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SearchBy 
    {
        public class BookSearch
        {
            String _s;

            public BookSearch(String s)
            {
                _s = s;
            }

            public bool StartsWithTitle(Book e)
            {
                return e.Title.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase);
            }
            public bool StartsWithGenre(Book e)
            {
                return e.Genre.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase);
            }
            public bool StartsWithAuthor(Book e)
            {
                return e.Author.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase);
            }
            
        }

        public void SearchBook(List<Book> bookList) 
        {
            Console.WriteLine("Что вы хотите найти: \n книгу по Title - 1 \n книгу по Genre - 2 \n  книгу по Author - 3 ");
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("По какому Title вы хотите найти книгу?");
                string s = Convert.ToString(Console.ReadLine())!;
                var bs = new BookSearch(s);
                int index = bookList.FindIndex(bs.StartsWithTitle);
                ConsoleThisBook(index);
            }
            if (choose == 2)
            {
                Console.WriteLine("По какому Genre вы хотите найти книгу?");
                string s = Convert.ToString(Console.ReadLine())!;
                var bs = new BookSearch(s);
                int index = bookList.FindIndex(bs.StartsWithGenre);
                ConsoleThisBook(index);
            }
            if (choose == 3)
            {
                Console.WriteLine("По какому Author вы хотите найти книгу?");
                string s = Convert.ToString(Console.ReadLine())!;
                var bs = new BookSearch(s);
                int index = bookList.FindIndex(bs.StartsWithAuthor);
                ConsoleThisBook(index);
            }


            void ConsoleThisBook(int index)
            {
             

                if (index >= 0 && index < bookList.Count)
                {
                    Book book = bookList[index];

                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Genre: " + book.Genre);
                    Console.WriteLine("Year: " + book.Year);
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }

            }

        }
      
    }
   

}
