using System;
using ServiceStack;
using ServiceStack.OrmLite;

namespace Schnitzeljagd_server
{
	//https://github.com/ServiceStack/ServiceStack/wiki/Create-your-first-webservice
	//https://github.com/ServiceStack/ServiceStack

	public class RestService : Service
	{
		public object Get(GetQuestions request)
		{
			return new QuestionResponse { Results = Db.Select<SQuestion>() };
		}

		public object Get (GetQuestion request)
		{
			return Db.SingleById<SQuestion> (request.Id);
		}

		public object Get(GetAnswer request)
		{
			return Db.SingleById<SAnswer> (request.Id);
		}

		public object Post(PostAnswer request)
		{
			//fill fields
			var answer = new SAnswer {Id = request.Id}
			Db.Save (answer);
			return answer;
		}
	}
}
