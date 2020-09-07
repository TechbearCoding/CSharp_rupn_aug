﻿using System;
using System.Collections.Generic;

namespace Day5_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }


        static void Task2()
        {
            List<String> lst = new List<String>();

            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
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
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private static void AddElement(List<string> lst)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet elementu!");
            lst.Add(Console.ReadLine());
            Console.WriteLine();
        }

        private static void PrintLst(List<string> lst)
        {
            Console.WriteLine();

            if(lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            for(int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(i + ": " + lst[i]);
            }
            Console.WriteLine();
        }

        static void ListSample()
        {
            List<String> lst = new List<String>();

            lst.Add("aa");
            lst.Add("bb");

            for(int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            foreach(String value in lst)
            {
                Console.WriteLine(value);
            }
        }

        static void Task1()
        {
            String choice = "";

            while(choice != "exit")
            {
                Console.WriteLine("Ievadiet darbibu! : +,-,*,/ vai exit");
                choice = Console.ReadLine();

                double number1 = InputDouble(1);

                double number2 = InputDouble(2);

                switch (choice)
                {
                    case "+":
                        Console.WriteLine(Darbibas.Sum(number1, number2));
                        break;
                    case "-":
                        Console.WriteLine(Darbibas.Sub(number1, number2));
                        break;

                    case "*":
                        Console.WriteLine(Darbibas.Mul(number1, number2));
                        break;

                    case "/":
                        Console.WriteLine(Darbibas.Div(number1, number2));
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }
           

            }

            static double InputDouble(int number)
            {
                double result = 0;
                try
                {
                    Console.WriteLine("Ievadiet " +number+ ". skaitli!");
                    result = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    result = InputDouble(number);
                }

                return result;
            }

        }
    }
}
