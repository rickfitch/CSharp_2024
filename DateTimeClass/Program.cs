namespace DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);

            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine("Tomorrow is {0}", DateTime.Today.AddDays(1).DayOfWeek);

            DateTime now = DateTime.Now;
            Console.WriteLine("it is {0} o'clock, {1} minutes and {2} seconds.", now.Hour, now.Minute, now.Second);

            Console.WriteLine("write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out DateTime date))
            {
                Console.WriteLine("date is: {0}", date);
                Console.WriteLine("time past: {0}",DateTime.Now.Subtract(date));
                TimeSpan timeSpan = now.Subtract(date);
                Console.WriteLine(timeSpan.Days.ToString());

            }
            else { Console.WriteLine("improper date"); }


            Console.ReadKey();
        }
    }
}
