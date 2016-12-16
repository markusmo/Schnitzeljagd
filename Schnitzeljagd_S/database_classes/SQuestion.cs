using System;
using System.Text.RegularExpressions;
using ServiceStack.DataAnnotations;

namespace Schnitzeljagd_server
{
	public class SQuestion
	{
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set;}
		[StringLength(255)]
		public String question { get; set;}
		[Reference]
		public SAnswer answer { get; set;}
		[Reference]
		public SAnswer user_answer { get; set; }
		[StringLength(100)]
		public String destination { get; set;}
		[StringLength(255)]
		public String hint { get; set;}
		[StringLength(255)]
		public String comment { get; set;}
		[Reference]
		public SQuestion next { get; set;}
		public bool solved { get; set;}
		[Reference]
		public GPS coordinate { get; set;}

	}
}
