using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Tutoree.Models;
using Tutoree.Controllers.DTO;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;
using Microsoft.AspNetCore.Http;
using System;

namespace Tutoree.Controllers
{

    [Route("/tutor")]
    public class TutorController : Controller
    {
        private readonly IAuthService AuthService;
        private readonly ITutorService TutorService;
        public TutorController(ITutorService TutorService, IAuthService AuthService)
        {  
            this.AuthService = AuthService;
            this.TutorService = TutorService;
        }

        [HttpGet("detail")]
        public IActionResult ViewDetail()
        {
            this.ViewData["logedIn"] = AuthController.LogedIn;
            return View(Routers.TutorDetails.Page);
        }
    }
}
