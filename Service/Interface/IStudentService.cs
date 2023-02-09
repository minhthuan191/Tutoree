using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.Service.Interface
{
    public interface IStudentService
    {
        public bool UpdatePasswordHandler(Student Student);
        public bool UpdateStudentInfoHandler(Student Student);
        public Student GetStudentById(string id);
        public Student GetStudentByEmail(string email);
        public bool RegisterHandler(Student Student);
        public List<Student> GetAllStudents();
        public bool ManageAccountHandler(Student Student);
    }
}
