using Funq;
using System.Web;
using System.Web.Http;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;

namespace Schnitzeljagd_S
{
	public class Global : HttpApplication
	{
		//https://github.com/ServiceStack/ServiceStack
		//https://github.com/ServiceStack/ServiceStack.OrmLite

		public class SchnitzelHost : AppSelfHostBase
		{
			public SchnitzelHost () : base ("Schnitzeljagd RESTservice") { } //add service

			public override void Configure (Container container)
			{
				throw new ApplicationException ("add typeof(RestService) to base()");
				container.Register<IDbConnectionFactory> (c =>
														  new OrmLiteConnectionFactory (":memory:", MySqlDialect.Provider)
														 );
				using (var db = container.Resolve<IDbConnectionFactory> ().Open ()) {
					db.CreateTableIfNotExists<> ();
				}
			}
		}

		protected void Application_Start ()
		{
			GlobalConfiguration.Configure (WebApiConfig.Register);
			new SchnitzelHost ().Init (); //start
		}
	}
}
