using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text.Json;
using System.Threading.Tasks;
using DatacenterEnvironmentSimulator.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NReJSON;
using StackExchange.Redis;
using Environment = DatacenterEnvironmentSimulator.Models.Environment;

namespace DatacenterEnvironmentSimulator.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SimulatorController : ControllerBase
	{
		private readonly IRepository<Environment> _repository;

		private readonly ILogger<SimulatorController> _logger;

		public SimulatorController(IRepository<Environment> repository, ILogger<SimulatorController> logger)
		{
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_logger = logger;
		}

		[HttpPost]
		public void SetData(Environment environment)
		{
			_repository.SetData(environment);
		}

		[HttpGet]
		public Environment Get()
		{
			return _repository.GetData();
		}
	}
}
