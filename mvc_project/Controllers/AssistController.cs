using entity_library.System.Assist;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models.Common;
using services_library.System.Assist;
using System.Collections.Generic;
using transversal_library.DTOs.System.Assist;

namespace mvc_project.Controllers
{
    public class AssistController: Controller
    {
        
        private AssistServices assistService = new AssistServices();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }

        public ActionResult ListAssist(QueryGridModel query, int? idEvent)
        {

            List<Assist> list = new List<Assist>();

            //list.Add(new
            //{
            //    col1 = "columna 1",
            //    col2 = "columna 2",
            //    col3 = "columna 3"
            //});

            //list.Add(new
            //{
            //    col1 = "columna 1",
            //    col2 = "columna 2",
            //    col3 = "columna 3"
            //});
            //var listAssist = assistService.GetListAssistByEvent(query, idEvent);

            return Json(JsonReturn.SuccessWithInnerObject(new
            {
                draw = query.draw,
                recordsFiltered = 2,
                recordsTotal = 2,
                data = list
            }));
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
