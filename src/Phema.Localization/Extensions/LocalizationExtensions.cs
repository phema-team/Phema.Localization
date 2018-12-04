using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Phema.Localization
{
	public static class LocalizationExtensions
	{
		public static IServiceCollection AddLocalization(
			this IServiceCollection services,
			Action<ILocalizationConfiguration> action)
		{
			services.AddHttpContextAccessor();
			services.TryAddSingleton<ILocalizer, Localizer>();
			services.ConfigureOptions<LocalizationPostConfigureOptions>();
			
			action(new LocalizationConfiguration(services));
			return services;
		}
	}
}