using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CourseProject.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProject.Controllers
{
    public class CsharpController : Controller
    {
        FirstClass myobject = new FirstClass();
        FirstClass myobject2;
        MyInterface myobject3 = new MyInterface();

        public CsharpController(FirstClass aobject)
        {
            aobject = myobject;
            myobject2 = new FirstClass(12, "first", 12.25);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var value = "";
            myobject.MyDouble = 12.95;
            myobject.MyString = "First String";
            myobject.MyInt = 12;

            myobject2.FirstInt();
            value = myobject2.FirstStringMethod("Hello First");
            myobject2.MyVoid();

            // my text
            myobject3.GetFirstMethod();
            // 25
            myobject3.PostSecondMethod();

            return View();
        }
    }
}
