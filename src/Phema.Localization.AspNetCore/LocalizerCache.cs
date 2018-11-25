using System;
using System.Collections.Generic;
using System.Globalization;

namespace Phema.Localization
{
	internal class LocalizerCache
	{
		private static readonly IDictionary<CultureInfo, ILocalizer> cache;
		
		public static ILocalizer GetFromCache(CultureInfo cultureInfo, IServiceProvider provider, LocalizationOptions options)
		{
			if (!cache.TryGetValue(cultureInfo, out var localizer))
			{
				cache.Add(
					cultureInfo,
					localizer = new Localizer(cultureInfo, new ProviderLocalizationProvider(provider, options)));
			}
			
			return localizer;
		}

		static LocalizerCache()
		{
			cache = new Dictionary<CultureInfo, ILocalizer>();
		}
	}
}