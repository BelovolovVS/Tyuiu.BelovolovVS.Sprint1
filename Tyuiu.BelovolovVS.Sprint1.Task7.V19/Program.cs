using System;
using Tyuiu.BelovolovVS.Sprint1.Task7.V19.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беловолов В. С.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Беловолов Вячеслав Сергеевич                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить математическое выражение по исходным значениям.               *");
            Console.WriteLine("* z = x - (7*x^2)/(x^3) + sin(x) + |x^4 - x^5|                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double z = ds.Calculate(x);

            Console.WriteLine($"Значение z = {z}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}