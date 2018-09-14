using System;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Name :");
                int val1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lastname :");
                int val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Answer = " + (val1 + val2));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }

        }
    }
}
