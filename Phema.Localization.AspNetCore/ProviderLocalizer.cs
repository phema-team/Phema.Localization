using System;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace Phema.Localization
{
	internal class ProviderLocalizer : ILocalizer
	{
		private readonly IServiceProvider provider;
		private readonly LocalizationOptions options;

		public ProviderLocalizer(IServiceProvider provider, IOptions<LocalizationOptions> options)
		{
			this.provider = provider;
			this.options = options.Value;
		}
		
		public string Localize<TComponent>(Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent
		{
			var httpContext = provider.GetRequiredService<IHttpContextAccessor>().HttpContext;
			var acceptLanguage = httpContext.Request.Headers[HeaderNames.AcceptLanguage];

			var culture = acceptLanguage.Any() 
				? CultureInfo.GetCultureInfo(acceptLanguage.Single()) 
				: options.CultureInfo;

			return LocalizerCache.GetFromCache(culture, provider, options).Localize(selector);
		}
	}
}