using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using NReJSON;
using StackExchange.Redis;
using Environment = DatacenterEnvironmentSimulator.Models.Environment;

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

		public void SetData(Environment environment)
		{
			var jsonObj = JsonSerializer.Serialize(environment);
			_db.JsonSet(Key, jsonObj);
		}

		public Environment GetData()
		{
			var str = (string) _db.JsonGet(Key);
			var environment = (Environment) JsonSerializer.Deserialize(str, typeof(Environment));
			return environment;
		}
	}
}
