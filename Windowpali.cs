// by using window form 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no, rem, sum = 0, temp;
            no = Convert.ToInt16(Console.ReadLine());
            temp = no;
            while (no > 0)
            {
                rem = no % 10;
                sum = (sum * 10 )+ rem;
                no = no / 10;
            }
		
            if(temp==sum)
		     {
                 label2.Text = "Number is Palindrome";
		      }
		   else
		     {
			 label2.Text ="Number is not Pali";
		     }
            
        }
    }
}
