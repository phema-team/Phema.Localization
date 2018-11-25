using System;
using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizer
	{
		string Localize<TComponent>(Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent;
	}
	
	public class Localizer : ILocalizer
	{
		private readonly CultureInfo culture;
		private readonly ILocalizationProvider provider;

		public Localizer(CultureInfo culture, ILocalizationProvider provider)
		{
			this.culture = culture;
			this.provider = provider;
		}
		
		public string Localize<TComponent>(Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent
		{
			return provider.Localize(culture, selector);
		}
	}
}