using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using APIWithDapper.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWithDapper.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScopeController : ControllerBase
    {
        private readonly IRestaurantService _restaurant;
        private readonly IPlaceService _placeService;
        public ScopeController(IRestaurantService restaurant, IPlaceService placeService)
        {
            _restaurant = restaurant;
            _placeService = placeService;
        }

        [HttpGet]
        [Route("GetMenu")]
        public IEnumerable<string> GetMenus()
        {           
            return _restaurant.GetListOfMenuItems();
        }

        [HttpGet]
        [Route("GetPlaces")]
        public IEnumerable<string> GetPlaces()
        {
            return _placeService.GetPlaceList();
        }
    }
}