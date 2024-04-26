using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
// Напишите консольную программу, в которую пользователь вводит сумму вклада.
// Если сумма вклада меньше 100, то начисляется 5%.
// Если сумма вклада от 100 до 200, то начисляется 7%.
// Если сумма вклада больше 200, то начисляется 10%.
// В конце программа должна выводить сумму вклада с начисленными процентами.
//
// Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
namespace ex_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада - ");
           double a = Convert.ToDouble( Console.ReadLine() );
            if ( a < 100)
            {
                a = a + 0.05 * a;
            }
            else if ( a > 100 && a < 200)
            {
                a = a + 0.07 * a;
            }
            else if ( a > 200)
            {
                a = a + a * 0.1;
            }
            Console.WriteLine($"Cумма c накопленными процентами - {a} ");
            
                
        }
    }
}
