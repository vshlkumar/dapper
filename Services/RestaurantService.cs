using APIWithDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWithDapper.Services
{
	public class RestaurantService : IRestaurantService
	{
		private List<string> menu = new List<string>()
			{
				"Dosa",
				"Idli",
				"Pranthas",
				"Chicken"
			};
		private readonly IRepository _repository;
		public RestaurantService(IRepository repository)
		{
			_repository = repository;
		}
	public List<string> GetListOfMenuItems()
		{
			var con = _repository.Connection;
			return menu;
		}

		public List<string> GetUpdatedListOfMenus()
		{
			menu.Add("Wada");
			return menu.ToList();
		}

		public List<int> GetListOfIds()
		{
			return new List<int>()
			{
				1,2,3,5,6,7
			};
		}
	}
}
