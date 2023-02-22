using System.Collections.Generic;
using Tutoree.DAO;
using Tutoree.Service.Interface;
using Tutoree.Models;
using Tutoree.DAO.Interface;

namespace Tutoree.Service
{
    public class TutorService : ITutorService
    {
        private readonly ITutorRepository TutorRepository;
        public TutorService(ITutorRepository tutorRepository)
        {
            this.TutorRepository = tutorRepository;
        }


        public List<Tutor> GetAllTutors()
        {
            return this.TutorRepository.GetAllTutors();
        }

        public Tutor GetTutorById(string id)
        {
            if (TutorRepository.GetTutorById(id) == null)
            {
                return null;
            }
            else
            {
                return TutorRepository.GetTutorById(id);
            }
        }

        public Tutor GetTutorByEmail(string email)
        {
            return this.TutorRepository.GetTutorByEmail(email);
        }

        public bool ManageAccountHandler(Tutor Tutor)
        {
            return this.TutorRepository.ManageAccountHandler(Tutor);
        }

        public bool RegisterHandler(Tutor Tutor)
        {
            return this.TutorRepository.RegisterHandler(Tutor);
        }

        public bool UpdatePasswordHandler(Tutor Tutor)
        {
            return this.TutorRepository.UpdatePasswordHandler(Tutor);
        }

        public bool UpdateTutorInfoHandler(Tutor Tutor)
        {
            return this.TutorRepository.UpdateTutorInfoHandler(Tutor);
        }

        public (List<Tutor>, int) GetAllTutors(int pageIndex, int pageSize, string subjectId, string locationId)
        {
            return this.TutorRepository.GetAllTutors(pageIndex, pageSize, subjectId, locationId);
        }
    }
}
