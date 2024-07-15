
using InfoAboutBook;

namespace Library
{
    public class AllLibrary
    {
        public IBookReader Reader { get; set; }
        public IBookBinder Binder { get; set; }
        public IBookValidator Validator { get; set; }


        public AllLibrary(IBookReader reader, IBookBinder binder, IBookValidator validator)
        {
            this.Reader = reader;
            this.Binder = binder;
            this.Validator = validator;

        }
        public void Process(List<Book> bookList)
        {
            void GetInfoAboutBook(List<Book> bookList)
            {

                ConsoleBookReader reader = new ConsoleBookReader();

                string?[] data = reader.GetInputData();

                Book book = Binder.CreateBook(data);

                if (Validator.IsValid(book))
                {
                    bookList.Add(book);

                    Console.WriteLine("Данные успешно добавлены");
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }

            }
            GetInfoAboutBook(bookList);
        }
    }

    public class GeneralBookValidator : IBookValidator
    {
        public bool IsValid(Book book) =>
            !string.IsNullOrEmpty(book.Title) && book.Year  > 0;
    }

    public class GeneralBookBinder : IBookBinder
    {
        public Book CreateBook(string?[] data)
        {
            if (data is { Length: 4 } && data[0] is string title &&
            title.Length > 0 && int.TryParse(data[3], out var year) && data[1] is string author && data[2] is string genre)
            {
                return new Book(title, author , genre ,year);

            }
            throw new Exception("Ошибка привязчика модели Phone. Некорректные данные");
        }
    }

    public class ConsoleBookReader : IBookReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Введите Title");
            string? bookTitle = Console.ReadLine();

            Console.WriteLine("Введите Author");
            string? bookAuthor = Console.ReadLine();


            Console.WriteLine("Введите Genre");
            string? bookGenre = Console.ReadLine();

            Console.WriteLine("Введите Year");
            string? bookYear = Console.ReadLine();

            return new string?[] { bookTitle, bookAuthor, bookGenre, bookYear };
        }
    }


    public interface IBookValidator
    {
        public bool IsValid(Book book);
    }
    public interface IBookBinder
    {
        Book CreateBook(string?[] data);
    }
    public interface IBookReader
    {
        public string?[] GetInputData();
    }
}
