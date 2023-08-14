using DataLayer.EntitiesCode;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Meferi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			
			var connection = Configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<EfCoreContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("Meferi")));

		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			//app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Categories}/{id?}");
			});
		}
	}
}

