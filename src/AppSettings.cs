namespace Source;

// Source - https://stackoverflow.com/a/53924899
// Posted by Dmitry Pavlov
// License - CC BY-SA 4.0
public class AppSettings
{
   public bool UseInMemory { get; set; }
   public string Server { get; set; }
   public string Port { get; set; }
   public string Database { get; set; }
   public string User { get; set; }
   public string Password { get; set; }

   public string BuildConnectionString()
   {
		if(UseInMemory) return null;

		// You can set environment variable name which stores your real value, or use as value if not configured as environment variable
		// .GetEnvironmentVariable() checks the .env / appsettings.json in the same directory???
		var server = Environment.GetEnvironmentVariable(SERVER) ?? Server;
		var port = Environment.GetEnvironmentVariable(PORT) ?? Port;
		var database = Environment.GetEnvironmentVariable(DATABASE) ?? Database;
		var user = Environment.GetEnvironmentVariable(USER) ?? User;
		var password = Environment.GetEnvironmentVariable(PASSWORD) ?? Password;

		return $"Server={server};Port={port};Database={database};Uid={user};Pwd={password}";
   }
}
