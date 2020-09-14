using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9_homework
{
    class FileOperations
    {
        private const String defaultPath = @"C:\Users\Marti\Desktop\";
        private const String filename = "Test.txt";
        public static List<String> Read()
        {
            List<String> lstOfElements = new List<String>();
            try
            {

                StreamReader sr = new StreamReader(defaultPath + filename);

                String line = sr.ReadLine();

                while (line != null)
                {
                    lstOfElements.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

            return lstOfElements;
        }

        public static void Write(List<String> lst)
        {

            try
            {
                StreamWriter sw = new StreamWriter(defaultPath + filename);

                foreach (String el in lst)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
