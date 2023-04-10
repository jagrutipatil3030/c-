using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindromno
{
    class Program
    {
       
        int no,temp,rem,sum;
        public void get()
        {
            Console.WriteLine("enter the number");
            no = Convert.ToInt16(Console.ReadLine());
        }
        public void show()
        {
            temp = no;
            while (no > 0)
            {
                rem = no % 10;
                sum = (sum * 10) + rem;
                no = no / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("number is palindrom");

            }
            else
            {
                Console.WriteLine("number is not palindrom");
            }
            
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.get();
            p1.show();
            Console.ReadLine();
        }
    }
}
