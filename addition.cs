using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
             int a,b,c;
       Console.WriteLine(" Enter Frist number ");
       a=Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine(" Enter Second Number ");
       b=Convert.ToInt32(Console.ReadLine());
       
       c = a+b;
       Console.WriteLine(" Additon of Given Two Number " + c);
       Console.ReadLine();
        }
    }
}
