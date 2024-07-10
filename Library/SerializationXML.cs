using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Xml.Serialization;


namespace SerializationXML
{
        [Serializable]
        public class Books ()
        {
            public List<Book> BookList { get; set; } = new List<Book>();
        }

        [Serializable]
        public class Book
        {
        [XmlElement("Book")]
            public string Title { get; set; }
            public string Author { get; set; }
        
            public string Genre { get; set; }
            public int Id { get; set; }

            public Book() { }
            public Book( string Title, string Author, string Genre, int Id)
            {
                this.Title = Title;
                this.Author = Author;
                this.Genre = Genre;
                this.Id = Id;
            }
        }
}