using Funq;
using System.Web;
using System.Web.Http;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using Schnitzeljagd_server;

namespace Schnitzeljagd_S
{
	public class Global : HttpApplication
	{
		//https://github.com/ServiceStack/ServiceStack
		//https://github.com/ServiceStack/ServiceStack.OrmLite

		public class SchnitzelHost : AppSelfHostBase
		{
			public SchnitzelHost () : base ("Schnitzeljagd RESTservice", typeof(RestService).Assembly) { }

			public override void Configure (Container container)
			{
				//https://github.com/ServiceStack/ServiceStack.OrmLite/blob/master/tests/ServiceStack.OrmLite.Tests/OrmLiteTestBase.cs
				container.Register<IDbConnectionFactory> (c =>
														  new OrmLiteConnectionFactory ("Server=localhost;Database=schnitzeljagd;UID=schnitzel;Password=schnitzel", MySqlDialect.Provider)
														 );
				using (var db = container.Resolve<IDbConnectionFactory> ().Open ()) {
					db.CreateTableIfNotExists<> ();
				}
			}
		}

		protected void Application_Start ()
		{
			//GlobalConfiguration.Configure (WebApiConfig.Register);
			new SchnitzelHost ().Init (); //start
		}
	}
}
