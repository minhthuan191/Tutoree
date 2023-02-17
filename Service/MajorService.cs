using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Service.Interface;

namespace Tutoree.Service
{
    public class MajorService : IMajorService
    {
        private readonly IMajorRepository MajorRepository;
        public MajorService(IMajorRepository majorRepository)
        {
            MajorRepository = majorRepository;
        }

        public List<Major> GetAllMajors()
        {
            return this.MajorRepository.GetAllMajors();
        }

        public List<SelectListItem> GetListMajor()
        {
            return this.MajorRepository.GetListMajor();
        }

        public Major GetMajorByMajorId(string MajorId)
        {
            return this.MajorRepository.GetMajorByMajorId(MajorId);
        }
    }
}
