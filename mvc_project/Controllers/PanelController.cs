using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using mvc_project.Models.Login;

namespace mvc_project.Controllers
{
    public class PanelController : Controller
    {
        private readonly ILogger<PanelController> _logger;

        public PanelController(ILogger<PanelController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LoginModel loginModel = HttpContext.Session.Get<LoginModel>(
                                "UsuarioLogueado");

            if(loginModel == null)
            {
                return Redirect("~/Home/Index");
            }

            return View();
        }
    }
}
