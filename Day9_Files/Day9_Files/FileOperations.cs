using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day8_FileIO
{
    class FileOperations
    {   
        private const String defaultPath  = @"C:\Users\Marti\Desktop\";
        public static void Read(String filename)
        {
            try
            {
                
                StreamReader sr = new StreamReader(defaultPath + filename);

                String line = sr.ReadLine();

                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }
        }
        public static void Write()
        {

            try
            {
                StreamWriter sw = new StreamWriter(defaultPath + "Test.txt", true);
                sw.WriteLine("Hello ");
                sw.WriteLine("world!");

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
