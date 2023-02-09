using System.Collections.Generic;
using System.Linq;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Utils;

namespace Tutoree.DAO
{
    public class TutorRepository : ITutorRepository
    {
        private readonly DBContext DBContext;
        public TutorRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

        public Tutor GetTutorByTutorname(string Tutorname)
        {
            Tutor Tutor = this.DBContext.Tutor.FirstOrDefault(item => item.Name == Tutorname);
            return Tutor;
        }
        public Tutor GetTutorByEmail(string email)
        {
            Tutor Tutor = this.DBContext.Tutor.FirstOrDefault(item => item.Email == email);
            return Tutor;
        }
        public Tutor GetTutorById(string id)
        {
            Tutor Tutor = this.DBContext.Tutor.FirstOrDefault(item => item.TutorId == id);
            return Tutor;
        }

        public bool RegisterHandler(Tutor Tutor)
        {
            this.DBContext.Tutor.Add(Tutor);
            return this.DBContext.SaveChanges() > 0;
        }
        public bool UpdatePasswordHandler(Tutor Tutor)
        {
            this.DBContext.Tutor.Update(Tutor);
            this.DBContext.SaveChanges();
            return true;
        }
        public bool UpdateTutorInfoHandler(Tutor Tutor)
        {
            this.DBContext.Tutor.Update(Tutor);
            this.DBContext.SaveChanges();
            return true;
        }

        public bool ManageAccountHandler(Tutor Tutor)
        {
            this.DBContext.Tutor.Update(Tutor);
            return this.DBContext.SaveChanges() > 0;
        }
        public List<Tutor> GetAllTutors()
        {
            List<Tutor> listTutor = this.DBContext.Set<Tutor>().ToList<Tutor>();
            return listTutor;
        }

        

    }
}