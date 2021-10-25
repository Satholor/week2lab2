using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            int numCoupons; // initial number of coupons earned
            int remainingCoupons; // Coupons remaining after redemption.
            int numCandyBars; // Number of candy bars earned
            int numGumballs; // Number of Gumballs earned

            // Getting input from user
            Console.Write("How many coupons did you win? ");
            numCoupons = Int32.Parse(Console.ReadLine()); // Passing the user's input into the numCoupons variable.
            remainingCoupons = numCoupons;

            numCandyBars = numCoupons / 10; // Getting the number of candy bars
            remainingCoupons %= 10; // Getting the coupons left over
            numGumballs = remainingCoupons / 3; // Getting the number of gumballs
            remainingCoupons %= 3; // Finding how many tickets remain.
            // Outputting results to the user
            Console.WriteLine("For {0} Coupons you can get:\nCandy Bars: {1}\nGumballs: {2}\n" +
            "Coupons Remaining: {3}", numCoupons, numCandyBars, numGumballs, remainingCoupons);
        }
    }
}
