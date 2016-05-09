using Microsoft.AspNet.Mvc;
using static CourseProject.Models.Static6;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProject.Controllers
{
    public class csharp6new : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            myfirststatic();
            return View();
        }
    }
}
