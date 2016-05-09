using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public interface Interface
    {
        string GetFirstMethod();
        int PostSecondMethod();
    }

    public class MyInterface : Interface
    {
        private string _myfirstvariable;
        private int _mysecondvariable;

        public MyInterface()
        {
            _myfirstvariable = "my text";
            _mysecondvariable = 25;
        }

        public string GetFirstMethod()
        {
            return _myfirstvariable;
        }

        public int PostSecondMethod()
        {
            return _mysecondvariable;
        }
    }
}
