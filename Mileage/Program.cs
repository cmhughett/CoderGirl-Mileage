using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("How many miles have you driven? ");

            // Get input from the user and save it to a variable.
            string milesInput = Console.ReadLine();
            int miles = Convert.ToInt32(milesInput);

            Console.Write("How many gallons of gas have you consumed? ");

            // Get input from the user and save it to a second variable.
            string gasInput = Console.ReadLine();
            int gas = Convert.ToInt32(gasInput);

            // Output - Your miles per gallon is (computed value)
            int gasMiles = miles / gas;
            Console.WriteLine($"You miles per gallon is " + gasMiles);

            Console.ReadLine();
        }
    }
}
