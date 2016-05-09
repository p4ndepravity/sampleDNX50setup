using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Arrays
    {
        double[] mydouble = new double[10];

        double[] mydouble2 = { 240.25, 225.25, 100.50, 50.50 };

        public void mymethod()
        {
            foreach (var item in mydouble2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
