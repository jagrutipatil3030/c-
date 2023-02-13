using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logical
{
    class Program
    {
        int a, b, c;
        void get()
        {
        Console.WriteLine("Enter the Value for A ");
        a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the Value for B");
        b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the Value for C ");
        c = Convert.ToInt16(Console.ReadLine());
        }
            void show()
        {
            if ((a > b) && (a > c))
          {
        
                Console.WriteLine(a + " Is Grater Value then " +  b  + " And " + c);
          
          }
        else
           {
              Console.WriteLine(a + " Is Samaller Value then " +  b  + " And " + c);
             // Console.ReadLine(); 
           }
            Console.ReadLine();

        }
        

        static void Main(string[] args)
        {
            Program p = new Program();
            p.get();
            p.show();
       }
    }
}
