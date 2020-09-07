using System;

namespace Day6_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            Console.WriteLine("Ievadiet vardu!");
            st.Name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            st.LastName = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu!");
            st.Course = Convert.ToInt32(Console.ReadLine());

            st.PrintInfo();

        }

        static void Sample1()
        {
            Car car1 = new Car();
            car1.SetColor("Red");
            car1.brand = "Volkswagen";
            car1.model = "Jetta";

            Car car2 = new Car();
            car2.SetColor("White");
            car2.brand = "BMW";
            car2.model = "M3";

            Console.WriteLine(car2.GetColor() + " " + car2.brand);

            car1.PrintInfo();

            car2.PrintInfo();
        }
    }
}
