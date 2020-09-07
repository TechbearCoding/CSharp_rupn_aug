using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Objects
{
    class Car
    {
        private String _brand;
        public String brand 
        {
            get 
            {
                return _brand;
            }
            set 
            {
                if(value.Length > 10)
                {
                    _brand = "default";
                }
                else
                {
                    _brand = value;
                }
                
            } 
        }
        public String model { get; set; }
        private String color;

        public void SetColor(String localColor)
        {
            color = localColor;

        }

        public String GetColor()
        {
            return color;
        }

        public void Drive()
        {
            Console.WriteLine("Brum brum");
        }

        public void PrintInfo()
        {
            Console.WriteLine(color + " " + brand + " " + model);
        }
    }
}
