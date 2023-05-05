using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace amonstrong
{
    class Program
    {
        int temp, no, r, sum=0;       

        public void get()
        {
            Console.WriteLine("enter number");
            no = Convert.ToInt16(Console.ReadLine());
                
        }
        public void show()
        {
            temp=no;
            while (no > 0)
            {
                r = no % 10;
                sum = sum + r * r * r;
                no = no / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("amstrong number");
            }
            else
            {
                Console.WriteLine("not amstrong number");

            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.get();
            p1.show();
        }
    }
}
v
