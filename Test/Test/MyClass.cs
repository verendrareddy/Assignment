using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class MyClass
    {
        public void Q1_Even_odd_Sum()
        {
            int[] arr = new int[6];
            int evenSum=0,oddSum=0;
            Console.WriteLine("Enter the values in the array");
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i]%2==0)
                {
                    evenSum = evenSum + arr[i];
                }
                else
                {
                    oddSum = oddSum + arr[i];
                }


            }
            Console.WriteLine("Even sum is {0}", evenSum);
            Console.WriteLine("Odd sum is {0}", oddSum);



        }

        public void Q2_Pattern()
        {
            int n;
            Console.WriteLine();
            Console.WriteLine("PATTERN");
            for(int i=1;i<=10;i++)
            {
               n = (i * i * i ) - 1;
                Console.WriteLine(n);
            }
        }
    }
}
