using System;
using System.Text.RegularExpressions;

namespace Schnitzeljagd_library
{
	public class Question
	{
		public String question { get; }
		public Answer answer { get; } //regex to match user entered answer
		public Answer user_answer { get; private set;}
		public String destination { get; }
		public String hint { get; }
		public String comment { get; set;}
		public Question next { get; private set;}
		public bool solved { get; private set;}
		public GPS coordinate { get; }

		public Question (String question, String anwser, String destination, String hint, GPS coordinate)
		{
			this.answer = answer;
			this.destination = destination;
			this.hint = hint;
			this.next = next;
			this.coordinate = coordinate;
			this.solved = false;
			this.comment = "";
		}

		public void solveQuestion(String answer, User user)
		{
			Regex reg = new Regex (answer);
			this.solved = reg.Match (answer).Success;
		}

		public void setQuestion (Question nextquestion, User user)
		{
			if (user.right == Rights.Leiter)
				this.next = nextquestion;
		}

		public void setUserAnswer (Answer uanswer)
		{
			this.user_answer = uanswer;
		}

	}
}
