using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.DAO.Interface
{
    public interface IMajorRepository
    {
        public Major GetMajorByMajorId(string MajorId);
        public List<SelectListItem> GetListMajor();
        public List<Major> GetAllMajors();
    }
}
