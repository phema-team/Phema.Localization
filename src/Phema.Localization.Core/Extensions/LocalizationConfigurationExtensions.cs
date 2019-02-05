using System;
using System.Globalization;

namespace Phema.Localization
{
	public static class LocalizationConfigurationExtensions
	{
		/// <summary>
		/// Добавляет заданную культуру
		/// </summary>
		public static ILocalizationConfiguration AddCulture(
			this ILocalizationConfiguration configuration, 
			CultureInfo cultureInfo, 
			Action<ICultureConfiguration> culture)
		{
			return configuration.AddCultures(new[] { cultureInfo }, culture);
		}
	}
}