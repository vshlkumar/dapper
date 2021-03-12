using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWithDapper.Services
{
	public interface IRestaurantService
	{
		List<string> GetListOfMenuItems();

		List<int> GetListOfIds();

		List<string> GetUpdatedListOfMenus();
	}
}
