using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static double DOdivide(double x,double y)
        {
            if (y== 0) 
            {
                throw new System.DivideByZeroException();   
            }
            return x / y;
        }
        static void Main()
        {
            double num1 = 5;
            double num2 = 0;
            try
            {
                Console.WriteLine("5/0 ={0}",DOdivide(num1,num2));
            }catch(DivideByZeroException ex) 
            {
                Console.WriteLine("cant divide by zero ");
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Cleaning block"); }
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            int start = 0;
            int end = charArray.Length - 1;

            while (start < end)
            {
                // Swap characters
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;

                start++;
                end--;
            }

            return new string(charArray);
        }
    }
}