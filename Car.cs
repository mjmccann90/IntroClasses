namespace IntroClasses
{

    public class Car
    {
        // string is the data type

        // get means that users can access this prop

        // set mean that users can assign to it

        // if there is not a set the user can never set the prop only get the prop. Only a read only prop.

        // it will be rare that that there will rarely be only a set

        // public refers to who can view the prop. it can univerially viewed 

        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        // Description would be considered a computed prop. There typically not a reason to set computed props. Logic can be added to the computed prop
        public string Description
        {
            get
            {
                return $"A {Year} {Color} {Make} {Model}";
            }
        }

        // Private fields will not be accessible outside of the car class. 
        private int _milesDriven;


    }

}