namespace Schnitzeljagd_Library
{
	public class User
	{
		public string username { get; }
		public string password { get; }
		public Rights right { get; }

		public User(string username, string password, Rights right)
		{
			this.username = username;
			this.password = password;
			this.right = right;
		}
	}
}