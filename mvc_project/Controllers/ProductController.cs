using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers
{
    public class ProductController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Create()
        {
            return View();
            //return Redirect("~/Panel/Dashboard");
        }

        

        public ActionResult Update(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return Redirect("~/Panel/Dashboard");
        }

        public ActionResult AddProduct()
        {

            return Redirect("~/Panel/Dashboard");
        }


    }
}
