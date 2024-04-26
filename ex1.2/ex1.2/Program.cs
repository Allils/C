using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
//  Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10".
//  Иначе программа выводит сообщение "Неизвестное число".
namespace ex1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число - ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 5 && a < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
