using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Objects
{
    class Car
    {
        public String brand;
        public String model;
        public String color;

        public void Drive()
        {
            Console.WriteLine("Brum brum");
        }

        public void PrintInfo()
        {
            Console.WriteLine(color + " " + brand + " " + model);
        }
    }
}
