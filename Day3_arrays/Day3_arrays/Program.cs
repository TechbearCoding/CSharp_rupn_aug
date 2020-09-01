using System;

namespace Day3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = FillArr();

            PrintArr(arr);

            ClearArr(arr);

            PrintArr(arr);        
        }

        static void ClearArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }

        static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] FillArr()
        {
            int[] arr = new int[4];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            return arr;
        }
    }
}
