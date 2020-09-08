using System;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1();
        }
        
        static void Sample1()
        {
            Car car1 = new Car("BMW", "M3", "White");
            car1.PrintInfo();

            Car c2 = new Car();
            c2.PrintInfo();
        }
    }
}
