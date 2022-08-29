using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers
{
    public class ChoriFestController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

   
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        
    }
}
