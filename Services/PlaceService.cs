using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWithDapper.Services
{
	public class PlaceService:IPlaceService
	{
		private List<string> placeList = new List<string>();
		

		public List<string> GetPlaceList()
		{
			placeList.Add("Delhi");
			placeList.Add("Chandigarh");
			placeList.Add("Mohali");
			placeList.Add("Haryana");
			return placeList;
		} 
	}
}
