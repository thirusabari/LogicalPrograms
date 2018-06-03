using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbor_Numbers
{
    // Given two strings as input, write a program to find which numbers from the first string are present
    // in the second string. Print the result as as string containing the matched numbers in ascending order.
    // For Example, Consider the first string should be, "12,13,15,19,212,556,2146"
    // Consider the second string should be, "13,44,432,12,788,246,2146,46"
    // The output will be, "12,13,2146"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neigbhor Numbers");
            Console.WriteLine("Enter the First String");
            string word1 = Console.ReadLine();
            //Splitting of Given String by comma
            string[] spl = word1.Split(',');
            int[] num1=new int[spl.Length];
            // Converting the string array into integer array
            for (int i = 0; i < spl.Length; i++)
            {
                num1[i] = int.Parse(spl[i]);
            }

            //Enter the Second String
            Console.WriteLine("Enter the Second String");
            string word2 = Console.ReadLine();
            string[] sp2 = word2.Split(',');
            int[] num2 = new int[sp2.Length];
            // Converting the string array into integer array
            for (int j = 0; j < sp2.Length; j++)
            {
                num2[j] = int.Parse(sp2[j]);
            }

            string output = string.Empty;
            // Comparing two strings
            for(int i=0;i<spl.Length; i++)
            {
                for (int j=0;j<sp2.Length;j++)
                {
                    if (spl[i] == sp2[j])
                    {
                            output = output + spl[i].ToString()+",";
                    }
                }
            }
            
            //The Neigbhor Numbers calculation
            int L = output.LastIndexOf(",");
            string neigbhor = output.Substring(0, L);
            Console.WriteLine("The Neigbhor numbers are = " +neigbhor);
            Console.ReadLine();
        }
    }
}
