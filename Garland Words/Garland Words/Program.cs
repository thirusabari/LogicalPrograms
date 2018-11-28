using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garland_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your garland words");
            string word = Console.ReadLine();
            char[] c = word.ToCharArray();
            string temp = string.Empty;
            var garlandDegree = 0;
            foreach (char c1 in c)
            {
                temp = temp + c1;
                if(temp==word[word.Length-1].ToString() && garlandDegree==0){
                    garlandDegree = temp.Length;
                }
                int N = temp.Length;
                if (N == 2)
                {
                    Console.WriteLine(N);
                    Console.WriteLine(word.Length - 1);
                    Console.WriteLine(word.Substring(N, word.Length-N));
                    string deg = word.Substring(N,word.Length-N);
                    for (int d = deg.Length - 1; d >= 0; d++)
                    {
                        
                        string r = string.Empty;


                    }
                    char[] reverse = deg.ToCharArray();
                    Array.Reverse(reverse);
                    Console.WriteLine("The Reversed String is= ",reverse);
                }
                
            }
            Console.WriteLine(garlandDegree);
            Console.ReadLine();

        }
    }
}
