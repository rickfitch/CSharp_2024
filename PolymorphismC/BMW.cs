using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class BMW: Car
    {
        private string Brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model): base(hp, color)
        {
            Model = model;            
        }

        public new void ShowDetails()
        {
            Console.WriteLine(Brand + " " + Hp + " " + Color + " In BMW class");

        }
        public override void Repair()
        {
            Console.WriteLine(Brand + " " + Model + " was repaired using override");
        }


    }
}
