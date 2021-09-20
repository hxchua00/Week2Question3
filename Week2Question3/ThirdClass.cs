using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question3
{
    class ThirdClass :ITravellingFee
    {
        public double CostPerKM()
        {
            double cost = 1500.00;

            return cost;
        }

        public void TotalCost(double distance, double cost)
        {
            double totalcost = distance * cost;

            Console.WriteLine("Total cost for travelling with Third Class for " + distance + "KM is $" + totalcost);
        }
    }
}
