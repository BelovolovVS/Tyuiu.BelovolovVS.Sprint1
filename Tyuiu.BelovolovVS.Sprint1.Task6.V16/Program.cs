using System;
using Tyuiu.BelovolovVS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беловолов В. С.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Беловолов Вячеслав Сергеевич                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Проверить, что в введенной строке есть восклицание (!) и вопрос (?).    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool result = ds.CheckSpecSymbols(text);

            if (result)
            {
                Console.WriteLine("В тексте присутствуют оба знака: (!) и (?)");
            }
            else
            {
                Console.WriteLine("В тексте отсутствует один или оба знака: (!) и (?)");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}