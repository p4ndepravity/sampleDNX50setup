using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class FirstClass
    {
        int myinteger;string mystring;double mydouble;char mychar;bool mybool;float myfloat;byte mybyte;

        public int MyInt { get; set; }
        public string MyString { get; set; }
        public double MyDouble { get; set; }

        public FirstClass()
        {

        }

        public FirstClass(int myint, string mystring, double mydouble)
        {
            myint = MyInt;
            mystring = MyString;
            mydouble = MyDouble;
        }

        public int FirstInt()
        {
            return MyInt;
        }

        public string FirstStringMethod(string mystring)
        {
            return mystring;
        }

        public void MyVoid()
        {
            Console.WriteLine("write to the console");
        }
    }
}
