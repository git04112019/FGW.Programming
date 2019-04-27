using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            int number = 0;
            int numberEnd = -1;
            while (number < numberEnd)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.Read();

            // Do loop
            number = 0;
            do
            {
                Console.WriteLine(number);
                number = number + 1;
            } while (number < 5);

            // For loop
            //number = 5;
            int start = 5;
            int stop = 0;
            for (int i = start; i > stop; i--)
                Console.WriteLine(i);

            int numberA = 5;
            while(numberA == 5)
            {
                Console.WriteLine("Display number");
            }

            Console.ReadLine();


        }
    }
}
