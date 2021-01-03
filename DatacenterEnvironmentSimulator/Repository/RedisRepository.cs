using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatacenterEnvironmentSimulator.DbContext;
using Environment = DatacenterEnvironmentSimulator.Models.Environment;

namespace DatacenterEnvironmentSimulator.Repository
{
	public class RedisRepository : IRepository<Environment>
	{
		private readonly RedisDbContext _dbContext;

		public RedisRepository()
		{
			_dbContext = new RedisDbContext();
		}

		public void SetData(Environment environment)
		{
			_dbContext.SetData(environment);
		}

		public Environment GetData()
		{
			return _dbContext.GetData();
		}
	}
}
