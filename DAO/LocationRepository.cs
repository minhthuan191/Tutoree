using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Utils;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tutoree.DAO
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DBContext DBContext;
        public LocationRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

        public List<Location> GetAllLocations()
        {
            List<Location> listLocation = this.DBContext.Location.ToList();
            return listLocation;
        }

        public List<SelectListItem> GetListLocation()
        {
            var locations = new List<SelectListItem>();
            IEnumerable<Location> listLocations;
            
                listLocations = this.GetAllLocations();
            
            foreach (var item in listLocations)
            {
                locations.Add(new SelectListItem()
                {
                    Value = item.LocationId,
                    Text = item.LocationName
                });
            }
            return locations;
        }

        public Location GetLocationByLocationId(string locationId)
        {
            Location location = this.DBContext.Location.FirstOrDefault(item => item.LocationId == locationId);
            return location;
        }
    }
}
