using System.Collections.Generic;
using System.Linq;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Utils;

namespace Tutoree.DAO
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DBContext DBContext;
        public StudentRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

        public PersonalInfo GetStudentPersonalInfo(string InfoId)
        {
            PersonalInfo personalInfo = this.DBContext.PersonalInfo.FirstOrDefault(item => item.InfoId ==  InfoId);
            return personalInfo;
        }

        public Student GetStudentByStudentname(string Studentname)
        {
            PersonalInfo personalInfo  = this.DBContext.PersonalInfo.FirstOrDefault(item => item.Name == Studentname);
            Student student = this.DBContext.Student.FirstOrDefault(item => item.InfoId == personalInfo.InfoId);
            return student;
        }
        public Student GetStudentByEmail(string email)
        {
            PersonalInfo personalInfo  = this.DBContext.PersonalInfo.FirstOrDefault(item => item.Email == email);
            Student student = this.DBContext.Student.FirstOrDefault(item => item.InfoId == personalInfo.InfoId);
            return student;
        }

        public Student GetStudentById(string id)
        {
            Student Student = this.DBContext.Student.FirstOrDefault(item => item.StudentId == id);
            return Student;
        }

        public bool RegisterHandler(Student Student)
        {
            this.DBContext.Student.Add(Student);
            return this.DBContext.SaveChanges() > 0;
        }
        public bool UpdatePasswordHandler(Student Student)
        {
            this.DBContext.Student.Update(Student);
            this.DBContext.SaveChanges();
            return true;
        }
        public bool UpdateStudentInfoHandler(Student Student)
        {
            this.DBContext.Student.Update(Student);
            this.DBContext.SaveChanges();
            return true;
        }

        public bool ManageAccountHandler(Student Student)
        {
            this.DBContext.Student.Update(Student);
            return this.DBContext.SaveChanges() > 0;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> listStudent = this.DBContext.Set<Student>().ToList<Student>();
            return listStudent;
        }

        

    }
}