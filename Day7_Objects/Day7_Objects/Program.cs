using System;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample2();
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
