using System;

namespace Day1_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample2(1,2);

            int a = 5;

            Sample2(6, a);


            int rez = Sample3();

            Console.WriteLine(rez);

            Console.WriteLine(Sample3());

            Sample2(a, Sample3());
        }

        static void Sample2(int number1, int number2)
        {
            Console.WriteLine("Summa ir " + (number1 + number2));
        }

        static int Sample3()
        {
            return 5+4;
        }

        static void Task2()
        {
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int number = Convert.ToInt32(Console.ReadLine());

                sum = sum + number;
            }

            Console.WriteLine(sum);
        }

        static void Task1()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number > 5)
            {
                Console.WriteLine("**");
            }
            else
            {
                Console.WriteLine("*");
            }
        }


        static void Sample()
        {
            Console.WriteLine("Hello World!");
            //int, string, double, float, bool, char
            int a = 5;
            Console.WriteLine("Skaitlis ir " + a);

            String input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);

            }
            catch
            {
                Console.WriteLine("nav ok");
            }

            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                
                int n = 4;
                sum = sum + n;
            }


        }
    }
}
