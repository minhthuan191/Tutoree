﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils.Common;

namespace Tutoree.Controllers
{
    [Route("/auth")]
    public class AuthController : Controller
    {
        public static Boolean LogedIn = false;

        public static string Role = "Guest";

        private readonly IAuthService AuthService;

        public AuthController(IAuthService authService)
        {
            this.AuthService = authService;
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
            var user = (Student)this.ViewData["student"];
            if (user != null)
            {
                return Redirect(Routers.Home.Link);
            }
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

            this.HttpContext.Response.Cookies.Append("auth-token", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1),
                SameSite = SameSiteMode.None,
                Secure = true

            });
            this.HttpContext.Session.Clear();
            return Redirect(Routers.Login.Link + "?message=logout success");
        }



    }
}
