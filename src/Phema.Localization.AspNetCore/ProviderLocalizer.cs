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
		private readonly IServiceProvider serviceProvider;
		private readonly LocalizationOptions options;
		private readonly ILocalizationProvider localizationProvider;
		
		public ProviderLocalizer(
			IServiceProvider serviceProvider,
			IOptions<LocalizationOptions> options,
			ILocalizationProvider localizationProvider)
		{
			this.options = options.Value;
			this.serviceProvider = serviceProvider;
			this.localizationProvider = localizationProvider;
		}

		public LocalizationMessage Localize<TComponent>(Func<TComponent, ILocalizationTemplate> selector, object[] arguments)
			where TComponent : ILocalizationComponent
		{
			var cultureInfo = TryGetCultureInfo();
			
			var template = localizationProvider.Localize(cultureInfo, selector);
			
			return new LocalizationMessage(template.GetMessage(cultureInfo, arguments));
		}
		
		private CultureInfo TryGetCultureInfo()
		{
			var httpContext = serviceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext;

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