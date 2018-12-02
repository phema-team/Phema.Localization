using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace Phema.Localization.Tests
{
	public class UnitTest1
	{
		private interface ITestComponent : ILocalizationComponent
		{
			LocalizationTemplate Template { get; }
		}
		
		private class EnglishTestComponent : ITestComponent
		{
			public LocalizationTemplate Template => new LocalizationTemplate("template");
		}
		
		private class InvariantTestComponent : ITestComponent
		{
			public LocalizationTemplate Template => new LocalizationTemplate("invariant");
		}
		
		[Fact]
		public void SelectedCultureAndMessage()
		{
			var map = new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>
			{
				[CultureInfo.GetCultureInfo("en")] = new Dictionary<Type, Func<ILocalizationComponent>>
				{
					[typeof(ITestComponent)] = () => new EnglishTestComponent()
				}
			};
			
			var localizer = new Localizer(CultureInfo.GetCultureInfo("en"), new LocalizationProvider(map));

			var result = localizer.Localize<ITestComponent>(c => c.Template, null);

			Assert.Equal("template", result);
		}
		
		[Fact]
		public void ThrowsIfNotFound()
		{
			var map = new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>
			{
				[CultureInfo.GetCultureInfo("en")] = new Dictionary<Type, Func<ILocalizationComponent>>
				{
					[typeof(ITestComponent)] = () => new EnglishTestComponent()
				}
			};
			
			var localizer = new Localizer(CultureInfo.InvariantCulture, new LocalizationProvider(map));

			var exception = Assert.Throws<LocalizationException>(() => localizer.Localize<ITestComponent>(c => c.Template, null));
			
			Assert.Equal(CultureInfo.InvariantCulture, exception.CultureInfo);
			Assert.Equal(typeof(ITestComponent), exception.Component);
		}
		
		[Fact]
		public void SelectedCultureAndMessageInvariant()
		{
			var map = new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>
			{
				[CultureInfo.GetCultureInfo("en")] = new Dictionary<Type, Func<ILocalizationComponent>>
				{
					[typeof(ITestComponent)] = () => new EnglishTestComponent()
				},
				[CultureInfo.InvariantCulture] = new Dictionary<Type, Func<ILocalizationComponent>>
				{
					[typeof(ITestComponent)] = () => new InvariantTestComponent()
				}
			};

			var provider = new LocalizationProvider(map);
			
			var invariantLocalizer = new Localizer(CultureInfo.InvariantCulture, provider);

			var invariantResult = invariantLocalizer.Localize<ITestComponent>(c => c.Template, null);

			Assert.Equal("invariant", invariantResult);
			
			var englishLocalizer = new Localizer(CultureInfo.GetCultureInfo("en"), provider);

			var message = englishLocalizer.Localize<ITestComponent>(c => c.Template, null);

			Assert.Equal("template", message);
		}
	}
}