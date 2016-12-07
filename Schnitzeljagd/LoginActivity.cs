
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Json;

namespace Schnitzeljagd
{
	[Activity (Label = "LoginActivity")]
	public class LoginActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			Button loginbutton = FindViewById<Button> (Resource.Id.loginbutton);
			TextView usernameText = FindViewById<TextView> (Resource.Id.usernameText);
			TextView passwordText = FindViewById<TextView> (Resource.Id.passwordText);


		}
	}
}
