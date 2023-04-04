using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] jobs = { 100, 200, 300, 400 };
            Console.WriteLine("Select the jobs:\n1.Window\n2.Floor\n3.Bathroom\n4.Full House");
            int j=int.Parse(Console.ReadLine());
            int jb=jobs[j];
            Console.WriteLine("Enter the number of hours:");
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine("The Final amount will be:{0}", jb*h );
            Console.ReadKey();

        }
    }
}
