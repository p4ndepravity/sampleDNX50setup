using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Conditionals
    {
        public void conditional()
        {
            // if statement
            int first = 1;
            int second = 2;
            if(second > first)
            {
                Console.WriteLine("second is greater than first");
            }else
            {
                Console.WriteLine("second is not greater than first");
            }

            // shorthand conditional
            string value="";
            value = (second > first) ? "second > first" : "second <= first";
            Console.WriteLine(value);

            // switch statement
            int mycase = 2;
            switch (mycase)
            {
                case 1:
                    Console.WriteLine("mycase is 1");
                    break;
                case 2:
                    Console.WriteLine("mycase is 2");
                    break;
                default:
                    Console.WriteLine("mycase is not 1 or 2");
                    break;
            }

            // for loop
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            // for each loop
            int[] int_array = [1, 2, 3, 4, 5, 6, 7, 8];
            foreach(int item in int_array)
            {
                Console.WriteLine(item);
            }

            // while loop
            int f = 20;
            while (f < 20)
            {
                Console.WriteLine(f);
                f++;
            }

            // do while loop
            int d = 1;
            do
            {
                Console.WriteLine(d);
                d++;
            } while (d <= 60);

        }
    }
}
