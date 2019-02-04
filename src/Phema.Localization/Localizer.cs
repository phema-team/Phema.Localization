using System;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace Phema.Localization
{
	internal sealed class Localizer : ILocalizer
	{
		private readonly IServiceProvider provider;
		private readonly LocalizationOptions options;
		
		public Localizer(
			IServiceProvider provider,
			IOptions<LocalizationOptions> options)
		{
			this.provider = provider;
			this.options = options.Value;
		}

		public LocalizationMessage Localize<TComponent>(Func<TComponent, ILocalizationTemplate> selector, object[] arguments)
			where TComponent : ILocalizationComponent
		{
			var cultureInfo = CultureInfo.CurrentCulture;
			
			var template = Localize(cultureInfo, selector);
			
			return new LocalizationMessage(template.GetMessage(cultureInfo, arguments));
		}

		private ILocalizationTemplate Localize<TComponent>(CultureInfo cultureInfo, Func<TComponent, ILocalizationTemplate> selector) 
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