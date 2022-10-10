using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 50;
            bool c = true;

            Console.WriteLine("Please, enter two digits, and my program will compare them !");
            Console.WriteLine("Enter first digit:");
            a = int.Parse(Console.ReadLine());          // 3
            Console.WriteLine("Enter second digit:");
            b = int.Parse(Console.ReadLine());          // 3
            
            

            if (a > b)
            {
                Console.WriteLine("Your first number is larger : {0}, and {1} is smaller", a, b);
            }
            else {
                if (a == b) 
                {
                    Console.WriteLine("Your numbers are equal");

                }
                else
                {
                    // Console.WriteLine("Your second number is larger : {0}, and {1} is smaller", b, a);
                    Console.WriteLine("Your second number is larger : " +  b );
                    
                }
            }


            string abv = "neshto" + 5; // "neshto5"
            Console.WriteLine(abv);        

        }
    }
}
