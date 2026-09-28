using System;
using System.Globalization; 
using Tyuiu.BelovolovVS.Sprint1.Task5.V5.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беловолов В. С.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Беловолов Вячеслав Сергеевич                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выделить первую цифру из дробной части положительного вещественного     *");
            Console.WriteLine("* числа X.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите положительное вещественное число X: ");

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int d = ds.Calculate(x);

            Console.WriteLine($"Первая цифра дробной части: {d}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}