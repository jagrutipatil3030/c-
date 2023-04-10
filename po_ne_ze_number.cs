using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace po_ne_ze_number
{
    class Program
    {
        int no;
        public void get()
        {
            Console.WriteLine("enter the number");
            no = Convert.ToInt16(Console.ReadLine());
            if (no > 0)
            {
                Console.WriteLine("number is posotive");
            }
            else if (no < 0)
            {
                Console.WriteLine("number is negative");
            }
            else if(no==0)
            {
                Console.WriteLine("number is zero");
            }
        }
        static void Main(string[] args)
        {
            Program p11 = new Program();
            p11.get();
            Console.ReadLine();
        }
    }
}
