using System;

namespace Phema.Localization
{
	public static class LocalizerExtensions
	{
		/// <inheritdoc cref="ILocalizer.Localize{TComponent}"/>
		public static string Localize<TComponent>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate> selector)
				where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, Array.Empty<object>());
		}
		
		/// <inheritdoc cref="ILocalizer.Localize{TComponent}"/>
		public static string Localize<TComponent, TArgument>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate<TArgument>> selector, 
			TArgument argument)
				where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, new object[] { argument });
		}
		
		/// <inheritdoc cref="ILocalizer.Localize{TComponent}"/>
		public static string Localize<TComponent, TArgument1, TArgument2>(
			this ILocalizer localizer, 
			Func<TComponent, LocalizationTemplate<TArgument1, TArgument2>> selector, 
			TArgument1 argument1, 
			TArgument2 argument2)
				where TComponent : ILocalizationComponent
		{
			return localizer.Localize(selector, new object[] { argument1, argument2 });
		}
		
		/// <inheritdoc cref="ILocalizer.Localize{TComponent}"/>
		public static string Localize<TComponent, TArgument1, TArgument2, TArgument3>(
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