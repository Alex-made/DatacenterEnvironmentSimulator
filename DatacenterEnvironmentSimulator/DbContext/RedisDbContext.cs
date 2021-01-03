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
		private const string Key = "environmentKey";

		public RedisDbContext()
		{
			var redis = ConnectionMultiplexer.Connect("localhost:6379");
			_db = redis.GetDatabase();
		}

		public void SetData(ISet<Server> servers)
		{
			var jsonObj = JsonSerializer.Serialize(servers);
			_db.JsonSet(Key, jsonObj);
		}

		public ISet<Server> GetData()
		{
			var str = (string) _db.JsonGet(Key);
			var servers = (ISet<Server>) JsonSerializer.Deserialize(str, typeof(ISet<Server>));
			return servers;
		}
	}
}
