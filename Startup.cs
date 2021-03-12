using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIWithDapper.Repository;
using APIWithDapper.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace APIWithDapper
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }


		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers(); //use for the default conventional routing 

			services.AddSwaggerGen(c => { //download the Swashbuckle.AspNetCore package for swagger
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Test API with dapper",
					Description = "Example demostrate to use the swagger",
					//TermsOfService = new Uri("https://example.com/terms"),
					Contact = new OpenApiContact
					{
						Name = "Vishal Kumar",
						Email = "vishal.enest@gmail.com",
						//Url = new Uri("https://example.com"),
					},
					License = new OpenApiLicense
					{
						Name = "Vishal Copyright",
						//Url = new Uri("https://example.com/license"),
					}
				});
			});

			services.AddSingleton<IRestaurantService, RestaurantService>(); //only one instance is available throughout the application and for every request.

			services.AddTransient<IMaterialService, MaterialService>(); //every time a new instance is created. Transient creates new instance for every service/ controller as well as for every request and every user.

			services.AddScoped<IPlaceService, PlaceService>(); //one instance is available throughout the application per request. When a new request comes in, the new instance is created.

			services.AddScoped<IDapperService, DapperService>();

			services.AddTransient<IRepository, Repository.Repository>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.RoutePrefix = ""; //run the swagger on default route
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test APi with Dapper"); //open the swagger.json which have all the instance of api
			});

			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
