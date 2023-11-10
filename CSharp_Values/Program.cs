using System.Collections;
using System.Security.Cryptography.X509Certificates;


namespace CSharp_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            Student[] students = new Student[5];

            students[0] = new Student(1,"Clair", 90);
            students[1] = new Student(2,"Sam", 95);
            students[2] = new Student(3,"May", 87);
            students[3] = new Student(4,"Cindy", 98);
            students[4] = new Student(5,"Ralph", 90);

            foreach (Student s in students)
            {
                if (!hashtable.ContainsKey(s.Id))
                {
                    hashtable.Add(s.Id, s);
                    Console.WriteLine("Student {0} was added. Id {1}", s.Name, s.Id);
                }
                else
                {
                    Console.WriteLine("Duplicate Id");
                }
                
            }
            Console.WriteLine("\n");
            // Read from Hash Table
            foreach (DictionaryEntry entry in hashtable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
                Console.WriteLine("\n");
                
            }
            
            
            

        }
    }
}
