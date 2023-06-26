using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReverseStr { 
        public static void revsestr()
        {
            string[] arr = { "Prince", "Gupta" };

            // Reverse each string in the array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ReverseString(arr[i]);
            }

            // Output the reversed array
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
        }

        static string ReverseString(string str)
        {
            char[] charArray = new char[str.Length];

            // Reverse the characters in the string
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                charArray[i] = str[j];
            }

            return new string(charArray);
        }
    }

}
