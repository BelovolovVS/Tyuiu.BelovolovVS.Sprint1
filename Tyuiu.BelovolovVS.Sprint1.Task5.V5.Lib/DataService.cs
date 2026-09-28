using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovolovVS.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int temp = (int)(x * 10);
            return temp % 10;
        }
    }
}