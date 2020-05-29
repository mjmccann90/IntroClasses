using System;

namespace IntroClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rule for declaring variables is what type of variable
            Car marksCar = new Car(2016, 85_000);

            marksCar.Color = "Black";
            marksCar.Make = "Toyota";
            marksCar.Model = "4Runner";

            Car adamsCar = new Car(2010, 5_000)
            {
                Make = "Mazda",
                Model = "3",
                Color = "Silver",
            };
        }
    }
}
