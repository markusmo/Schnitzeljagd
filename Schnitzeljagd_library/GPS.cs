using System;
namespace Schnitzeljagd_library
{
	public class GPS
	{
		public double latitude { get; }
		public double longitude { get; }
		public string name { get; set; }
		public DateTime timestamp { get; }
		public User owner { get; }

		public GPS(double latitude, double longitude, DateTime timestamp, User owner)
		{
			this.latitude = latitude;
			this.longitude = longitude;
			this.timestamp = timestamp;
			this.owner = owner;
		}
	}
}