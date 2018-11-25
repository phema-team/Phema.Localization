using System;
using System.Globalization;

namespace Phema.Localization
{
	public static class LocalizationConfigurationExtensions
	{
		public static void AddCulture(
			this ILocalizationConfiguration configuration, 
			CultureInfo cultures, 
			Action<ICultureConfiguration> action)
		{
			configuration.AddCultures(new[] { cultures }, action);
		}
		
	}
}