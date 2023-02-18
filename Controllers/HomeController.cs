using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;

namespace Tutoree.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        private readonly ITutorService TutorService;
        private readonly IStudentService StudentService;
        private readonly ILocationService LocationService;
        private readonly IMajorService MajorService;

        public HomeController(ITutorService tutorService, IStudentService studentService, ILocationService locationService, IMajorService majorService)
        {
            this.StudentService = studentService;
            this.TutorService = tutorService;
            this.LocationService = locationService;
            this.MajorService = majorService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var student = (Student)this.ViewData["student"];
            var tutor = (Tutor)this.ViewData["tutor"];
            if (student != null)
            {
                return Redirect(Routers.Home.Link);
               
            }
            if (tutor != null)
            {
                return Redirect(Routers.Home.Link);
            }

            var locations = this.LocationService.GetListLocation();
            var allCategory = new SelectListItem()
            {
                Value = "",
                Text = "All"
            };

            locations.Add(allCategory);
            this.ViewData["locations"] = new SelectList(locations);

            var majors = this.MajorService.GetListMajor();
            var allMajor = new SelectListItem()
            {
                Value = "",
                Text = "All"
            };

            majors.Add(allMajor);
            this.ViewData["majors"] = new SelectList(majors);
            return View(Routers.Login.Page);
        }

        [HttpGet("/home")]
        public IActionResult HomePage()
        {
            return View(Routers.Home.Page);
        }
    }
}
