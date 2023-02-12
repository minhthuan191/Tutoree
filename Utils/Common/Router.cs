namespace Tutoree.Utils.Common
{
    public class RouterItem
    {
        public string Title
        {
            get; set;
        }
        public string Page
        {
            get; set;
        }
        public string Link
        {
            get; set;
        }
    }

    public class Routers
    {

        public static readonly RouterItem Register = new RouterItem() { Page = "/Views/Containers/Auth/Register.cshtml", Title = "Register", Link = "/auth/register" };
        public static readonly RouterItem LoginTutor = new RouterItem() { Page = "/Views/Containers/Auth/LoginTutor.cshtml", Title = "Login", Link = "/auth/login/tutor" };
        public static readonly RouterItem Login = new RouterItem() { Page = "/Views/Containers/Auth/Login.cshtml", Title = "Login", Link = "/auth/login" };
        public static readonly RouterItem Home = new RouterItem() { Page = "/Views/Containers/Home.cshtml", Title = "Home", Link = "/" };
    }
}
