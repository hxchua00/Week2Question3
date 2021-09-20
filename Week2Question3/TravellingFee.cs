using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question3
{
    interface ITravellingFee
    {
        double CostPerKM();
        void TotalCost(double distance, double cost);
    }
}
