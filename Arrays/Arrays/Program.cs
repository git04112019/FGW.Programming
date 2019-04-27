using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {   
        static void Main(string[] args)
        {
            int maxIndex = 10;    
            int[] arrayInt = new int[maxIndex]; /* n is an array of 10 integers */
            arrayInt[9] = 500;
            arrayInt[199] = 1000;
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < maxIndex; i++)
            {
                arrayInt[i] = i + 100;
            }

            arrayInt[4] = 300;


            /* output each array element's value */
            for (j = 0; j < maxIndex; j++)
            {
                Console.WriteLine("arrayInt[{0}] = {1}", j, arrayInt[j]);
            }
            Boolean[] boolArray;
            double[] doubleArray;
            char[] charArray;
            float[] floatArray;
            Console.ReadKey();

            //output each array element's value 
            foreach (int jdx in arrayInt)
            {
                int idx = jdx - 100;
                Console.WriteLine("Element[{0}] = {1}", idx, jdx);
            }
            
        }
    }
}
