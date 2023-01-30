using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using Tutoree.Service.Interface;
using Tutoree.Utils.Interface;

namespace Tutoree.Auth
{
    public class UserFilter : IActionFilter
    {
        private readonly IJwtService JWTService;
        private readonly IStudentService StudentService;
        public UserFilter(IJwtService jwtService, IStudentService StudentService)
        {

            this.JWTService = jwtService;
            this.StudentService = StudentService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            bool isValid = this.GuardHandler(context);
        }

        public bool GuardHandler(ActionExecutingContext context)
        {

            try
            {
                var cookies = new Dictionary<string, string>();
                var values = ((string)context.HttpContext.Request.Headers["Cookie"]).Split(',', ';');


                foreach (var parts in values)
                {
                    var cookieArray = parts.Trim().Split('=');
                    if (cookieArray.Length >= 2)
                    {
                        cookies.Add(cookieArray[0], cookieArray[1]);
                    }
                }

                if (!cookies.TryGetValue("auth-token", out _))
                {
                    return false;
                }
                var token = this.JWTService.VerifyToken(cookies["auth-token"]).Split(";");

                if (token[0] == null)
                {
                    return false;
                }
                var Student = this.StudentService.GetStudentById(token[0]);
                if (Student == null)
                {
                    return false;
                }

                Controller controller = context.Controller as Controller;
                controller.ViewData["Student"] = Student;
                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }
    }
}
