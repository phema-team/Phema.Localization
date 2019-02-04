using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Phema.Localization
{
	public static class LocalizationExtensions
	{
		public static IServiceCollection AddPhemaLocalization(
			this IServiceCollection services,
			Action<ILocalizationConfiguration> configuration = null)
		{
			configuration?.Invoke(new LocalizationConfiguration(services));

			services.TryAddSingleton<ILocalizer, Localizer>();
			return services.ConfigureOptions<LocalizationPostConfigureOptions>();
		}
	}
}