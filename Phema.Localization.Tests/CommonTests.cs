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
			LocalizationMessage Message { get; }
		}
		
		private class EnglishTestComponent : ITestComponent
		{
			public LocalizationMessage Message => new LocalizationMessage("template");
		}
		
		private class InvariantTestComponent : ITestComponent
		{
			public LocalizationMessage Message => new LocalizationMessage("invariant");
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

			var message = localizer.Localize<ITestComponent>(c => c.Message);

			Assert.Equal("template", message);
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

			var exception = Assert.Throws<LocalizationException>(() => localizer.Localize<ITestComponent>(c => c.Message));
			
			Assert.Equal(CultureInfo.InvariantCulture, exception.Culture);
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
			
			var invariantLocalizer = new Localizer(CultureInfo.InvariantCulture, new LocalizationProvider(map));

			var invariantMessage = invariantLocalizer.Localize<ITestComponent>(c => c.Message);

			Assert.Equal("invariant", invariantMessage);
			
			var englishLocalizer = new Localizer(CultureInfo.GetCultureInfo("en"), new LocalizationProvider(map));

			var englishMessage = englishLocalizer.Localize<ITestComponent>(c => c.Message);

			Assert.Equal("template", englishMessage);
		}
	}
}