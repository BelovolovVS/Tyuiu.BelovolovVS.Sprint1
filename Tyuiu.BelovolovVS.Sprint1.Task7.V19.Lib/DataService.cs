using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovolovVS.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            double res = x - (7 * Math.Pow(x, 2)) / Math.Pow(x, 3) + Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
            return Math.Round(res, 3);
        }
    }
}