using System;

namespace Day3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] arr = { "aa", "bb","ccc", "aa"};

            //Console.WriteLine("Kopejais simbolu skaits ir " + GetStrLen(arr));

            int[] masivs = GenRandom(100);
            PrintArr(masivs);



        }

        private static int GetStrLen(string[] arr)
        {
            int len = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                len += arr[i].Length;
            }

            return len;
        }

        static int[] GenRandom(int len)
        {
            int[] a = new int[len];

            Random rand = new Random();

            for(int i = 0; i < len; i++)
            {
                a[i] = rand.Next(101);
            }

            return a;
        }

        static void ClearArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > 50)
                {
                    a[i] = 0;
                }
                
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
