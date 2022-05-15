using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;
using mvc_project.Models.ComponentUse;

namespace mvc_project.Controllers
{
    public class AjaxComponentController : Controller
    {
        private readonly ILogger<AjaxComponentController> _logger;

        public AjaxComponentController(ILogger<AjaxComponentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxExample(TestAjaxModel testAjaxModel)
        {
            if(testAjaxModel.id == 1)
            {
                List<string> lista = new List<string>();

                lista.Add(" - Mensaje 1");
                lista.Add(" - Mensaje 2");
                lista.Add(" - Mensaje 3");

                return Json(JsonReturn.ErrorWithListMessage("Error", lista));
            } 
            else if(testAjaxModel.id == 2)
            {
                return Json(JsonReturn.ErrorWithSimpleMessage("Esto es un error"));
            }
            else if(testAjaxModel.id == 3)
            {
                return Json(JsonReturn.Redirect(""));
            }
            else if(testAjaxModel.id == 4)
            {
                return Json(JsonReturn.SuccessWithInnerObject(new
                {
                    str = "Algo",
                    numeroEntero = 1,
                    numeroFlotante = 1.5,
                    booleano = true
                }));
            }
            else
            {
                return Json(JsonReturn.SuccessWithoutInnerObject());
            }
        }
    }
}
