namespace threading01
{
    internal class Program
    {
        static void WriteThreadID()
        {
            // This method is intended to be run in a separate thread
            Console.WriteLine($"Thread ID: {Environment.CurrentManagedThreadId}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Create a new thread to run the WriteThreadID method
            WriteThreadID();
            Thread thread01 = new Thread(WriteThreadID);
            thread01.Start();
            Console.ReadLine();
        }

       
    }
}
