using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovolovVS.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Atan(x) + y;
            double denominator = Math.Exp(y);

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}