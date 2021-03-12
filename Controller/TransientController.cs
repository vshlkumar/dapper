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
    public class TransientController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IMaterialService _materialService;
        public TransientController(IRestaurantService restaurantService, IMaterialService materialService)
        {
            _restaurantService = restaurantService;
            _materialService = materialService;
        }

        [HttpGet]
        [Route("GetMaterial")]
        public string[] GetMaterial()
        {
            var menu = _restaurantService.GetListOfMenuItems();
            var username = _materialService.GetUserNames();
            return username;
        }

        [HttpGet]
        [Route("GetNewGuid")]
        public string GetNewGuid()
        {
            return _materialService.GetNewGuid();
        }
    }
}