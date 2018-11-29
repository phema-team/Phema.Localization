using System;
using Microsoft.Extensions.DependencyInjection;

namespace Phema.Localization
{
	public static class LocalizationExtensions
	{
		public static IServiceCollection AddLocalization(
			this IServiceCollection services,
			Action<ILocalizationConfiguration> action)
		{
			services.AddHttpContextAccessor();
			services.AddSingleton<ILocalizer, ProviderLocalizer>();
			services.ConfigureOptions<LocalizationPostConfigureOptions>();
			
			action(new LocalizationConfiguration(services));
			return services;
		}
	}
}