using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class Audi:Car
    {
        private string Brand = "Audi";

        public string Model { get; set; }

        public Audi(int hp, string color, string model ):base( hp, color )
        {
            Model = model;            
        }

        public  void ShowDetails()
        {
            Console.WriteLine(Brand + " ", Hp + " " + Color  + "In Audi Class");

        }
        public override void Repair()
        {
            Console.WriteLine(Brand + " " + Model + " was repaired using override");
        }


    }
}
