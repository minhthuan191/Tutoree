using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Tutoree.Controllers.DTO;
using Tutoree.Models;
using Tutoree.Service;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;


namespace Tutoree.Controllers
{
    [Route("/student")]
    public class StudentController : Controller
    {
        private LocationService LocationService;

        public StudentController(LocationService locationService)
        {
            LocationService = locationService;
        }

        [HttpGet("searchtutor")]
        public IActionResult SearchTutor()
        {
            ViewData["role"] = AuthController.Role;
            ViewData["logedIn"] = AuthController.LogedIn;
            ViewBag.LocationList = LocationService.GetAllLocations();
            return View(Routers.SearchTutor.Page);
        }
    }
}
