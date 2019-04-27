using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();
            int age = Int32.Parse(input);
            Console.WriteLine("Hi {0}, age: {1}", name, age);
            Console.Read();

            
        }
    }
}
