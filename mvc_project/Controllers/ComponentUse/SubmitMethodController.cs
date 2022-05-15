using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Common;
using mvc_project.Models.ComponentUse;

namespace mvc_project.Controllers
{
    public class SubmitMethodController : Controller
    {
        private readonly ILogger<SubmitMethodController> _logger;

        public SubmitMethodController(ILogger<SubmitMethodController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            TestSubmitModel testSubmitModel = null;

            if(id != 0)
            {
                testSubmitModel = new TestSubmitModel
                {
                    id = id,
                    name = "Juan",
                    surname = "Perez"
                };
            }
            else
            {
                testSubmitModel = new TestSubmitModel
                {
                    id = 0,
                    name = "",
                    surname = ""
                };
            }

            return View(testSubmitModel);
        }

        public IActionResult Submit(TestSubmitModel testSubmitModel)
        {
            //Guardo en la BD
            
            return Redirect("~/Home/Index");
        }
    }
}
