using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers
{
    public class AssistController: Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddAssist()
        {

            return View();
        }

        public ActionResult Create()
        {
            return Redirect("~/Home/Index");
        }




        // GET: ProductController/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return Redirect("~/Panel/Dashboard");
        }

    }
}
