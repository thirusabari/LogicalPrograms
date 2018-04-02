using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_That_An_Ip_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Is That an Ip Address*/
            /*Given a string as input, create a program to evaluate whether or not it is a valid IPV4 Adress */
            /* A valid IP Adress should be in the form of: a.b.c.d where a,b,c and d are integer values ranging from 0 to 255 inclusive*/
            /* For Example*/
            /* 127.0.0.1 is valid*/
            /* 127.255.255.255 is valid */
            /* 257.0.0.1 is invalid */
            /* 255a.0.0.1 is invalid */
            /* 127.0.0.0.1 is invalid */
            Console.WriteLine("Is That an IP Addrees");
            Console.WriteLine("Enter your IPV4 Address");
            string address = Console.ReadLine();
            int IP = 0;

            // Going to find whether the given string contains only numbers
            string[] numbers = address.Split('.');
            for(int i = 0; i < numbers.Length; i++)
            {
                string n = numbers[i];
                int len = n.Length;
                int num = 0;
                foreach(char r in n)
                {
                    bool result = char.IsDigit(r);
                    if (result)
                    {
                        num++;
                    }
                }
                if (num == len)
                {
                    IP++;
                }
            }
            if (IP == numbers.Length && IP==4 && numbers.Length==4)
            {
                validIp(numbers);
            }
            else
            {
                Console.WriteLine("You have Entered an Invalid IP Address");
            }

            Console.ReadLine();

        }

        //Below method get Executed, if the string contains only numbers

        public static void validIp(string[] n)
        {
            int valid = 0;
            for(int v = 0; v < n.Length; v++)
            {
                int ad = Convert.ToInt32(n[v]);
                if (ad >= 0 && ad <= 255)
                {
                    valid++;
                }
            }
            if (valid == n.Length)
            {
                Console.WriteLine("You have Entered the Valid IP Address");
            }
            else
            {
                Console.WriteLine("You have Entered an Invalid IP Address");
            }
        }
    }
}
