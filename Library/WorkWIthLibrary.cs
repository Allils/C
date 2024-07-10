using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SerializationXML;

namespace Library
{
    public class WorkWithBook
    {

        public void AddBook()
        {
            Book addBook = new Book();
            Books bookList = new Books();

            Console.WriteLine("Введите Title");
            string bookTitle = Console.ReadLine()!;

            Console.WriteLine("Введите Author");
            string bookAuthor = Console.ReadLine()!;

            Console.WriteLine("Введите Genre");
            string bookGenre = Console.ReadLine()!;

            Console.WriteLine("Введите Id");
            int bookId = Convert.ToInt32(Console.ReadLine());

            Book book = new Book( bookTitle,  bookAuthor,  bookGenre,  bookId);

            bookList.BookList.Add(book);

           

        }

        public void SerializeXML(Books books)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Books));

            using (FileStream fs = new FileStream("Books.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, books);
            }
        }

        public void Serialize()
        {
            Books bookList = new Books();

            SerializeXML(bookList);
        }



    }


}