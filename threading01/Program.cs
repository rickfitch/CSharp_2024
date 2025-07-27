namespace threading01
{
    internal class Program
    {
        static void WriteThreadID()
        {
            // This method is intended to be run in a separate thread
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                // Simulate some work slows down the output
                Thread.Sleep(50);//priority is not guaranteed to be honored by the OS when
                                // running on a single core CPU.
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine($"Main Thread ID: {Environment.CurrentManagedThreadId}");
            
            Thread thread01 = new Thread(WriteThreadID);            
            Thread thread02 = new Thread(WriteThreadID);
            thread01.Name = "Thread 01";
            thread02.Name = "Thread 02";
            thread01.Priority = ThreadPriority.Highest;
            thread02.Priority = ThreadPriority.Lowest;
            Thread.CurrentThread.Priority = ThreadPriority.Normal;
            Thread.CurrentThread.Name = "Main Thread";

            // Start the threads
            // Create and start two additional threads. Not the main thread.
            thread01.Start();
            thread02.Start();
            WriteThreadID();//This runs in the main thread. 
            Console.ReadLine();
        }

       
    }
}
