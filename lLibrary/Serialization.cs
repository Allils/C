using InfoAboutBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library
{
    public class Serialization
    {
        public void SerializeXML(List<Book> bookList)
        {
            Books books = new Books();
            XmlSerializer xml = new XmlSerializer(typeof(Books));

            foreach (Book item in bookList)
            {
                if (item != null)
                {
                    books.BookList.Add((Book)item);
                }
            }

            using (FileStream fs = new FileStream("Books.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, books);
                if (fs.Length > 0)
                {
                    Console.WriteLine("Данные успешно добавлены");
                }
                else
                {
                    Console.WriteLine("Данные не добавлены");
                }
            }
        }

        public List<Book> DeserializeXML(List<Book> bookList)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Books));
            if (bookList != null)
            {
                using (FileStream fs = new FileStream("Books.xml", FileMode.Open))
                {
                    Books books = (Books)xml.Deserialize(fs)!;

                    foreach (Book item in books.BookList)
                    {
                        bookList.Add(item);
                    }
                }
            }

            return bookList!;
        }
    }

}
