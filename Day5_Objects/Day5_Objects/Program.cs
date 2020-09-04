using System;
using System.Collections.Generic;

namespace Day5_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            ListSample();
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
