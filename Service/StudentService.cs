using System.Collections.Generic;
using Tutoree.DAO;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Service.Interface;

namespace Tutoree.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository StudentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }


        public List<Student> GetAllStudents()
        {
            return this.StudentRepository.GetAllStudents();
        }

        public Student GetStudentById(string id)
        {
            if (StudentRepository.GetStudentById(id) == null)
            {
                return null;
            }
            else
            {
                return StudentRepository.GetStudentById(id);
            }
        }

        public Student GetStudentByEmail(string email)
        {
            return this.StudentRepository.GetStudentByEmail(email);
        }

        public bool ManageAccountHandler(Student Student)
        {
            return this.StudentRepository.ManageAccountHandler(Student);
        }

        public bool RegisterHandler(Student Student)
        {
            return this.StudentRepository.RegisterHandler(Student);
        }

        public bool UpdatePasswordHandler(Student Student)
        {
            return this.StudentRepository.UpdatePasswordHandler(Student);
        }

        public bool UpdateStudentInfoHandler(Student Student)
        {
            return this.StudentRepository.UpdateStudentInfoHandler(Student);
        }

        public PersonalInfo GetStudentInfo(string id)
        {
            return this.StudentRepository.GetStudentPersonalInfo(id);
        }

    }
}
