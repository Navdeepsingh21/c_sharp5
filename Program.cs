using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int incre, num;

            //Reading number
            Console.WriteLine("Enter number to print table: ");
            num = int.Parse(Console.ReadLine());

            for (incre = 1; incre <= 12; incre++)
            {
                //Printing table of number entered by user            
                Console.WriteLine(num + "x" + incre + "=" + num * incre);
            }
            Console.ReadLine();

        }
    }
}

