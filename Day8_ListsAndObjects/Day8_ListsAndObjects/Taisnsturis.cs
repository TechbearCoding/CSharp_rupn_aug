using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_ListsAndObjects
{
    class Taisnsturis
    {
        public double Width { get; set; }
        public double Height{ get; set; }

        public Taisnsturis(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
