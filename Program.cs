using System;

namespace Oop
{
    class Car
    {
        string colour = "red";
        int maxSpeed = 200;
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        //static void Main(string[] args)
        //{
        //    Car myObj = new Car();
        //    myObj.fullThrottle();  // Call the method
        //}

    }
    class Car1
    {
        string color;
        int maxSpeed;
        static void Main(string[] args)
        {
            Car1 myObj = new Car1();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }


    class Car3
    {
        string model;
        string color;
        int year;

        //static void Main(string[] args)
        //{
        //    Car3 Ford = new Car3();
        //    Ford.model = "Mustang";
        //    Ford.color = "red";
        //    Ford.year = 1969;

        //    Car3 Opel = new Car3();
        //    Opel.model = "Astra";
        //    Opel.color = "white";
        //    Opel.year = 2005;

        //    Console.WriteLine(Ford.model);
        //    Console.WriteLine(Opel.model);
        //}
    }
    class Car4
    {
        public string model;

        // Create a class constructor with a parameter
        public Car4(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car4 Ford = new Car4("Mustang");
            Console.WriteLine(Ford.model);
        }
    }

}
