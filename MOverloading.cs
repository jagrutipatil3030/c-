using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOverloading
{
    class Program
    {
        public void get(int a, int b)
        {

            Console.WriteLine("Value of a is : " + a);
            Console.WriteLine("Value of b is : " + b);

        }
        public void get(int a, int b, int c)
        {
            
            Console.WriteLine("Addition of Two number " + c);
        }
        static void Main(string[] args)
        {
            int a, b,c; 

            Console.WriteLine("Enter the First number");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the First number");
            b = Convert.ToInt16(Console.ReadLine());

            c = a + b;

            Program p = new Program();
            
            p.get(a, b);
            p.get(a, b, c);
            
            Console.ReadLine();

        }
    }
}
