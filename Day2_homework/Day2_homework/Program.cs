using System;

namespace Day2_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Ievadiet masiva indeksu " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


            int[] arr2 = new int[arr.Length + 1];

            for(int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }

            Console.WriteLine("Ievadiet masiva indeksu " + (arr2.Length-1) + ":");
            arr[arr2.Length - 1] = Convert.ToInt32(Console.ReadLine());

        }

  
    }
}
