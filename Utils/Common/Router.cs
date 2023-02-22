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
        public static readonly RouterItem SearchTutor = new RouterItem() { Page = "/Views/Containers/Students/SearchTutor.cshtml", Title = "Search Tutor", Link = "/searchtutor" };
        public static readonly RouterItem TutorDetails = new RouterItem() { Page = "/Views/Containers/Students/TutorDetails.cshtml", Title = "Tutor Details", Link = "/tutor" };
        public static readonly RouterItem Students = new RouterItem() { Page = "/Views/Containers/Students/Students.cshtml", Title = "My Students", Link = "/students" };
    }
}
