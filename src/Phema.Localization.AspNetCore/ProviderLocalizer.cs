using System;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace Phema.Localization
{
	internal sealed class ProviderLocalizer : ILocalizer
	{
		private readonly IServiceProvider provider;
		private readonly LocalizationOptions options;

		public ProviderLocalizer(IServiceProvider provider, IOptions<LocalizationOptions> options)
		{
			this.provider = provider;
			this.options = options.Value;
		}

		public LocalizationMessage Localize<TComponent>(Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent
		{
			return LocalizerCache.GetFromCache(TryGetCultureInfo(), provider, options).Localize(selector);
		}
		
		private CultureInfo TryGetCultureInfo()
		{
			var httpContext = provider.GetRequiredService<IHttpContextAccessor>().HttpContext;

			if (httpContext == null)
			{
				return options.CultureInfo;
			}
			
			var acceptLanguage = httpContext.Request.Headers[HeaderNames.AcceptLanguage];

			return acceptLanguage.Any() 
				? CultureInfo.GetCultureInfo(acceptLanguage.Single()) 
				: options.CultureInfo;
		}
	}
}