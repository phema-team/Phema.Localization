using System;
using System.Globalization;
using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class ProviderLocalizationProvider : ILocalizationProvider
	{
		private readonly IServiceProvider provider;
		private readonly LocalizationOptions options;

		public ProviderLocalizationProvider(IServiceProvider provider, IOptions<LocalizationOptions> options)
		{
			this.provider = provider;
			this.options = options.Value;
		}
		
		public LocalizationMessage Localize<TComponent>(CultureInfo cultureInfo, Func<TComponent, LocalizationMessage> selector) 
			where TComponent : ILocalizationComponent
		{
			if (options.Localization.TryGetValue(cultureInfo, out var map))
			{
				if (map.TryGetValue(typeof(TComponent), out var factory))
				{
					var component = (TComponent) factory(provider);

					return selector(component);
				}
			}

			return Localize(options.CultureInfo, selector);
		}
	}
}