using InfoAboutBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{

    public class GeneralSort
    {
        public void Process(List<Book> bookList) {        
            
           
            


            DisplayInfo display = new DisplayInfo();
            Books books = new Books();

            short YourChoise = Choise();
            if (YourChoise == 1)
            {
                Console.WriteLine("Сделать Reverse сортировку? \n Да - 1 \n Нет - 2");
               byte choise = Convert.ToByte(Console.ReadLine());
                if (choise == 1) 
                { bookList.Reverse(); }  

                else if (choise == 2)
                { bookList.Sort(); }
                else { Console.WriteLine("Недействительно"); }
            }
            else if (YourChoise == 2)
            {
                

                Console.WriteLine("Сделать Reverse сортировку? \n Да - 1 \n Нет - 2");
                byte choise = Convert.ToByte(Console.ReadLine());

                if (choise == 1)
                { bookList.Reverse(); }

                else if (choise == 2)
                {
                    bookList.Sort(delegate (Book Title, Book Year)
                    {

                        if (Title == null && Year == null) { return 0; }
                        else if (Title == null) { return -1; }
                        else if (Year == null) { return 1; }
                        else
                        { return Title.Year.CompareTo(Year.Year); }
                    });
                }

                else { Console.WriteLine("Недействительно"); }
            }

            else if (YourChoise == 3) 
            {
                Console.WriteLine("Сделать Reverse сортировку? \n Да - 1 \n Нет - 2");
                byte choise = Convert.ToByte(Console.ReadLine());

                if (choise == 1)
                { bookList.Reverse(); }

                else if (choise == 2)
                {
                    bookList.Sort(delegate (Book Title, Book Author)
                {

                    if (Title == null && Author == null) { return 0; }
                    else if (Title == null) { return -1; }
                    else if (Author == null) { return 1; }
                    else
                    { return Title.Author.CompareTo(Author.Author); }
                });
                }
            }
            else if (YourChoise == 4)
            {
                Console.WriteLine("Сделать Reverse сортировку? \n Да - 1 \n Нет - 2");
                byte choise = Convert.ToByte(Console.ReadLine());

                if (choise == 1)
                { bookList.Reverse(); }

                else if (choise == 2)
                {
                    bookList.Sort(delegate (Book Title, Book Genre)
                {

                    if (Title == null && Genre == null) { return 0; }
                    else if (Title == null) { return -1; }
                    else if (Genre == null) { return 1; }
                    else
                    { return Title.Genre.CompareTo(Genre.Genre); }
                });
                }
            }
            
            byte Choise()
            {
                Console.WriteLine("Выбери сортировку: Сортировка по названию - 1, Сортировка по году книги - 2,\nСортировка по Автору книги - 3, Сортировка по Жанру книги - 4 ");
               
                byte choise = Convert.ToByte((Console.ReadLine()));
                if (choise == 1)
                {
                    return choise;
                }
                else if (choise == 2)
                {
                    return choise;
                }
                else if (choise == 3)
                {
                    return choise;
                }
                else if (choise == 4)
                {
                    return choise;
                }
                else { Console.WriteLine("Выбор недействителен"); }

                return 0;
            }
        }
    }  
}