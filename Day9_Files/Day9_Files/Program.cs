using System;
using System.Collections.Generic;

namespace Day9_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lst = new List<String> {"aa", "bb", "cc", "dd" };

            FileOperations.Write(lst, "Test.txt");

            FileOperations.Read("Test.txt");
        }
    }
}
