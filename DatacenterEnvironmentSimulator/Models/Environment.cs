using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatacenterEnvironmentSimulator.Models
{
	public class Environment
	{
		public string EnvironmentName
		{
			get;
			set;
		}
		public ISet<Server> Servers
		{
			get;
			set;
		}
	}
}
