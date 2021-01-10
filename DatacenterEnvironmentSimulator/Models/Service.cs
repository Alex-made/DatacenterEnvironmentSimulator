using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatacenterEnvironmentSimulator.Models
{
	public class Service
	{
		public string Name { get; set; }
		public string Os { get; set; }
		public float Hdd { get; set; }
		public float Ram { get; set; }
		public float Cpu { get; set; }
	}
}
