using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace Phema.Localization.Tests
{
	public class LocalizationProviderTests
	{
		private interface ITestLocalizationProviderComponent : ILocalizationComponent
		{
			LocalizationTemplate TestTemplate { get; }
		}
		
		private class TestLocalizationProviderComponent : ITestLocalizationProviderComponent
		{
			public TestLocalizationProviderComponent()
			{
				TestTemplate = new LocalizationTemplate("template");
			}
			
			public LocalizationTemplate TestTemplate { get; }
		}

		[Fact]
		public void LocalizationProviderThrowsIfNoCulture()
		{
			var provider = new LocalizationProvider(new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>());

			var exception = Assert.Throws<LocalizationException>(() =>
				provider.Localize<ITestLocalizationProviderComponent>(CultureInfo.InvariantCulture, c => c.TestTemplate));
			
			Assert.Equal(CultureInfo.InvariantCulture, exception.CultureInfo);
			Assert.Equal(typeof(ITestLocalizationProviderComponent), exception.Component);
		}
		
		[Fact]
		public void LocalizationProviderThrowsIfNoComponentInCulture()
		{
			var provider = new LocalizationProvider(new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>
			{
				[CultureInfo.GetCultureInfo("en")] = new Dictionary<Type, Func<ILocalizationComponent>>
				{
					[typeof(ITestLocalizationProviderComponent)] = () => new TestLocalizationProviderComponent()
				}
			});

			var message = provider.Localize<ITestLocalizationProviderComponent>(
				CultureInfo.GetCultureInfo("en"),
				c => c.TestTemplate);
			
			Assert.Equal("template", message.GetMessage(CultureInfo.GetCultureInfo("en"), null));
			
			var exception = Assert.Throws<LocalizationException>(() =>
				provider.Localize<ITestLocalizationProviderComponent>(CultureInfo.InvariantCulture, c => c.TestTemplate));
			
			Assert.Equal(CultureInfo.InvariantCulture, exception.CultureInfo);
			Assert.Equal(typeof(ITestLocalizationProviderComponent), exception.Component);
		}
	}
}