using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.Service.Interface
{
    public interface IMajorService
    {
        public Major GetMajorByMajorId(string majorId);
        public List<SelectListItem> GetListMajor();
        public List<Major> GetAllMajors();
    }
}
