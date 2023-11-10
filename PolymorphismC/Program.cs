namespace PolymorphismC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>//generic list
            {
                new Audi(200, "RED", "A4"),
                new BMW(250, "BLUE", "Z3") 
            };                   

            foreach(var car in cars)
            {
                car.Repair();
                car.ShowDetails();
            }
            BMW bmwMS =new BMW(330, "white", "M5");// uses BMW details

            bmwMS.ShowDetails();
            Car car2 = bmwMS;// uses Car show details
            car2.ShowDetails();

            Console.ReadKey();
           
        }
        
    }
}
