using System;
using Funq;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace Schnitzeljagd_server
{
	//https://github.com/ServiceStack/ServiceStack

	public class SchnitzelHost : AppSelfHostBase
	{
		public SchnitzelHost () : base("Schnitzeljagd RESTservice") {}

		public override void Configure (Container container)
		{
			container.Register<IDbConnectionFactory> (c =>
			                                          new OrmLiteConnectionFactory(":memory:",MySqlDialect.Provider)
			                                         );
			using (var db = container.Resolve<IDbConnectionFactory> ().Open ())
			{
				db.CreateTableIfNotExists<> ();
			}
		}
	}
}
