using System;
using System.Text.RegularExpressions;
using Schnitzeljagd_library;
namespace Schnitzeljagd_Library
{
	public class SQuestion
	{
		public String question { get; }
		public SAnswer answer { get; } //regex to match user entered answer
		public SAnswer user_answer { get; private set;}
		public String destination { get; }
		public String hint { get; }
		public String comment { get; set;}
		public SQuestion next { get; private set;}
		public bool solved { get; private set;}
		public GPS coordinate { get; }

		public SQuestion (String question, String anwser, String destination, String hint, GPS coordinate)
		{
			this.answer = answer;
			this.destination = destination;
			this.hint = hint;
			this.next = next;
			this.coordinate = coordinate;
			this.solved = false;
			this.comment = "";
		}

		public void solveQuestion(String answer, SUser user)
		{
			Regex reg = new Regex (answer);
			this.solved = reg.Match (answer).Success;
		}

		public void setQuestion (SQuestion nextquestion, SUser user)
		{
			if (user.right == Rights.Leiter)
				this.next = nextquestion;
		}

		public void setUserAnswer (SAnswer uanswer)
		{
			this.user_answer = uanswer;
		}

	}
}
