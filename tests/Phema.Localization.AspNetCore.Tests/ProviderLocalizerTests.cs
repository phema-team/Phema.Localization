using System.Globalization;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Xunit;

namespace Phema.Localization.Tests.AspNetCore
{
	public class ProviderLocalizerTests
	{
		private class TestModel
		{
		}
		
		private interface ITestModelLocalizationComponent : ILocalizationComponent<TestModel>
		{
			LocalizationMessage TestMessage { get; }
		}

		private sealed class InvariantTestModelLocalizationComponent : ITestModelLocalizationComponent
		{
			public InvariantTestModelLocalizationComponent()
			{
				TestMessage = new LocalizationMessage("template");
			}
			
			public LocalizationMessage TestMessage { get; }
		}
		
		private sealed class EnglishTestModelLocalizationComponent : ITestModelLocalizationComponent
		{
			public EnglishTestModelLocalizationComponent()
			{
				TestMessage = new LocalizationMessage("english template");
			}
			
			public LocalizationMessage TestMessage { get; }
		}
		
		[Fact]
		public void ProviderLocalizer()
		{
			var services = new ServiceCollection();

			services.AddLocalization(localization => localization.AddCulture(CultureInfo.InvariantCulture, culture =>
				culture.AddComponent<TestModel, ITestModelLocalizationComponent, InvariantTestModelLocalizationComponent>()));

			services.Configure<LocalizationOptions>(options => options.CultureInfo = CultureInfo.InvariantCulture);

			services.AddScoped<IHttpContextAccessor>(sp => new HttpContextAccessor
			{
				HttpContext = new DefaultHttpContext()
			});
			
			var provider = services.BuildServiceProvider();

			var localizer = Assert.IsType<ProviderLocalizer>(provider.GetRequiredService<ILocalizer>());

			var message = localizer.Localize<ITestModelLocalizationComponent>(c => c.TestMessage);

			Assert.Equal("template", message);
		}
		
		[Fact]
		public void ProviderLocalizerGetsCultureFromHttpHeaderIfExists()
		{
			var services = new ServiceCollection();

			services.AddLocalization(localization =>
			{
				localization.AddCulture(CultureInfo.InvariantCulture, culture =>
					culture.AddComponent<TestModel, ITestModelLocalizationComponent, InvariantTestModelLocalizationComponent>());
				
				localization.AddCulture(CultureInfo.GetCultureInfo("en"), culture =>
					culture.AddComponent<TestModel, ITestModelLocalizationComponent, EnglishTestModelLocalizationComponent>());
			});

			services.Configure<LocalizationOptions>(options => options.CultureInfo = CultureInfo.InvariantCulture);

			services.AddScoped<IHttpContextAccessor>(sp => new HttpContextAccessor
			{
				HttpContext = new DefaultHttpContext
				{
					Request =
					{
						Headers =
						{
							[HeaderNames.AcceptLanguage] = "en"
						}
					}
				}
			});
			
			var provider = services.BuildServiceProvider();

			var localizer = Assert.IsType<ProviderLocalizer>(provider.GetRequiredService<ILocalizer>());

			var message = localizer.Localize<ITestModelLocalizationComponent>(c => c.TestMessage);

			Assert.Equal("english template", message);
		}

		[Fact]
		public void OptionsThrowsIfDefaultCultureNotRegistered()
		{
			var services = new ServiceCollection();

			services.AddLocalization(localization =>
			{
				localization.AddCulture(CultureInfo.InvariantCulture, culture =>
					culture.AddComponent<TestModel, ITestModelLocalizationComponent, InvariantTestModelLocalizationComponent>());
			});

			services.Configure<LocalizationOptions>(options => options.CultureInfo = CultureInfo.GetCultureInfo("en"));

			var provider = services.BuildServiceProvider();
			
			var exception = Assert.Throws<LocalizationException>(() => provider.GetRequiredService<ILocalizer>());
			
			Assert.Equal(CultureInfo.GetCultureInfo("en"), exception.CultureInfo);
		}
	}
}