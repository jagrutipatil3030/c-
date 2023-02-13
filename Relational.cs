using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Relational_O
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("\n\n_________________ Relational Operator ____________________\n\n\n");
          
            Console.WriteLine("Enter value for A :-" );
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value for b :-" );
            b = Convert.ToInt16(Console.ReadLine());
            bool c = (a < b);
            Console.WriteLine( " \nA Is less than B  : \n\n  "  + c);
             c = (a > b);
            Console.WriteLine( " \nA Is Grater than B :  \n\n  "  + c);
             c = (a == b);
            Console.WriteLine( " \nA Is  equal to B :  \n\n  "  + c);
            Console.ReadLine();
        }
    }
}
