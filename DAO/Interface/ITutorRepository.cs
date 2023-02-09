using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.DAO.Interface
{
    public interface ITutorRepository
    {
        public Tutor GetTutorByTutorname(string Tutorname);
        public Tutor GetTutorById(string id);
        public Tutor GetTutorByEmail(string email);
        public bool RegisterHandler(Tutor Tutor);
        public bool UpdatePasswordHandler(Tutor Tutor);
        public bool UpdateTutorInfoHandler(Tutor Tutor);
        public List<Tutor> GetAllTutors();
        public bool ManageAccountHandler(Tutor Tutor);
    }
}
