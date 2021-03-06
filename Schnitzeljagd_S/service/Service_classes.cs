﻿using System;
using System.Collections.Generic;
using ServiceStack;

namespace Schnitzeljagd_server
{
	[Route ("/api/v1/questions", "GET")]
	public class GetQuestions : IReturn<QuestionResponse>{}

	public class QuestionResponse
	{
		public List<SQuestion> Results { get; set;}
	}

	[Route ("/api/v1/questions/{Id}", "GET")]
	public class GetQuestion: IReturn<SQuestion>
	{
		public int Id { get; set;}
	}

	[Route("api/v1/answers/{Id}","GET")]
	public class GetAnswer : IReturn<SAnswer>
	{
		public int Id { get; set;}
	}

	[Route ("api/v1/answers/{Id}", "PUT")]
	public class PostAnswer : IReturn<SAnswer>
	{
		//fields to add
		public int Id { get; set; }
	}

	[Route ("api/v1/login/","GET")]
	public class GetLogin : IReturn<bool>
	{
		public string username { get; set; }
		public string password { get; set; }
	}
}
