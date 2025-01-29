namespace Class_And_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //Person p1 = new Person();
            //p1.firstName = "Hamza";
            //p1.lastName = "Yousuf";
            //p1.age = 20;
            //Console.WriteLine(p1.GetFullName());

            Car car1 = new Car();
            car1.Enter_Details("Honda Civic", "Honda", 2025);
            car1.details();
        }
    }

    //class Person
    //{

    //    public string firstName;
    //    public string lastName;
    //    public int age;

    //    public string GetFullName()
    //    {
    //        return $"Your full name is {this.firstName} {this.lastName} and age is {this.age}";
    //    }
    //}



    class Car
    {
        public string model;
        public string make;
        public int year;

        public void details()
        {
            Console.WriteLine($"your car details are {this.model} {this.make} {this.year}");
        }

        public void Enter_Details(string model, string make, int year)
        {
            this.model = model;
            this.make = make;
            this.year = year;
        }
    }




}
