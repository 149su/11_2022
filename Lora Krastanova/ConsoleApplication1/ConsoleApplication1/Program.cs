using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  int a = 13;
                int b = 777;
            if (a<b && (a-10)<b)
            {
                Console.WriteLine("Inside my IF statement");
           }*/

          /*  int a =126656;
            int b = 554168;
                    bool c = true ;*/





            Console.WriteLine("Pleas, enter two digits, and my program will compare them");
            Console.WriteLine("Enter first digit:");
         int a= int.Parse ( Console.ReadLine());
         Console.WriteLine("Enter second digit:");
        int  b= int.Parse(Console.ReadLine());
            if (a>b)
            {
               
               
                Console.WriteLine("your first digit is larger: {0} , and {1} is smaller ", a, b);
            }

           else {
               if (a == b)
               {
                   Console.WriteLine("Your numbers are equal");

               }
               else
               {
                   Console.WriteLine("your second digit is larger: {0} , and {1} is smaller ", b, a);

               } 

               /* string abv = "something" + b;
                Console.WriteLine(abv);*/



            }
        }
    }
}
