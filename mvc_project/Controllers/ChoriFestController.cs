using entity_library.Fest.Menu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Filter;
using mvc_project.Models.Fest;
using services_library.Fest.ChoriFest;
using services_library.System.User;
using System;
using System.Threading.Tasks;
using transversal_library.DTOs.Fest;
using transversal_library.Interfaces.ChoriFest.ChoriFest;
using transversal_library.Interfaces.System.User;

namespace mvc_project.Controllers

{

    [TypeFilter(typeof(ExceptionManegerFilter))]
    public class ChoriFestController : Controller
    {
        private readonly ILogger<ChoriFestController> _logger;
        private IChorifestService chorifestService = new ChorifestService();
        private IUserService userService = new UserService();

        public ChoriFestController(ILogger<ChoriFestController> logger)
        {
            _logger = logger;

        }

       
        public ActionResult Index()
        {
            var list = chorifestService.GetChorifestList();
          
            return View(list);
        }

        public ActionResult Details(int id)
        {
            return View();
        }



        public ActionResult Create()
        {
            var chori = new ChoriFestDTO() { menus= new System.Collections.Generic.List<MenuChorifest>()};
            var chorifest = new entity_library.Fest.Chorifest();
            var menuchori = new MenuChorifest();
            var menuchori2 = new MenuChorifest();

            chori.menus.Add(menuchori);
            chori.menus.Add(menuchori2);
            

            return View(chori);
        }


        
        public async Task<ActionResult> Post(ChorifestViewModel chorifest)
        {
            var response = await chorifestService.GetChorifestList();
            return View();
        }


       
        public async Task Save(ChoriFestDTO chorifestDto)
        {
             await chorifestService.Save(chorifestDto);
        }


    }
}
