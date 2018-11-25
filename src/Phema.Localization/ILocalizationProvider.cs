using System;
using System.Collections.Generic;
using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizationProvider
	{
		LocalizationMessage Localize<TComponent>(CultureInfo culture, Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent;
	}
	
	public class LocalizationProvider : ILocalizationProvider
	{
		private readonly IDictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>> localization;

		public LocalizationProvider(IDictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>> localization)
		{
			this.localization = localization;
		}

		public LocalizationMessage Localize<TComponent>(CultureInfo culture, Func<TComponent, LocalizationMessage> selector)
			where TComponent : ILocalizationComponent
		{
			if (localization.TryGetValue(culture, out var map))
			{
				if (map.TryGetValue(typeof(TComponent), out var factory))
				{
					var component = (TComponent) factory();

					return selector(component);
				}
			}
			
			throw new LocalizationException(culture, typeof(TComponent));
		}
	}
}