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
		LocalizationMessage NameMustBeSet { get; }
	}

	public class InvariantModelLocalizationComponent : IModelLocalizationComponent
	{
		public InvariantModelLocalizationComponent()
		{
			NameMustBeSet = new LocalizationMessage("template");
		}

		public LocalizationMessage NameMustBeSet { get; }
	}

	public class EnglishModelLocalizationComponent : IModelLocalizationComponent
	{
		public EnglishModelLocalizationComponent()
		{
			NameMustBeSet = new LocalizationMessage("english");
		}

		public LocalizationMessage NameMustBeSet { get; }
	}

	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddLocalization(configuration =>
			{
				configuration.AddCultures(new[] {CultureInfo.InvariantCulture}, culture =>
				{
					culture.AddComponent<IModelLocalizationComponent, InvariantModelLocalizationComponent>();
				});

				configuration.AddCulture(CultureInfo.GetCultureInfo("en"), culture =>
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

				var result = localization.Localize<IModelLocalizationComponent>(c => c.NameMustBeSet);

				await context.Response.WriteAsync(result);
			});
		}
	}
}