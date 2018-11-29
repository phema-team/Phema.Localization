using System;
using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizer
	{
		LocalizationMessage Localize<TComponent>(Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent;
	}

	public sealed class Localizer : ILocalizer
	{
		private readonly CultureInfo cultureInfo;
		private readonly ILocalizationProvider provider;

		public Localizer(CultureInfo cultureInfo, ILocalizationProvider provider)
		{
			this.cultureInfo = cultureInfo;
			this.provider = provider;
		}

		
		public LocalizationMessage Localize<TComponent>(Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent
		{
			return provider.Localize(cultureInfo, selector);
		}
	}
}