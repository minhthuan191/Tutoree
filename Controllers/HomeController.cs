using Microsoft.AspNetCore.Mvc;
using Tutoree.Utils.Common;

namespace Tutoree.Controllers
{
    [Route("")]

    public class HomeController : Controller
    {


        public HomeController()
        {
           
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            
            return View(Routers.Login.Page);
        }

    }
}
