using System;
using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
using Schnitzeljagd_library;

namespace Schnitzeljagd
{
	public class RestManager
	{
		private static RestManager INSTANCE = null;
		private String url = "127.0.0.1";

		private RestManager(){}

		public static RestManager getInstance()
		{
			if(INSTANCE == null)
			{
				INSTANCE = new RestManager ();
			}
			return INSTANCE;
		}

		private RestClient GenerateClient()
		{
			RestClient client = new RestClient (url);
			client.Timeout = 1000; //in case of crash :-)
			return client;
		}

		public async Task<IRestResponse<bool>> Login (String username, String password)
		{
			
			RestRequest request = new RestRequest("api/v1/login", Method.GET);
			request.AddQueryParameter ("username", username);
			request.AddQueryParameter ("password", password);

			var tcs = new TaskCompletionSource<IRestResponse<bool>> ();

			GenerateClient().ExecuteAsync<bool> (request, response => {
				if(response.ErrorException != null)
				{
					throw new ApplicationException ("Error login in", response.ErrorException);
				}
				tcs.SetResult (response);
			});

			return await tcs.Task;
		}

		public async Task<IRestResponse<List<Question>>> GetQuestions()
		{
			RestRequest request = new RestRequest ("api/v1/questions", Method.GET);
			request.RequestFormat = DataFormat.Json;

			var tcs = new TaskCompletionSource<IRestResponse<List<Question>>>();

			GenerateClient ().ExecuteAsync<List<Question>> (request, response => { 
				if(response.ErrorException != null)
				{
					throw new ApplicationException ("Error getting questions", response.ErrorException);
				}
				tcs.SetResult (response);
			});

			return await tcs.Task;
		}

		public async Task<IRestResponse<Answer>> AnswerQuestion (Question question)
		{
			RestRequest request = new RestRequest ("api/v1/questions", Method.POST);
			request.RequestFormat = DataFormat.Json;
			request.AddBody (question);

			var tcs = new TaskCompletionSource<IRestResponse<Answer>> ();

			GenerateClient ().ExecuteAsync<Answer> (request, response => {
				if (response.ErrorException != null) {
					throw new ApplicationException ("Error posting questions", response.ErrorException);
				}
				tcs.SetResult (response);
			});

			return await tcs.Task;
		}
	}
}
