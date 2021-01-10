using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatacenterEnvironmentSimulator.DbContext;
using DatacenterEnvironmentSimulator.Models;

namespace DatacenterEnvironmentSimulator.Repository
{
	public class RedisRepository : IRepository<ISet<Server>>
	{
		private readonly RedisDbContext _dbContext;

		public RedisRepository()
		{
			_dbContext = new RedisDbContext();
		}

		public void SetData(string key, ISet<Server> environment)
		{
			_dbContext.SetData(key, environment);
		}

		public ISet<Server> GetData(string key)
		{
			return _dbContext.GetData(key);
		}
	}
}
