using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tutoree.DAO.Interface;
using Tutoree.Models;
using Tutoree.Service.Interface;

namespace Tutoree.Service
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository LocationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            LocationRepository = locationRepository;
        }

        public List<Location> GetAllLocations()
        {
           return this.LocationRepository.GetAllLocations();
        }

        public List<SelectListItem> GetListLocation()
        {
            return this.LocationRepository.GetListLocation();
        }

        public Location GetLocationByLocationId(string locationId)
        {
            return this.LocationRepository.GetLocationByLocationId(locationId);
        }
    }
}
