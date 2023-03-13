using System;
using Tutoree.Models;
using Tutoree.Service.Interface;
using Tutoree.Utils;
using Tutoree.Utils.Interface;

namespace Tutoree.Service
{
    public class AuthService : IAuthService
    {
        private readonly IJwtService JWTService;
        private readonly IStudentService StudentService;
        private readonly EffortlessService EffortlessService;

        public AuthService(IStudentService StudentService, IJwtService jwtService, EffortlessService effortlessService)
        {
            this.StudentService = StudentService;
            JWTService = jwtService;
            EffortlessService = effortlessService;
        }

        public bool RegisterStudentHandler(Student Student)
        {   
            return StudentService.RegisterHandler(Student);
        }

        public string LoginHandler(string StudentId)
        {
            var token = JWTService.GenerateToken(StudentId);
            return token;
        }

        public string HashingPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 8);
        }

        public bool ComparePassword(string inputPassword, string encryptedPassword)
        {
            return inputPassword.Equals(encryptedPassword);
        }

        public bool RegisterTutorHandler(Tutor tutor)
        {
            throw new NotImplementedException();
        }
    }
}