using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    internal class Sphere :Shape
    {
        public double Radius { get; set; }
        

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;  
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 3) * 4/3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThis {Name} has a radius of {Radius} meters");
        }
    }
}
