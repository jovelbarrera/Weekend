using System;

namespace Weekend.Models
{
	public class Trip
	{
		public string Id { get; set; }

		public string Icon { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public string Picture { get; set; }
		public int Tickets { get; set; }
		public float Price { get; set; }
		public DateTime Date { get; set; }
	}
}

