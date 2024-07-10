using SerializationXML;
using Library;


WorkWithBook wwb = new WorkWithBook();
Books books = new Books();

wwb.AddBook();

wwb.Serialize();


Console.WriteLine(books.BookList.Count);