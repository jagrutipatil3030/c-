using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindrom_no
{
    class Program
    {
        static void Main(string[] args)
        {
          int num, temp, sum = 0, remnder;
          
            Console.WriteLine("enter the number ");
            num = Convert.ToInt16(Console.ReadLine());
            temp = num;
           while (num > 0)
         {
         
               remnder = num % 10;
              sum = (sum * 10) + remnder;
              num = num / 10;

        }
        
            if (temp == sum)
        {
            Console.WriteLine("Number is palindrom");
        }
        else
        {
            Console.WriteLine("number is not palindrom");
        }
             Console.ReadLine();
      }
        
  }
    
}
