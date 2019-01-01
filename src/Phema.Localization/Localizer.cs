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
			var cultureInfo = TryGetCultureInfo();
			
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
		
		private CultureInfo TryGetCultureInfo()
		{
			var httpContext = provider.GetRequiredService<IHttpContextAccessor>().HttpContext;

			if (httpContext == null)
			{
				return options.CultureInfo;
			}
			
			var acceptLanguage = httpContext.Request.Headers[HeaderNames.AcceptLanguage];

			if (acceptLanguage.Any())
			{
				var preferredCulture = acceptLanguage.FirstOrDefault();

				var foundCulture = CultureInfo.GetCultures(CultureTypes.AllCultures)
					.FirstOrDefault(cultureInfo => cultureInfo.Name == preferredCulture);

				return foundCulture ?? options.CultureInfo;
			}

			return options.CultureInfo;
		}
	}
}