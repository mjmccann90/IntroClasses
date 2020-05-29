using System;

namespace IntroClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rule for declaring variables is what type of variable
            Car marksCar = new Car();

            //marksCar.Color = "Black";
            marksCar.Make = "Toyota";
            marksCar.Model = "4Runner";
            marksCar.Year = 2016;

            Console.WriteLine(marksCar.Description);
        }
    }
}
