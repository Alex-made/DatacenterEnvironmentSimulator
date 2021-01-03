using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatacenterEnvironmentSimulator.Repository
{
	public interface IRepository<T> where T : class
	{
		void SetData(T environment);

		T GetData();
	}
}
