using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortNumber;
            int b = 20;
            double c = 20.9;
            char character = 'A';
            char numberInt = 'b';

            

            shortNumber = 10;
            b = 20 - shortNumber; // b  = 10
           
            b++; // b = 11;
            c = shortNumber + b;
            Console.WriteLine("shortNumber = {0}, b = {1}, c = {2}", shortNumber, b, c);
            Console.ReadLine();
        }
    }
}
