using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class Car
    {
        public int Hp { get; set; }
        public string Color { get; set;}

        public Car(int hp, string color) 
        {
            Hp = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("the Hp is {0} and the color is {1} in Car class", Hp, Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired in Cars");
        }



        
    }
}
