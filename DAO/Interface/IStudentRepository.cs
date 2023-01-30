using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.DAO.Interface
{
    public interface IStudentRepository
    {
        public Student GetStudentByStudentname(string Studentname);
        public Student GetStudentById(string id);
        public Student GetStudentByEmail(string email);
        public PersonalInfo GetStudentPersonalInfo(string InfoId);
        public bool RegisterHandler(Student Student);
        public bool UpdatePasswordHandler(Student Student);
        public bool UpdateStudentInfoHandler(Student Student);
        public List<Student> GetAllStudents();
        public bool ManageAccountHandler(Student Student);
    }
}
