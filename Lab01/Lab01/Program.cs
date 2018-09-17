using System;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, s;
            double id, gpa;
            Console.WriteLine("Name");
            n = Console.ReadLine().ToString().ToUpper();
            Console.WriteLine("Last Name :");
            s = Console.ReadLine().ToString().ToUpper();
            Console.WriteLine("ID :");
            id = double.Parse(Console.ReadLine());
            Console.WriteLine("GPA :");
            gpa = double.Parse(Console.ReadLine());
        }
    }
}
