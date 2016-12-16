using System;
using ServiceStack.DataAnnotations;

namespace Schnitzeljagd_server
{
	
	public class SAnswer : ISAnswer
	{
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set; }

		[StringLength(255)]
		public string Answer { get; set; };
	}
}
