using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Цель игры: пользователь должен угадать случайное число от 1 до 100, которое сгенерировано программой. 
//    После каждой попытки программа должна подсказывать, больше или меньше загаданное число,
//    чем предложенное пользователем.

//Разбей логику на классы и функции. Сделать красивый вывод в консоль: 
//    Правильный ответ: зеленым цветом, неправильный красным, остальное белое(стандартное)

using System;

    class LogicOfGame
    {
        private int secretNumber;
        public void StartGame()
        {
            Console.WriteLine("Попробуй отгадать число заданное программой от 1 до 100 за наименьшее кол-во попыток");

            secretNumber = Randomnum();

            int attempts = 0;
            int value;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ваше число -  ");
                value = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (value == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Поздравляем! Вы угадали число за данное кол-во попыток:{attempts}");
                }
                else if (value < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Загаданное число больше( ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Загаданное число меньше( ");
                }


            } while (value != secretNumber);
        }
    int Randomnum()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 100);
        return secretNumber;
    }
}

class Program
{
    static void Main()
    {
        LogicOfGame game = new LogicOfGame();
        game.StartGame();
    } 

}