
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Tutoree.Models;
using Tutoree.Service;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;

namespace TutoreeServer.Controllers
{
    [Route("/auth")]
    public class AuthController : Controller
    {
        public static Boolean LogedIn = false;

        public static string Role = "Guest";

        private readonly IAuthService AuthService;

        private readonly ILocationService LocationService;

        private readonly EffortlessService EffortlessService;

        private readonly IMajorService MajorService;

        public AuthController(IAuthService authService, ILocationService locationService, EffortlessService effortlessService, IMajorService majorService)
        {
            AuthService = authService;
            LocationService = locationService;
            EffortlessService = effortlessService;
            MajorService = majorService;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            var user = (Student)this.ViewData["student"];
            if (user != null)
            {
                return Redirect(Routers.Home.Link);
            }
            AuthController.LogedIn = true;
            return View(Routers.Login.Page);
        }

        [HttpGet("login/tutor")]
        public IActionResult LoginTutor()
        {
            var user = (Tutor)this.ViewData["tutor"];
            if (user != null)
            {
                return Redirect(Routers.Home.Link);
            }
            return View(Routers.Login.Page);
        }


        [HttpGet("register")]
        public IActionResult Register()
        {
            var user = (Student)ViewData["student"];
            if (user != null)
            {
                return Redirect(Routers.Home.Link);
            }

            ViewBag.LocationList = this.LocationService.GetAllLocations();
            ViewBag.SchoolYearList = this.EffortlessService.GetAllSchoolYear();
            ViewBag.MajorList = this.MajorService.GetAllMajors();
            return View(Routers.Register.Page);
        }

        [HttpGet("register/tutor")]
        public IActionResult RegisterShop()
        {
            var user = (Tutor)this.ViewData["tutor"];
            if (user != null)
            {
                return Redirect(Routers.Home.Link);
            }
            return View(Routers.Register.Page);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {

            // this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            // {
            //     Expires = DateTime.Now.AddDays(-1),
            //     SameSite = SameSiteMode.None,
            //     Secure = true

            // });
            // this.HttpContext.Session.Clear();
            // return Redirect(Routers.Login.Link + "?message=logout success");
            AuthController.Role = null;
            AuthController.LogedIn = false;
            this.ViewData["role"] = AuthController.Role;
            this.ViewData["logedIn"] = AuthController.LogedIn;
            return View(Routers.Login.Page);
        }



    }
}
