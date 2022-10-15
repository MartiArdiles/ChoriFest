using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using mvc_project.Models.Login;
using services_library.System.User;
using transversal_library.Interfaces.System.User;

namespace mvc_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService userService= new UserService();



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginAdmin()
        {
            LoginViewModel loginViewModel =
                new LoginViewModel
                {
                    isLogged = true,
                    message = ""
                };

            return View(loginViewModel);
        }


        public IActionResult Login(LoginModel loginModel)
        {
            LoginViewModel loginViewModel =
                new LoginViewModel();

            if (string.IsNullOrEmpty(loginModel.userName) ||
                string.IsNullOrEmpty(loginModel.password))
            {
                loginViewModel.isLogged = false;
                loginViewModel.message = "Debe ingresar un nombre de usuario o password";

                return View("~/Views/Home/LoginAdmin.cshtml", loginViewModel);
            }
            else
            {
                var login = userService.GetUser(loginModel.userName, loginModel.password);
                if (login)
                {
                    HttpContext.Session.Set<LoginModel>(
                               "UsuarioLogueado",
                               loginModel);

                    return Redirect("~/Panel/Dashboard");


                }
                else
                {
                    loginViewModel.isLogged = false;
                    loginViewModel.message = "Nombre de usuario o contraseña incorrecto";

                    return View("~/Views/Home/LoginAdmin.cshtml", loginViewModel);

                }

            }

            
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
