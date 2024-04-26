using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
// Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10".
// Иначе программа выводит сообщение "Неизвестное число".
namespace ex_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число - ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 5 || a ==10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
