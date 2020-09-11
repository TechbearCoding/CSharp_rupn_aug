using System;
using System.Collections.Generic;
using System.Linq;

namespace Day9_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lst = FileOperations.ReadList("Test.txt");

            List<String> newList = new List<String>();

            for(int i = lst.Count-1; i >= 0; i--)
            {
                newList.Add(lst[i]);
            }

            FileOperations.Write(newList, "new.txt");
            //FileOperations.Write(Enumerable.Reverse(lst).ToList(), "new.txt");


        }
    }
}
