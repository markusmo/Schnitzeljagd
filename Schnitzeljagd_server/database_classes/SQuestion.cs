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
		public SAnswer answer { get; set;}
		public SAnswer user_answer { get; set;}
		public String destination { get; set;}
		public String hint { get; set;}
		public String comment { get; set;}
		public SQuestion next { get; set;}
		public bool solved { get; set;}
		public GPS coordinate { get; set;}

	}
}
