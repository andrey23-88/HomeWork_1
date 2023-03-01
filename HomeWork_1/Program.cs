using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace WPU221_lesson1
{
    class Program
    {

        static void guessNumber()
        {
            WriteLine("*****Угадай число от 0 до 100!*****");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int count = 0;
            WriteLine("Количество попыток: 7");
            do
            {
                WriteLine("Введи число: ");
                userNumber = Int32.Parse(ReadLine());
                count++;

                if (userNumber < magicNumber)
                {
                    WriteLine("Введенное число меньше загаданного!");
                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Введенное число больше загаданного!");
                }
                else if (userNumber == magicNumber)
                {
                    WriteLine("Верно! Загаданное число " + magicNumber);
                    WriteLine($"Тебе понадобилось {count} попыток");
                    break;
                }
                WriteLine($"Осталось попыток: {7 - count}");
                if ((7 - count) <= 0)
                {
                    WriteLine("Игра закончена, Вы проиграли, попробуйте ещё раз.");
                    Environment.Exit(0);
                }
            } while (userNumber != magicNumber);

        }

        static void Main(string[] args)
        {
            guessNumber();
        }
    }
}
