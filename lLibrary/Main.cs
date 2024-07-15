using InfoAboutBook;
using Library;




Books books = new Books();
Serialization serialization = new Serialization();
DisplayInfo display = new DisplayInfo();



AllLibrary library =
    new AllLibrary
    (
    new ConsoleBookReader(),
    new GeneralBookBinder(),
    new GeneralBookValidator()
    );

library.Process(books.BookList);

serialization.DeserializeXML(books.BookList);
serialization.SerializeXML(books.BookList);


display.DisplayBooks(books.BookList);
