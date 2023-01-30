
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using Tutoree.DAO.Interface;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;
using Tutoree.Utils.Interface;
using Tutoree.Utils.Locale;

namespace Tutoree.Auth
{
    public class AuthGuard : IActionFilter
    {
        private readonly IJwtService JWTService;
        private readonly IStudentService StudentService;
        private readonly ITutorService TutorService;
        public AuthGuard(IJwtService jwtService, IStudentService StudentService, ITutorService TutorService)
        {

            this.JWTService = jwtService;
            this.StudentService = StudentService;
            this.TutorService = TutorService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public bool GuardHandler(ActionExecutingContext context)
        {

            try
            {
                var cookies = new Dictionary<string, string>();
                var accessToken = ((string)context.HttpContext.Request.Headers["auth-token"]);
                if (accessToken == null)
                {
                    return false;
                }

                var token = this.JWTService.VerifyToken(accessToken).Split(";");

                if (token[0] == null)
                {
                    return false;
                }
                var user = this.StudentService.GetStudentById(token[0]);

                if (user == null)
                {
                    var trainer = this.TutorService.GetTutorById(token[0]);

                    if (trainer == null)
                    {
                        return false;
                    }

                    Controller controller1 = context.Controller as Controller;

                }

                Controller controller = context.Controller as Controller;
                controller.ViewData["user"] = user;

                // check user's role
                //if (context.ActionArguments.TryGetValue("roles", out _))
                //{
                //    string roles = context.ActionArguments["roles"] as String;
                //    if (!roles.Contains(user.Role))
                //    {
                //        return false;
                //    }
                //}
                //

                return true;

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            bool isValid = this.GuardHandler(context);
            if (!isValid)
            {
                Controller controller = context.Controller as Controller;
                ServerResponse.SetErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_NOT_ALLOW_ACTION, controller.ViewData);
                context.Result = new ViewResult
                {
                    //ViewName = Routers.Login.Page,
                };
                return;
            }
        }
    }
}
