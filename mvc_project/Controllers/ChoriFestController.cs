using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers
{
    public class ChoriFestController : Controller
    {
        // GET: ChoriFestController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChoriFestController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChoriFestController1/Create
        public ActionResult Create()
        {
            return View();
        }

        
    }
}
