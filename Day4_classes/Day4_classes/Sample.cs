using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_classes
{
    class Sample
    {
        //private un public
        public static int a = 0;
        private static int b = 0;
        public static void TestPrint()
        {
            Console.WriteLine("Hello world!");
            PrivatePrint();
        }

        private static void PrivatePrint()
        {
            Console.WriteLine("So visi neredz!");
        }
    }
}
