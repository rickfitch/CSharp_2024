using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    internal class Rectangle :Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double length, double width, double height)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
            Height = height;
        }

        public override double Volume()
        {
            return Length * Width * Height;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nT his {Name} has a length of {Length}, width of {Width}, height of {Height}.");
        }
    }
}
