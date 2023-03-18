using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tutoree.Auth;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;

namespace TutoreeServer.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        private readonly ITutorService TutorService;
        private readonly IStudentService StudentService;
        private readonly ILocationService LocationService;
        private readonly ISubjectService SubjectService;
        private readonly IMajorService MajorService;

        public HomeController(ITutorService tutorService, IStudentService studentService, ILocationService locationService, IMajorService majorService, ISubjectService subjectService)
        {
            this.StudentService = studentService;
            this.TutorService = tutorService;
            this.LocationService = locationService;
            this.MajorService = majorService;
            this.SubjectService = subjectService;
        }

        [HttpGet("")]
        public IActionResult Index(double max, string subjectId, string locationId, string message, string errorMessage, int pageIndex = 0, int pageSize = 12)
        {
            //var student = (Student)this.ViewData["student"];
            //var tutor = (Tutor)this.ViewData["tutor"];
            //if (student != null)
            //{
            //    return Redirect(Routers.Home.Link);

            var locations = this.LocationService.GetListLocation();
            var allLocation = new SelectListItem()
            {
                Value = "",
                Text = "All"
            };

            locations.Add(allLocation);
            this.ViewData["locations"] = new SelectList(locations);

            var subjects = this.SubjectService.GetListSubjects();
            var allSubject = new SelectListItem()
            {
                Value = "",
                Text = "All"
            };

            subjects.Add(allSubject);
            this.ViewData["Subjects"] = new SelectList(subjects);

            if (subjectId == null) subjectId = "";
            if (locationId == null) locationId = "";


            if (max == 0)
            {
                max = 99999;
                var query = $"?max={max}&locationId={locationId}&subjectId={subjectId}&message={message}&errorMessage={errorMessage}";
                return Redirect(Routers.Home.Link + query);
            }
            var (tutors, count) = this.TutorService.GetAllTutors(pageIndex, pageSize, subjectId, locationId);
            this.ViewData["tutors"] = tutors;
            this.ViewData["total"] = count;

            return View(Routers.Home.Page);
        }

        [HttpGet("/tutor")]
        public IActionResult TutorDetailsPage()
        {
            this.ViewData["logedIn"] = AuthController.LogedIn;
            return View(Routers.TutorDetails.Page);
        }

        [HttpGet("/home/stu")]
        public IActionResult Student()
        {
            AuthController.Role = "student";
            AuthController.LogedIn = true;
            this.ViewData["logedIn"] = AuthController.LogedIn;
            this.ViewData["role"] = AuthController.Role;
            return View(Routers.Home.Page);
        }

        [HttpGet("/home/tut")]
        public IActionResult Tutor()
        {
            AuthController.Role = "tutor";
            AuthController.LogedIn = true;
            this.ViewData["logedIn"] = AuthController.LogedIn;
            this.ViewData["role"] = AuthController.Role;
            return View(Routers.Home.Page);
        }

    }
}
