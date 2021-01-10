using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatacenterEnvironmentSimulator.Models
{
	public class Server
	{
		public string Name { get; set; }
		public string Os { get; set; }
		public float HddFull { get; set; }
		public float HddFree { get; set; }
		public float RamFull { get; set; }
		public float RamFree { get; set; }
		public  int Cpu { get; set; }
		public ICollection<Service> Services { get; set; }
	}
}
