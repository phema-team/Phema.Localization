using System;

namespace Phema.Localization
{
	public static class LocalizerExtensions
	{
		public static LocalizationMessage Localize<TComponent>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate> selector)
			where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, Array.Empty<object>());
		}
		
		public static LocalizationMessage Localize<TComponent, TArgument>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate<TArgument>> selector, 
			TArgument argument)
			where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, new object[] { argument });
		}
		
		public static LocalizationMessage Localize<TComponent, TArgument1, TArgument2>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate<TArgument1, TArgument2>> selector, 
			TArgument1 argument1, 
			TArgument2 argument2)
			where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, new object[] { argument1, argument2 });
		}
		
		public static LocalizationMessage Localize<TComponent, TArgument1, TArgument2, TArgument3>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate<TArgument1, TArgument2, TArgument3>> selector, 
			TArgument1 argument1, 
			TArgument2 argument2,
			TArgument3 argument3)
			where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, new object[] { argument1, argument2, argument3 });
		}
	}
}