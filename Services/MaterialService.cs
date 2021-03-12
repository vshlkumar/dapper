using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWithDapper.Services
{
	public class MaterialService:IMaterialService
	{
		Guid _guid;
		private string[] userNames = new string[]
		{
			"Vishal",
			"Gaurav",
			"Shila"
		};

		public MaterialService()
		{
			_guid = new Guid();
		}

		public string[] GetUserNames()
		{
			return userNames;
		}

		public string GetNewGuid()
		{
			return _guid.ToString();
		}
	}
}
