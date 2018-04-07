using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PronicNumbers
{
    class Program
    {
        //Pronic Numbers
        // If we find the square root of a pronic number and then round it to the lower integer, we wil get n
        // Pronic Number is a product of two consecutive integers
        // Pronic Numbers are expressed as n(n+1)
        static void Main(string[] args)
        {
            Console.WriteLine("Pronic Numbers");
            Console.WriteLine("Enter the Pronic Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            var result = Math.Sqrt(n);
            result = Math.Round(result);
            if (result*(result + 1) == n)
            {
                Console.WriteLine("You have Entered the Pronic Number = "+n);
            }
            else
            {
                Console.WriteLine("You have ENtered the non Pronic Number = "+n);
            }
            Console.ReadLine();
        }
    }
}
