using System;
using ServiceStack.DataAnnotations;

namespace Schnitzeljagd_server
{
	public class GPS
	{
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set; }
		public double latitude { get; set;}
		public double longitude { get; set;}
		public string name { get; set; }
		public DateTime timestamp { get; set;}
		public SUser owner { get; set;}

	}
}