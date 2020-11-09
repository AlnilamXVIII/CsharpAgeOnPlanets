using System;

namespace CsharpAgeOnPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            int earthAge;
            int jupiterYears = 12;
            double saturnYears = 29.4;
            int uranusYears = 84;
            int neptuneYears = 165;
            int plutoYears = 248;

            Console.WriteLine("Please enter your age in Earth years: ");

            //earthAge equal to what the user defines
            earthAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Earth age is: " + earthAge + "\n\n");

            double jupiterAge = earthAge / jupiterYears;
            Console.WriteLine("Your Jupiter age is: " + jupiterAge + "\n\n");

            double saturnAge = earthAge / saturnYears;
            Console.WriteLine("Your Saturn age is: " + saturnAge + "\n\n");

            double uranusAge = earthAge / uranusYears;
            Console.WriteLine("Your Uranus age is: " + uranusAge + "\n\n");

            double neptuneAge = earthAge / neptuneYears;
            Console.WriteLine("Your Neptune age is: " + neptuneAge + "\n\n");

            double plutoAge = earthAge / plutoYears;
            Console.WriteLine("Your Pluto age is: " + plutoAge + "\n\n");
            Console.ReadKey();
        }
    }
}
