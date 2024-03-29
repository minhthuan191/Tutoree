﻿using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.Service.Interface
{
    public interface ITutorService
    {
        public bool UpdatePasswordHandler(Tutor Tutor);
        public bool UpdateTutorInfoHandler(Tutor Tutor);
        public Tutor GetTutorById(string id);
        public Tutor GetTutorByEmail(string email);
        public bool RegisterHandler(Tutor Tutor);
        public List<Tutor> GetAllTutors();
        public bool ManageAccountHandler(Tutor Tutor);
        public (List<Tutor>, int) GetAllTutors(int pageIndex, int pageSize, string subjectId, string locationId);
    }
}
