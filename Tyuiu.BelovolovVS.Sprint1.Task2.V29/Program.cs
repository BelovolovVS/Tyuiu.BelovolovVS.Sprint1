using System;
using Tyuiu.BelovolovVS.Sprint1.Task2.V29.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беловолов В. С.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Беловолов Вадим Сергеевич                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Задано количество секунд. Перевести время в полные часы.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите время в секундах (целое число): ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int hours = ds.ConvertSecondsToHours(seconds);

            Console.WriteLine($"Количество полных часов: {hours}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}