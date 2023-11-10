namespace EnumerationC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> mylist = new List<int>() {1,2,3,4,5,6};
            int[] myArray = new int[] {99,98,96,95,94,93};

            CollectionSum(mylist);
            CollectionSum(myArray);


        }
        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach (int item in anyCollection)
            {
                sum += item;

            }
            Console.WriteLine("the sum total is {0}", sum);
            Console.WriteLine(anyCollection.Average());
        }
    }
}
