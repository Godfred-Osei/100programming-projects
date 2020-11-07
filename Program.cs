using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFriends;
            double amountOfBill, percentageTip, actualTip, amountPerEach;
            Console.WriteLine("Welcome To Bill Calculator");
            Console.WriteLine("Enter the total bill:");
            amountOfBill  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of friends to split the bill:");
            numberOfFriends = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the percentage tip you would like to give:");
            percentageTip = Convert.ToInt32(Console.ReadLine());
            actualTip = percentageTip / 100.0;
            amountPerEach = ((actualTip * amountOfBill) + amountOfBill) / numberOfFriends;
            Console.WriteLine("Each person would pay GHC{0}", Math.Round(amountPerEach, 2));
            

        }
    }
}
