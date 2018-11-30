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
			LocalizationMessage TestMessage { get; }
		}
		
		private class TestLocalizationProviderComponent : ITestLocalizationProviderComponent
		{
			public TestLocalizationProviderComponent()
			{
				TestMessage = new LocalizationMessage("template");
			}
			
			public LocalizationMessage TestMessage { get; }
		}

		[Fact]
		public void LocalizationProviderThrowsIfNoCulture()
		{
			var provider = new LocalizationProvider(new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>());

			var exception = Assert.Throws<LocalizationException>(() =>
				provider.Localize<ITestLocalizationProviderComponent>(CultureInfo.InvariantCulture, c => c.TestMessage));
			
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
				c => c.TestMessage);
			
			Assert.Equal("template", message);
			
			var exception = Assert.Throws<LocalizationException>(() =>
				provider.Localize<ITestLocalizationProviderComponent>(CultureInfo.InvariantCulture, c => c.TestMessage));
			
			Assert.Equal(CultureInfo.InvariantCulture, exception.CultureInfo);
			Assert.Equal(typeof(ITestLocalizationProviderComponent), exception.Component);
		}
	}
}