using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Tutoree.Controllers.DTO;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;
using static Tutoree.Controllers.DTO.RegisterDTO;
using static Tutoree.Controllers.DTO.RegisterTutorDTO;

namespace Tutoree.Controllers
{
    [Route("/api/auth")]
    [ApiController]
    public class AuthApiController : Controller
    {
        private readonly IAuthService AuthService;
        private readonly IStudentService StudentService;
        private readonly ITutorService TutorService;

        public AuthApiController(IAuthService authService, IStudentService StudentService, ITutorService TutorService)
        {
            this.AuthService = authService;
            this.StudentService = StudentService;
            this.TutorService = TutorService;
        }

        [HttpPost("login")]
        public IActionResult HandleLogin([FromBody] LoginDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new LoginDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var user = this.StudentService.GetStudentByEmail(body.Email);
            if (user == null)
            {
                res.setErrorMessage("email or password is wrong");
                return new BadRequestObjectResult(res.getResponse());
            }
 
            if (!this.AuthService.ComparePassword(body.Password, user.Password))
            {
                res.setErrorMessage("email or password is wrong");
                return new BadRequestObjectResult(res.getResponse());
            }

            var token = this.AuthService.LoginHandler(user.StudentId);

            if (token == null)
            {
                res.setErrorMessage("email or password is wrong");
                return new BadRequestObjectResult(res.getResponse());
            }

            this.HttpContext.Response.Cookies.Append("auth-token", token, new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
                SameSite = SameSiteMode.None,
                Secure = true

            });
            Console.WriteLine("--------------");
            res.data = token;
            res.setMessage("login success");

            return new ObjectResult(res.getResponse());
        }

        [HttpPost("login/tutor")]
        public IActionResult HandleLoginForTutor([FromBody] LoginDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new LoginDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var Tutor = this.TutorService.GetTutorByEmail(body.Email);
            if (Tutor == null)
            {
                res.setErrorMessage("Phone or password is wrong");
                return new BadRequestObjectResult(res.getResponse());
            }
         
            if (!this.AuthService.ComparePassword(body.Password, Tutor.Password))
            {
                res.setErrorMessage("Phone or password is wrong");
                return new BadRequestObjectResult(res.getResponse());
            }

            var token = this.AuthService.LoginHandler(Tutor.TutorId);

            if (token == null)
            {
                res.setErrorMessage("Phone or password is wrong");
                return new BadRequestObjectResult(res.getResponse());
            }

            this.HttpContext.Response.Cookies.Append("auth-token", token, new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30),
                SameSite = SameSiteMode.None,
                Secure = true

            });
            res.data = token;
            res.setMessage("login success");

            return new ObjectResult(res.getResponse());
        }

        [HttpPost("register")]
        public IActionResult HandleRegister([FromBody] RegisterDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new RegisterDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var isExistUser = this.StudentService.GetStudentByEmail(body.Email);
            if (isExistUser != null)
            {
                res.setErrorMessage("is already exist", "Email");
                return new BadRequestObjectResult(res.getResponse());
            }


            var student = new Student(); 
            student.StudentId = Guid.NewGuid().ToString();
            student.Email = body.Email;
            student.Password = body.Password;
            student.Semester = body.Semester;
            student.Year = body.Year;
            student.MajorId = body.Major;
            student.LocationId = body.Location;
           

            this.AuthService.RegisterStudentHandler(student);

            res.setMessage("register success");
            return new ObjectResult(res.getResponse());
        }
        
        [HttpPost("register/tutor")]
        public IActionResult HandleRegisterTutor([FromBody] RegisterTutorDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new RegisterTutorDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var isExistUser = this.TutorService.GetTutorByEmail(body.Email);
            if (isExistUser != null)
            {
                res.setErrorMessage("is already exist", "Email");
                return new BadRequestObjectResult(res.getResponse());
            }


            var tutor = new Tutor(); 
            tutor.TutorId = Guid.NewGuid().ToString();
            tutor.Email = body.Email;
            tutor.Password = body.Password;
            tutor.Phone = body.Phone;
            tutor.TeachingMethod = body.TeachingMethod;
            tutor.Description = body.Description;
            tutor.Education = body.Education;
            tutor.Status = TutorStatus.INACTIVE;

           

            this.AuthService.RegisterTutorHandler(tutor);

            res.setMessage("register success");
            return new ObjectResult(res.getResponse());
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            // var res = new ServerApiResponse<string>();
            // this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            // {
            //     Expires = DateTime.Now.AddDays(-1),
            //     SameSite = SameSiteMode.None,
            //     Secure = true

            // });
            // this.HttpContext.Session.Clear();
            // res.setMessage("Logout success");
            // return new ObjectResult(res.getResponse());

            
            return View(Routers.Login.Page);
        }
    }
}
