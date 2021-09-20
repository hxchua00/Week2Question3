using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            SecondClass sc = new SecondClass();
            ThirdClass tc = new ThirdClass();

            Console.WriteLine("Enter distance to travel (KM): ");
            double dist = double.Parse(Console.ReadLine());

            Console.WriteLine("What class you which to travel with?");
            Console.WriteLine("1) First Class");
            Console.WriteLine("2) Second Class");
            Console.WriteLine("3) Third Class");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double Fcost = fc.CostPerKM();
                    Console.WriteLine("You have chosen First Class!");
                    Console.WriteLine("Cost of travelling with First Class per KM is " + Fcost);
                    fc.TotalCost(dist, Fcost);
                    break;
                case 2:
                    double Scost = fc.CostPerKM();
                    Console.WriteLine("You have chosen Second Class!");
                    Console.WriteLine("Cost of travelling with First Class per KM is " + Scost);
                    sc.TotalCost(dist, Scost);
                    break;
                case 3:
                    double Tcost = fc.CostPerKM();
                    Console.WriteLine("You have chosen Third Class!");
                    Console.WriteLine("Cost of travelling with First Class per KM is " + Tcost);
                    tc.TotalCost(dist, Tcost);
                    break;
                default:
                    Console.WriteLine("No such class available!");
                    Console.WriteLine();
                    break;

            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using Han Airlines!");
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }
    }
}
