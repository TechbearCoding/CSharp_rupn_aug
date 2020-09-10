using System;
using System.Collections.Generic;

namespace Day8_ListsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            List<Taisnsturis> lst = new List<Taisnsturis>();

            for(int i = 0; i < 10; i++)
            {
                double len = 0;
                double height = 0;
                try
                {
                    Console.WriteLine("ievadiet garumu!");
                    len = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("ievadiet augustumu!");
                    height = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nepareiza ievade");
                    continue;
                }

                if(height > 0 && len > 0)
                {
                    lst.Add(new Taisnsturis(len, height));
                }

            }


            foreach(Taisnsturis t in lst)
            {
                Console.WriteLine(t.GetArea());
            }
            Console.WriteLine("Elementu skaits- " + lst.Count);

        }

        

    }
}
