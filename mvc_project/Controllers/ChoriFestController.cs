using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models.Fest;
using services_library.Fest.ChoriFest;
using System.Threading.Tasks;
using transversal_library.Interfaces.ChoriFest.ChoriFest;

namespace mvc_project.Controllers
{
    public class ChoriFestController : Controller
    {
        private readonly ILogger<ChoriFestController> _logger;
        private IChorifestService chorifestService = new ChorifestService();

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

            return View();
        }
        public async Task<ActionResult> Post(ChorifestViewModel chorifest)
        {
            var response = await chorifestService.GetChorifestList();
            return View();
        }


    }
}
