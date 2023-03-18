using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TutoreeServer.Controllers.DTO;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;


namespace TutoreeServer.Controllers
{
    [Route("/api/student")]
    public class StudentApiController : Controller
    {
        private readonly IAuthService AuthService;
        private readonly IStudentService StudentService;
        public StudentApiController(IStudentService StudentService, IAuthService AuthService)
        {
            this.AuthService = AuthService;
            this.StudentService = StudentService;
        }

        [HttpPost("updateinfo")]
        public IActionResult HandleUpdateStudentInfo([FromBody] UpdateStudentDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new UpdateStudentDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            Student student = (Student)this.ViewData["student"];

            student.Name = body.Name;
            student.Phone = body.Phone;
            student.Age = body.Age;
            student.Year = body.Year;
            student.MajorId = body.MajorId;
            student.LocationId = body.LocationId;
            student.Semester = body.Semester;

            this.StudentService.UpdateStudentInfoHandler(student);

            res.setMessage("Update user infomation success!");
            return new ObjectResult(res.getResponse());
        }
        [HttpPost("password")]
        public IActionResult HandleUpdatePassword([FromBody] ChangePasswordDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new ChangePasswordDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            Student Student = (Student)this.ViewData["Student"];
            bool checkPassword = AuthService.ComparePassword(body.Password, Student.Password);
            if (!checkPassword)
            {
                res.setErrorMessage("Old password is not correct!");
                return new BadRequestObjectResult(res.getResponse());
            }
            if (!(body.NewPassword == body.ConfirmNewPassword))
            {
                res.setErrorMessage("Confirm password does not match new password");
                return new BadRequestObjectResult(res.getResponse());
            }
            Student.Password = body.NewPassword;



            this.StudentService.UpdatePasswordHandler(Student);
            this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1),
                SameSite = SameSiteMode.None,
                Secure = true

            });
            res.setMessage("Change Password success!");
            return new ObjectResult(res.getResponse());
        }

    }
}
