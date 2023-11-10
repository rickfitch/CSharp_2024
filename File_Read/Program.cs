using System.IO;
using System.Threading.Channels;
namespace File_Read
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //string text = System.IO.File.ReadAllText(@"C:\Users\rickf\Desktop\charp_text.txt");
           // Console.WriteLine(text);

           // file to array

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\rickf\Desktop\charp_text.txt");
            //foreach (string line in lines)
            //{
               // Console.WriteLine("\t" + line);
            //}

            // array to file

            string[] writtenLines = { "Line zero", "Line Two", "Line Three", "Line Four"};
            File.WriteAllLines(@"C:\Users\rickf\Desktop\csharp_text.txt", writtenLines);

            // write console input to file

            Console.WriteLine("Give a file name");
            string filename = Console.ReadLine();

            Console.WriteLine("Write your message");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\rickf\Desktop\" + filename + ".txt", input);


            Console.ReadKey();
        }
    }
}
