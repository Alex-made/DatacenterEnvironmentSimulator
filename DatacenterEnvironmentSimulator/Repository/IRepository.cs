using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Environment = DatacenterEnvironmentSimulator.Models.Environment;

namespace DatacenterEnvironmentSimulator.Repository
{
	public interface IRepository<T> where T : class
	{
		void SetData(T environment);

		T GetData();
	}
}
