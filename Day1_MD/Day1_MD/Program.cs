using System;

namespace Day1_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //PosOrNeg(4);

            //Task 2
            /*if (IsPositive(4))
            {
                Console.WriteLine("Pozitivs");
            }
            else
            {
                Console.WriteLine("Negativs");
            }*/

            //Task 3

            //PrintSum(5);

            //Task 4
            //Console.WriteLine(Power(2,4));

        }

        private static int Power(int number, int pow)
        {
            int result = 1;

            for(int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }

        private static void PrintSum(int number)
        {
            if(number < 1)
            {
                Console.WriteLine("Cikls nav iespejams");
                return;
            }

            int sum = 0;

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                sum += inputNumber;
            }

            Console.WriteLine("Summa ir " + sum);
        }

        static void PosOrNeg(int number)
        {
            if(number > 0)
            {
                Console.WriteLine("Pozitivs");
            }
            else
            {
                Console.WriteLine("Negativs");
            }
        }

        static bool IsPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
