using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Phema.Localization
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddPhemaLocalization(
		this IServiceCollection services,
		Action<ILocalizationConfiguration> configuration = null)
		{
			services.Configure<RequestLocalizationOptions>(options =>
			{
				options.SupportedCultures.Clear();
				options.SupportedUICultures.Clear();
			});

			services.ConfigureOptions<DefaultRequestCulturePostConfigureOptions>();
			
			configuration?.Invoke(new LocalizationConfiguration(services));

			services.TryAddSingleton<ILocalizer, Localizer>();
			return services;
		}
	}
}