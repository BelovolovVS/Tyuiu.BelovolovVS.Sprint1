using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovolovVS.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double priceNotebook, int amountNotebook, double pricePencil, int amountPencil)
        {
            double total = (priceNotebook * amountNotebook) + (pricePencil * amountPencil);
            
            return Math.Round(total, 3);
        }
    }
}