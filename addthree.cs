using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace addthree
{
    class Program
    {
        int a, b, c, d;
        public void get()
        {
            Console.WriteLine("   Enter frist Number :-" + "\n");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("   Enter second Number :-" + "\n");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("   Enter Third Number :-" + "\n");
            c = Convert.ToInt16(Console.ReadLine());
        }
        public void add()
        {
            d = a + b + c;
            Console.WriteLine("Addition of Three number :-\n\n"+d);
        }
      
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.get();
            p1.add();
            Console.ReadLine();
        }
    }
}
