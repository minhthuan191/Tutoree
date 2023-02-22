using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Utils;

namespace Tutoree.DAO
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly DBContext DBContext;
        public SubjectRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }
        public bool CreateSubjectHandler(Subject subject)
        {
            this.DBContext.Subject.Add(subject);
            return this.DBContext.SaveChanges() > 0;
        }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> listSubject = this.DBContext.Subject.ToList();
            return listSubject;
        }

        public List<SelectListItem> GetListSubjects()
        {
            var subjects = new List<SelectListItem>();
            IEnumerable<Subject> listSubjects;

            listSubjects = this.GetAllSubjects();

            foreach (var item in listSubjects)
            {
                subjects.Add(new SelectListItem()
                {
                    Value = item.SubjectId,
                    Text = item.SubjectName
                });
            }
            return subjects;
        }

        public Subject GetSubjectByID(string subjectId)
        {
            Subject subject = this.DBContext.Subject.FirstOrDefault(item => item.SubjectId == subjectId);
            return subject;
        }

        public Subject GetSubjectByName(string subjectName)
        {
            return this.DBContext.Subject.FirstOrDefault<Subject>(item => item.SubjectName == subjectName);
        }

        public bool UpdateSubjectInfoHandler(Subject subject)
        {
            this.DBContext.Subject.Update(subject);
            return this.DBContext.SaveChanges() > 0;
        }
    }
}
