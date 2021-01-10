using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DatacenterEnvironmentSimulator.Models;
using NReJSON;
using StackExchange.Redis;

namespace DatacenterEnvironmentSimulator.DbContext
{
	public class RedisDbContext
	{
		private readonly IDatabase _db;

		public RedisDbContext()
		{
			var redis = ConnectionMultiplexer.Connect("localhost:6379");
			_db = redis.GetDatabase();
		}

		public void SetData(string key, ISet<Server> servers)
		{
			var jsonObj = JsonSerializer.Serialize(servers);
			_db.JsonSet(key, jsonObj);
		}

		public ISet<Server> GetData(string key)
		{
			var str = (string) _db.JsonGet(key);
			var servers = (ISet<Server>) JsonSerializer.Deserialize(str, typeof(ISet<Server>));
			return servers;
		}
	}
}
