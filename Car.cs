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

        // Classes are also refered to as blueprints

        private int _milesDriven;

        private int _milesAtLastService;
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
        // Methods begin similarly to props where the accessiblity is declared and what it returns when it is invoked

        // Does not return anything
        public void Drive(int miles)
        {
            _milesDriven += miles;
        }

        public int GetOdometer()
        {
            return _milesDriven;
        }

        public void Service()
        {
            _milesAtLastService = _milesDriven;
        }

        public int GetMaintenanceAtMileage()
        {
            return _milesAtLastService + 5_000;
        }

        // Constructor Method
        // Constructors don't have a return type and the name of the method is the same as the name of the class
        public Car(int year, int miles)
        {
            Year = year;
            _milesDriven = miles;
        }

        // Private fields will not be accessible outside of the car class.
        // Fields are similar to to props, but are by convention private and don't have a getter or setter.
        private int _milesDriven;
    }

}