using System;
using System.Linq;
using System.Text;

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
            //double num1 = 5;
            //double num2 = 0;
            //try
            //{
            //    Console.WriteLine("5/0 ={0}",DOdivide(num1,num2));
            //}catch(DivideByZeroException ex) 
            //{
            //    Console.WriteLine("cant divide by zero ");
            //    Console.WriteLine(ex.Message);
            //}
            //finally { Console.WriteLine("Cleaning block");
            //}
            //StringBuilder sb = new StringBuilder("Random Text");
            //StringBuilder sb2 = new StringBuilder("More stuff is very imp", 256);
            //string str = "Prince";
            //Console.WriteLine(sb.ToString());
            //sb.Append(str);
            //sb.Clear();
            //Console.WriteLine(sb.ToString());
            int  num1 = 5;
            int num2  = 25;
            Console.WriteLine("Before Swap: {0} num2 : {1}",num1,num2);
            Swap(ref num1,ref num2);
            Console.WriteLine("after Swap: {0} num2 : {1}", num1, num2);
        }
        public static void Swap(ref int num1,ref int num2 )
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }
        static double GetSum(double x=1,double y=1) 
        {
            return (x + y);
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