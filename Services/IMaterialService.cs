using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWithDapper.Services
{
	public interface IMaterialService
	{
		string[] GetUserNames();

		string GetNewGuid();
	}
}
