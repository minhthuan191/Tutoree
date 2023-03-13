using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tutoree.Models;
using Tutoree.Utils;

namespace Tutoree.Service
{
    public class EffortlessService
    {
        private DBContext DbContext;

        public EffortlessService(DBContext dbContext)
        {
            DbContext = dbContext;
        }

        public IEnumerable<SchoolYear> GetAllSchoolYear()
        {
            return DbContext.SchoolYear.ToList();
        }
    }
}


