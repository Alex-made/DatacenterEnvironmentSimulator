using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text.Json;
using System.Threading.Tasks;
using DatacenterEnvironmentSimulator.Models;
using DatacenterEnvironmentSimulator.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NReJSON;
using StackExchange.Redis;

namespace DatacenterEnvironmentSimulator.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SimulatorController : ControllerBase
	{
		private readonly IRepository<ISet<Server>> _repository;

		private readonly ILogger<SimulatorController> _logger;

		public SimulatorController(IRepository<ISet<Server>> repository, ILogger<SimulatorController> logger)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_logger = logger;
		}

		[HttpPost]
		public void SetData(ISet<Server> servers)
		{
			_repository.SetData(servers);
		}

		[HttpGet]
		public ISet<Server> Get()
		{
			return _repository.GetData();
		}
	}
}
