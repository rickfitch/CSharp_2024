namespace Delegates
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);


        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 24};
            Person p2 = new Person() { Name = "Sue", Age = 66};
            Person p3 = new Person() { Name = "Parker", Age = 40};
            Person p4 = new Person() { Name = "Trevor", Age = 36};

            List<Person> people = new List<Person>() {p1, p2, p3, p4};


            Console.ReadKey();
        }
    }
}
