using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Tutoree.Controllers.DTO;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;


namespace Tutoree.Controllers
{
    [Route("/student")]
    public class StudentController : Controller
    {
        [HttpGet("searchtutor")]
        public IActionResult SearchTutor()
        {
            return View(Routers.SearchTutor.Page);
        }
    }
}
