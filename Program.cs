using DataLayer.EntitiesCode;
using Meferi;
using Microsoft.AspNetCore;

public class Program
{
	public static void Main(string[] args)
	{
		var host = CreateWebHostBuilder(args).Build();

	/*	using (var scope = host.Services.CreateScope())
		{
			var services = scope.ServiceProvider;
			try
			{
				var context = services.GetRequiredService<EfCoreContext>();
			}
			catch (Exception ex)
			{
				var logger = services.GetRequiredService<ILogger<Program>>();
				logger.LogError(ex, "An error occurred creating the DB.");
			}
		}*/

		host.Run();
	}

	public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
		WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
}
