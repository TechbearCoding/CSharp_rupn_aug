using System;
using System.Collections.Generic;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework();
        }

        static void Homework()
        {
            List<Student> lstOfStudents = new List<Student>();


            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
                Console.WriteLine("3- Dzest");
                Console.WriteLine("0- Iziet");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintLst(lstOfStudents);
                        break;
                    case "2":
                        AddElement(lstOfStudents);
                        break;
                    case "3":
                        RemoveElement(lstOfStudents);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }

            static void Task2()
            {
                List<Student> lstOfStudents = new List<Student>();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ievadiet vardu!");
                    String name = Console.ReadLine();

                    Console.WriteLine("Ievadiet uzvardu!");
                    String lastName = Console.ReadLine();


                    Console.WriteLine("Ievadiet kursu!");
                    int course = Convert.ToInt32(Console.ReadLine());

                    lstOfStudents.Add(new Student(name, lastName, course));
                }

                foreach (Student st in lstOfStudents)
                {
                    st.PrintInfo();
                }
            }
            static void Sample3()
            {
                List<Car> lstOfCars = new List<Car>();

                lstOfCars.Add(new Car("BMW", "M3", "White"));
                lstOfCars.Add(new Car("Audi", "A4", "Red"));

                for (int i = 0; i < lstOfCars.Count; i++)
                {
                    lstOfCars[i].PrintInfo();
                }

                lstOfCars[0].color = "Black";

                foreach (Car car in lstOfCars)
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

        private static void RemoveElement(List<Student> lstOfStudents)
        {
            Console.WriteLine();

            PrintLst(lstOfStudents);

            if (lstOfStudents.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            try
            {
                Console.WriteLine("Kuru elementu velaties dzest?");
                int toDelete = Convert.ToInt32(Console.ReadLine());
                lstOfStudents.RemoveAt(toDelete);
            }
            catch
            {
                Console.WriteLine("Kludaina ievade!");
            }


            Console.WriteLine();
        }

        private static void AddElement(List<Student> lstOfStudents)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet vardu!");
            String name = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            String lastName = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu!");
            int course = 0;
            try
            {
                course = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nav pareiza ievade, jaievada skaitlis no 1-3");
                return;
            }

            lstOfStudents.Add(new Student(name, lastName, course));

            Console.WriteLine();

        }

        private static void PrintLst(List<Student> lstOfStudents)
        {
            Console.WriteLine();

            if(lstOfStudents.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss");
                Console.WriteLine();
                return;
            }

            for(int i = 0; i < lstOfStudents.Count; i++)
            {
                Console.WriteLine(i + ": " + lstOfStudents[i].Name + " "
                    + lstOfStudents[i].LastName + " " + lstOfStudents[i].Course);
            }

            Console.WriteLine();
        }
    }
}
