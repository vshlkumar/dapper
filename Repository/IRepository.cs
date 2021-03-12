using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APIWithDapper.Repository
{
	public interface IRepository
	{
		IDbConnection Connection { get; }
	}
}
