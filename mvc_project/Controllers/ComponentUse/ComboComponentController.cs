using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;
using mvc_project.Models.ComponentUse;

namespace mvc_project.Controllers
{
    public class ComboComponentController : Controller
    {
        private readonly ILogger<ComboComponentController> _logger;

        public ComboComponentController(ILogger<ComboComponentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AutocompleteExample(PaginatedComboQueryModel request)
        {
            List<object> list = new List<object>();

            list.Add(new
            {
                id = 1,
                text = "Elemento 1"
            });

            list.Add(new
            {
                id = 2,
                text = "Elemento 2"
            });

            list.Add(new
            {
                id = 3,
                text = "Elemento 3"
            });
            
            return Json(JsonReturn.SuccessWithInnerObject(new
            {
                results = list,
                pagination = false
            }));
        }
    }
}
