using System.Security.Cryptography;

namespace class0616_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(5);

            s1[0] = "CCC";
            s1[1] = "BBB";
            s1[2] = "EEE";

            Console.WriteLine(s1[0]);
            Console.WriteLine(s1[1]);
            Console.WriteLine(s1[2]);
            Console.WriteLine(s1[3]);
            Console.WriteLine(s1[4]);
        }    
    }
}
