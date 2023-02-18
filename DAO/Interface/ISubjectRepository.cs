﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.DAO.Interface
{
    public interface ISubjectRepository
    {
        public Subject GetSubjectByID(string subjectId);
        public Subject GetSubjectByName(string subjectName);
        public bool CreateSubjectHandler(Subject subject);
        public bool UpdateSubjectInfoHandler(Subject subject);
        public List<SelectListItem> GetListSubjects();
        public List<Subject> GetAllSubjects();
    }
}
