using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Tutoree.Models;
using TutoreeServer.Controllers.DTO;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;
using Microsoft.AspNetCore.Http;
using System;

namespace TutoreeServer.Controllers
{

    [Route("/api/tutor")]
    public class TutorApiController : Controller
    {
        private readonly IAuthService AuthService;
        private readonly ITutorService TutorService;
        public TutorApiController(ITutorService TutorService, IAuthService AuthService)
        {
            this.AuthService = AuthService;
            this.TutorService = TutorService;
        }

        [HttpPost("updateinfo")]
        public IActionResult HandleUpdateUserInfo([FromBody] UpdateTutorDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new UpdateTutorDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            Tutor tutor = (Tutor)this.ViewData["tutor"];

            tutor.Name = body.Name;
            tutor.Phone = body.Phone;
            tutor.Email = body.Email;

            this.TutorService.UpdateTutorInfoHandler(tutor);

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

            Tutor tutor = (Tutor)this.ViewData["tutor"];
            bool checkPassword = AuthService.ComparePassword(body.Password, tutor.Password);
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
            tutor.Password = body.NewPassword;



            this.TutorService.UpdatePasswordHandler(tutor);
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
