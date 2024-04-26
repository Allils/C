using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Напишите консольную программу
// B которую пользователь вводит с клавиатуры два числа.
// А программа сранивает два введенных числа и выводит на консоль результат сравнения
// (два числа равны, первое число больше второго или первое число меньше второго).

namespace ex1._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число - ");
            int frst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число - ");
            int scnd = Convert.ToInt32(Console.ReadLine());
            
           if (frst > scnd)
            {
                Console.WriteLine("Первое число больше второго");
                Console.WriteLine($"{frst}>{scnd}") ;
            }

          else if (frst < scnd)
            {
                Console.WriteLine("Второе число больше первого");
                Console.WriteLine($"{frst}<{scnd}");
            }

            else
            {
                Console.WriteLine("Числа равны");
                Console.WriteLine($"{frst}=={scnd}");
            }
            Console.WriteLine("Вот так вот");
        }
    }
}
