using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils;
using Tutoree.Utils.Interface;

namespace Tutoree.Service
{
    public class AuthService : IAuthService
    {
        private readonly DBContext DBContext;
        private readonly IStudentService StudentService;
        private readonly IJwtService JWTService;
        public AuthService(DBContext dBContext, IStudentService StudentService, IJwtService jwtService)
        {
            this.DBContext = dBContext;
            this.StudentService = StudentService;
            this.JWTService = jwtService;
        }

        public bool RegisterStudentHandler(Student Student)
        {
            return this.StudentService.RegisterHandler(Student);
        }


        public string LoginHandler(string StudentId)
        {
            string token = this.JWTService.GenerateToken(StudentId);
            return token;
        }

        public string HashingPassword(string password)

        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 8);
        }

        public bool ComparePassword(string inputPassword, string encryptedPassword)
        {
            return inputPassword.Equals(encryptedPassword);
        }

        public bool RegisterTutorHandler(Tutor tutor)
        {
            throw new System.NotImplementedException();
        }
    }
}
