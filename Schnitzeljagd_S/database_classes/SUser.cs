using ServiceStack.DataAnnotations;

namespace Schnitzeljagd_server
{
	public class SUser
	{
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set; }
		public string username { get; set;}
		public string password { get; set;}
		public SRights right { get; set;}
	}
}