using System;
using System.Globalization;

namespace Phema.Localization
{
	internal class ProviderLocalizationProvider : ILocalizationProvider
	{
		private readonly IServiceProvider provider;
		private readonly LocalizationOptions options;

		public ProviderLocalizationProvider(IServiceProvider provider, LocalizationOptions options)
		{
			this.provider = provider;
			this.options = options;
		}
		
		public LocalizationMessage Localize<TComponent>(CultureInfo culture, Func<TComponent, LocalizationMessage> selector) 
			where TComponent : ILocalizationComponent
		{
			if (options.Localization.TryGetValue(culture, out var map))
			{
				if (map.TryGetValue(typeof(TComponent), out var factory))
				{
					var component = (TComponent) factory(provider);

					return selector(component);
				}
			}
			
			throw new LocalizationException(culture, typeof(TComponent));
		}
	}
}