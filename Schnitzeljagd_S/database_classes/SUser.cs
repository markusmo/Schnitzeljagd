using ServiceStack.DataAnnotations;

namespace Schnitzeljagd_server
{
	public class SUser
	{
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set; }
		[StringLength(30)]
		public string username { get; set;}
		[StringLength(30)]
		public string password { get; set;}
		public SRights right { get; set;}
	}
}