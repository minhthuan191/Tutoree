using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.Models;

namespace Tutoree.DAO.Interface
{
    public interface ILocationRepository
    {
        public Location GetLocationByLocationId(string locationId);
        public List<SelectListItem> GetListLocation();
        public List<Location> GetAllLocations();
    }
}
