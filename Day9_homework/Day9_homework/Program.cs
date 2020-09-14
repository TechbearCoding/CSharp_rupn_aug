using System;
using System.Collections.Generic;

namespace Day9_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();
        }

        static void Task4()
        {
            List<String> lst = FileOperations.Read();

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
                        PrintLst(lst);
                        break;
                    case "2":
                        AddElement(lst);
                        break;
                    case "3":
                        RemoveElement(lst);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private static void PrintLst(List<string> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(i + ": " + lst[i]);
            }
            Console.WriteLine();
        }
        private static void RemoveElement(List<string> lst)
        {
            Console.WriteLine();

            PrintLst(lst);

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            try
            {
                Console.WriteLine("Kuru elementu velaties dzest?");
                int toDelete = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(toDelete);
                FileOperations.Write(lst);
            }
            catch
            {
                Console.WriteLine("Kludaina ievade!");
            }


            Console.WriteLine();
        }

        private static void AddElement(List<string> lst)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet elementu!");
            lst.Add(Console.ReadLine());
            FileOperations.Write(lst);
            Console.WriteLine();
        }
    }
}
