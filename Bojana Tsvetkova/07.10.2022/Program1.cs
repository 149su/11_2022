using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in your first number: ");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in your second number: ");
            int b;
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                
                Console.WriteLine("The first number is larger: {0}  ", a);
                
                
            }
                

            else
            {
                if (a == b)
                {
                    Console.WriteLine("Your numbers are equal. ");
                    Console.WriteLine("Your second number is larger: " + b);
                }
                Console.WriteLine("The second number is larger: {0} ", b);
            }
            string abv = "neshto " + 5;
            
            Console.ReadKey();
           
        }
    }
}
