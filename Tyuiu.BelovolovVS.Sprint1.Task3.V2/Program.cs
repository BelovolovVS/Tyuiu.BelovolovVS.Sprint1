using System;
using Tyuiu.BelovolovVS.Sprint1.Task3.V2.Lib;

namespace Tyuiu.BelovolovVS.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беловолов В. С.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Беловолов Вячеслав Сергеевич                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить стоимость покупки, состоящей из тетрадей и карандашей.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите цену тетради: ");
            double priceNotebook = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество тетрадей: ");
            int amountNotebook = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цену карандаша: ");
            double pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество карандашей: ");
            int amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double totalCost = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Console.WriteLine($"Общая стоимость покупки: {totalCost}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}