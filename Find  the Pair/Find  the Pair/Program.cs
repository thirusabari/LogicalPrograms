using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find__the_Pair
{
    // Lets Consider the a hard coded Collection. The Array of numbers are [9,3,1,5,7,10]
    // You need to find if there exists a pair whose sum is equal to ther user's input.
    // If any pair(two numbers) in a collection is equal to the input value, return the value as true. Otherwise return as false
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 3, 1, 5, 7, 10 };
            int count = 0;
            Console.WriteLine("Find the Pair");
            Console.WriteLine("Enter the input value");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int j=0;j<numbers.Length;j++)
            {
                for (int i = j+1; i < numbers.Length; i++)
                {
                    if (numbers[i] + numbers[j] == input && count == 0)
                    {
                        Console.WriteLine("The two values are = "+numbers[j]+", "+numbers[i]);
                        count++;
                        Console.WriteLine(true);
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }
    }
}
