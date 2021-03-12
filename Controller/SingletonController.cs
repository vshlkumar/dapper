using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIWithDapper.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWithDapper.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly IRestaurantService _restaurant;
        public SingletonController(IRestaurantService restaurant)
        {
            _restaurant = restaurant;
        }

        [HttpGet]
        [Route("GetMenu")]
        public IEnumerable<string> GetMenus()
        {
            return _restaurant.GetListOfMenuItems();
        }

        [HttpGet]
        [Route("GetIds")]
        public IEnumerable<int> GetIds()
        {
            return _restaurant.GetListOfIds();
        }

        [HttpGet]
        [Route("GetUpdatedMenus")]
        public IEnumerable<string> GetUpdatedMenus()
        {
            return _restaurant.GetUpdatedListOfMenus();
        }
    }
}