using System;
using RestSharp;
using System.Threading;
using System.Net;
using System.Threading.Tasks;

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

		public async Task<IRestResponse> Excecute<IRestResponse>(IRestRequest request)
		{
			RestClient client = new RestClient (url);
			client.Timeout = 1000; //in case of crash :-)

			var taskCompleteSource = new TaskCompletionSource<IRestResponse> ();
			client.ExecuteAsync (request, (response) => {
				if(response.ErrorException != null)
				{
					throw new ApplicationException ("Error executing request",response.ErrorException);
				}
				taskCompleteSource.SetResult (response);
			});
			return await taskCompleteSource.Task;
		}

	}
}
