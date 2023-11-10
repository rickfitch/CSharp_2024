namespace AbstractClassesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Sphere(4), new Cube(5), new Rectangle(4, 6, 2)};

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("This {0} has a volume of {1}", shape.Name, shape.Volume());
            }




          /*  Cube cube1 = new Cube(10);   changed to a list
            Cube cube2 = new Cube(-3.5);
            cube1.GetInfo();
            cube2.GetInfo();
            Sphere sphere1 = new Sphere(10);
            sphere1.GetInfo();
          */


            Console.ReadKey(); 
        }
    }
}
