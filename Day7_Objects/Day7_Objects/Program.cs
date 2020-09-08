using System;
using System.Collections.Generic;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample3();
        }

        static void Sample3()
        {
            List<Car> lstOfCars = new List<Car>();

            lstOfCars.Add(new Car("BMW", "M3", "White"));
            lstOfCars.Add(new Car("Audi", "A4", "Red"));

            for(int i = 0; i < lstOfCars.Count; i++)
            {
                lstOfCars[i].PrintInfo();
            }

            lstOfCars[0].color = "Black";

            foreach(Car car in lstOfCars)
            {
                car.PrintInfo();
            }
        }

        static void Sample2()
        {
            Console.WriteLine("Ievadiet vardu!");
            String name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            String lastName = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu!");
            int course = Convert.ToInt32(Console.ReadLine());

            Student st = new Student(name, lastName, course);

            st.PrintInfo();
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
