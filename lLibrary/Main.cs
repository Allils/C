using InfoAboutBook;
using Library;



Books books = new();
Serialization serialization = new();
DisplayInfo display = new();
GeneralSort sort = new();
SearchBy search = new();

AllLibrary library =
    new AllLibrary
    (
    new ConsoleBookReader(),
    new GeneralBookBinder(),
    new GeneralBookValidator()
    );

// library.Process(books.BookList);


serialization.DeserializeXML(books.BookList);
display.ConsoleBooks(books.BookList);

 sort.Process(books.BookList);
search.SearchBook(books.BookList);
//display.ConsoleBooks(books.BookList);

serialization.SerializeXML(books.BookList);