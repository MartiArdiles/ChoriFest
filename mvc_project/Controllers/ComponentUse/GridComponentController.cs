using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;

namespace mvc_project.Controllers
{
    public class GridComponentController : Controller
    {
        private readonly ILogger<GridComponentController> _logger;

        public GridComponentController(ILogger<GridComponentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GridExample(QueryGridModel queryGridModel)
        {
            List<object> list = new List<object>();
            
            list.Add(new 
            {
                col1 = "columna 1",
                col2 = "columna 2",
                col3 = "columna 3"
            });

            list.Add(new 
            {
                col1 = "columna 1",
                col2 = "columna 2",
                col3 = "columna 3"
            });

            return Json(JsonReturn.SuccessWithInnerObject(new
            {
                draw = queryGridModel.draw,
                recordsFiltered = 2,
                recordsTotal = 2,
                data = list
            }));
        }
    }
}
