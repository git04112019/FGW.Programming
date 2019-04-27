using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number;

            Console.WriteLine("Please enter a number between 0 and 10:");
            number = int.Parse(Console.ReadLine());

            if (number > 10)
                Console.WriteLine("Hey! The number should be 10 or less!");
            else if (number < 0)
                Console.WriteLine("Hey! The number should be 0 or more!");
            else
                Console.WriteLine("Good job!");
                */
            int numberA = 10;
            int numberB = 20;
            int numberX;
            /*
            if (numberA == 0 && numberB == 0)
            {
                Console.WriteLine(" Infinite X");
            }
            else if (numberB == 0)
            {
                numberX = 0;
                Console.WriteLine(" X = {0}", numberX);
            }
            else if (numberA == 0)
            {
                Console.WriteLine(" There is no numberX");
            }
            else
            {
                numberX = -numberB / numberA;
                Console.WriteLine(" X = {0}", numberX);
            }
            */

            if (numberA == 0)
            {
                if (numberB == 0)
                {
                    Console.WriteLine(" Infinite X");
                }
                else
                {
                    numberX = 0;
                    Console.WriteLine(" X = {0}", numberX);
                }
            }
            else if (numberB == 0)
            {
                numberX = 0;
                Console.WriteLine(" X = {0}", numberX);
            }
            else
            {
                numberX = -numberB / numberA;
                Console.WriteLine(" X = {0}", numberX);
            }

            Console.ReadLine();
        }
    }
}
