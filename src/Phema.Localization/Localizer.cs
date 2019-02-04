using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class Localizer : ILocalizer
	{
		private readonly IServiceProvider serviceProvider;
		private readonly PhemaLocalizationOptions localizationOptions;
		private readonly RequestLocalizationOptions requestOptions;

		public Localizer(
			IServiceProvider serviceProvider,
			IOptions<PhemaLocalizationOptions> localizationOptions,
			IOptions<RequestLocalizationOptions> requestOptions)
		{
			this.serviceProvider = serviceProvider;
			this.localizationOptions = localizationOptions.Value;
			this.requestOptions = requestOptions.Value;
		}
		
		public string Localize<TComponent>(Func<TComponent, ILocalizationTemplate> selector, object[] arguments) 
			where TComponent : ILocalizationComponent
		{
			return Localize(CultureInfo.CurrentCulture, selector, arguments)
				?? Localize(requestOptions.DefaultRequestCulture.Culture, selector, arguments);
		}

		private string Localize<TComponent>(
			CultureInfo cultureInfo,
			Func<TComponent, ILocalizationTemplate> selector,
			object[] arguments)
			where TComponent : ILocalizationComponent
		{
			if (!localizationOptions.Components.TryGetValue(cultureInfo, out var components)) 
				return null;
			
			if (!components.TryGetValue(typeof(TComponent), out var factory))
				return null;
			
			var component = (TComponent) factory(serviceProvider);

			return selector(component).GetMessage(cultureInfo, arguments);
		}
	}
}