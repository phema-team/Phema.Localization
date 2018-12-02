using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Phema.Localization.Sandbox
{
	public class Model
	{
		public string Name { get; set; }
	}

	public interface IModelLocalizationComponent : ILocalizationComponent<Model>
	{
		LocalizationTemplate NameMustBeSet { get; }
	}

	public class InvariantModelLocalizationComponent : IModelLocalizationComponent
	{
		public InvariantModelLocalizationComponent()
		{
			NameMustBeSet = new LocalizationTemplate("invariant");
		}

		public LocalizationTemplate NameMustBeSet { get; }
	}

	public class EnglishModelLocalizationComponent : IModelLocalizationComponent
	{
		public EnglishModelLocalizationComponent()
		{
			NameMustBeSet = new LocalizationTemplate("english");
		}

		public LocalizationTemplate NameMustBeSet { get; }
	}

	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddLocalization(configuration =>
			{
				configuration.AddCultures(
					new[] {CultureInfo.InvariantCulture, CultureInfo.GetCultureInfo("ru"), }, 
					culture =>
					{
						culture.AddComponent<IModelLocalizationComponent, InvariantModelLocalizationComponent>();
					});

				configuration.AddCulture(
					CultureInfo.GetCultureInfo("en"), 
					culture =>
					{
						culture.AddComponent<Model, IModelLocalizationComponent, EnglishModelLocalizationComponent>();
					});
			});

			services.Configure<LocalizationOptions>(o => o.CultureInfo = CultureInfo.GetCultureInfo("en"));
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async context =>
			{
				var localization = context.RequestServices.GetRequiredService<ILocalizer>();

				var result = localization.Localize<IModelLocalizationComponent>(c => c.NameMustBeSet, null);

				await context.Response.WriteAsync(result);
			});
		}
	}
}