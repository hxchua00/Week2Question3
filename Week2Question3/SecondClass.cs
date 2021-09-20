using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question3
{
    class SecondClass : ITravellingFee
    {
        public double CostPerKM()
        {
            double cost = 3000.00;

            return cost;
        }

        public void TotalCost(double distance, double cost)
        {
            double totalcost = distance * cost;

            Console.WriteLine("Total cost for travelling with Second Class for " + distance + "KM is $" + totalcost);
        }
    }
}
