using Tutoree.Models;

namespace Tutoree.Service.Interface
{
    public interface IAuthService
    {
        public string LoginHandler(string userId);
        public bool RegisterStudentHandler(Student student);
        public bool RegisterTutorHandler(Tutor tutor);
        public string HashingPassword(string password);
        public bool ComparePassword(string inputPassword, string encryptedPassword);
    }
}
