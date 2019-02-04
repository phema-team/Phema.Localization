using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Phema.Localization;

namespace WebApplication1
{
	public interface ITestModelComponent : ILocalizationComponent
	{
		LocalizationTemplate Hello { get; set; }
	}

	public class RussianTestModelComponent : ITestModelComponent
	{
		public RussianTestModelComponent()
		{
			Hello = new LocalizationTemplate("Привет");
		}
		
		public LocalizationTemplate Hello { get; set; }
	}

	public class EnglishTestModelComponent : ITestModelComponent
	{
		public EnglishTestModelComponent()
		{
			Hello = new LocalizationTemplate("Hello");
		}
		
		public LocalizationTemplate Hello { get; set; }
	}
	
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddPhemaLocalization(configuration => 
				configuration.AddRussianCulture(culture =>
						culture.AddComponent<ITestModelComponent, RussianTestModelComponent>())
					.AddEnglishCulture(culture =>
						culture.AddComponent<ITestModelComponent, EnglishTestModelComponent>()));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			
			app.UseRequestLocalization();

			app.Run(async context =>
			{
				var localizer = context.RequestServices.GetRequiredService<ILocalizer>();

				await context.Response.WriteAsync(localizer.Localize<ITestModelComponent>(c => c.Hello));
			});
		}
	}
}