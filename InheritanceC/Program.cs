namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Happy Birthday", true, "Rick Fitch");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Rick Fitch", true,"https://images.com/shoes");



            Console.WriteLine(imagePost1.ToString());
        }
    }
}
