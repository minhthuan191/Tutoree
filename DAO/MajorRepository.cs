using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Utils;

namespace Tutoree.DAO
{
    public class MajorRepository : IMajorRepository
    {
        private readonly DBContext DBContext;
        public MajorRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

        public List<Major> GetAllMajors()
        {
            List<Major> listMajor = this.DBContext.Major.ToList();
            return listMajor;
        }

        public List<SelectListItem> GetListMajor()
        {
            var Majors = new List<SelectListItem>();
            IEnumerable<Major> listMajors;

            listMajors = this.GetAllMajors();

            foreach (var item in listMajors)
            {
                Majors.Add(new SelectListItem()
                {
                    Value = item.MajorId,
                    Text = item.MajorName
                });
            }
            return Majors;
        }

        public Major GetMajorByMajorId(string MajorId)
        {
            Major Major = this.DBContext.Major.FirstOrDefault(item => item.MajorId == MajorId);
            return Major;
        }
    }
}
