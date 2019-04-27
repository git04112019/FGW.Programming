using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        
        public static int FindMax(int num1, int num2)
        {
            // local variable of function declaration 
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        
        public static int sum2Numbers(int input1, int input2)
        {
            int result;
            result = input1 + input2;
            return result;
        }

        public static int generateNumber100()
        {
            return 100;
        }

        public static void GoodMorning()
        {
            Console.WriteLine("This is Monday, good morning everybody");
            Console.WriteLine("How are you today");
        }
        static void Main(string[] args)
        {           
            // local variable definition 
            int a = 100;
            int b = 200;
            int ret;
            
            //calling the FindMax method
            ret = FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();

            int number1 = -100;
            int number2 = 30;
            int sumNumber1Number2 = sum2Numbers(number1, number2);

            Console.WriteLine("Sum 2 numbers : {0}", sumNumber1Number2);

            GoodMorning();
            Console.ReadLine();

            int myNumber100 = generateNumber100();

        }
    }
}
