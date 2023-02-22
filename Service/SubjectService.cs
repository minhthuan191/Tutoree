using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Service.Interface;

namespace Tutoree.Service
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository SubjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            SubjectRepository = subjectRepository;
        }
        public bool CreateSubjectHandler(Subject subject)
        {
            return this.SubjectRepository.CreateSubjectHandler(subject);
        }

        public List<Subject> GetAllSubjects()
        {
            return this.SubjectRepository.GetAllSubjects();
        }

        public List<SelectListItem> GetListSubjects()
        {
            return this.SubjectRepository.GetListSubjects();
        }

        public Subject GetSubjectByID(string subjectId)
        {
            return this.SubjectRepository.GetSubjectByID(subjectId);
        }

        public Subject GetSubjectByName(string subjectName)
        {
            return this.SubjectRepository.GetSubjectByName(subjectName);
        }

        public bool UpdateSubjectInfoHandler(Subject subject)
        {
            return this.SubjectRepository.UpdateSubjectInfoHandler(subject);
        }
    }
}
