using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Xunit;

namespace Phema.Localization.Tests
{
	public class ProviderLocalizerTests
	{
		private class TestModel
		{
		}
		
		private interface ITestModelLocalizationComponent : ILocalizationComponent<TestModel>
		{
			LocalizationTemplate TestTemplate { get; }
		}

		private sealed class InvariantTestModelLocalizationComponent : ITestModelLocalizationComponent
		{
			public InvariantTestModelLocalizationComponent()
			{
				TestTemplate = new LocalizationTemplate("template");
			}
			
			public LocalizationTemplate TestTemplate { get; }
		}
		
		private sealed class EnglishTestModelLocalizationComponent : ITestModelLocalizationComponent
		{
			public EnglishTestModelLocalizationComponent()
			{
				TestTemplate = new LocalizationTemplate("english template");
			}
			
			public LocalizationTemplate TestTemplate { get; }
		}
		
		[Fact]
		public void ProviderLocalizer()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization => localization.AddCulture(CultureInfo.InvariantCulture, culture =>
				culture.AddComponent<TestModel, ITestModelLocalizationComponent, InvariantTestModelLocalizationComponent>()));

			services.Configure<RequestLocalizationOptions>(options => options.DefaultRequestCulture = new RequestCulture(CultureInfo.InvariantCulture));

			var provider = services.BuildServiceProvider();

			var localizer = Assert.IsType<Localizer>(provider.GetRequiredService<ILocalizer>());

			CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
			var message = localizer.Localize<ITestModelLocalizationComponent>(c => c.TestTemplate);

			Assert.Equal("template", message);
		}
		
		[Fact]
		public void ProviderLocalizerGetsCultureFromHttpHeaderIfExists()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
			{
				localization.AddCulture(CultureInfo.InvariantCulture, culture =>
					culture.AddComponent<TestModel, ITestModelLocalizationComponent, InvariantTestModelLocalizationComponent>());
				
				localization.AddCulture(CultureInfo.GetCultureInfo("en"), culture =>
					culture.AddComponent<TestModel, ITestModelLocalizationComponent, EnglishTestModelLocalizationComponent>());
			});

			services.Configure<RequestLocalizationOptions>(options => options.DefaultRequestCulture = new RequestCulture(CultureInfo.InvariantCulture));

			var provider = services.BuildServiceProvider();

			var localizer = Assert.IsType<Localizer>(provider.GetRequiredService<ILocalizer>());

			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en");
			
			var message = localizer.Localize<ITestModelLocalizationComponent>(c => c.TestTemplate);

			Assert.Equal("english template", message);
		}

		[Fact]
		public void OptionsThrowsIfDefaultCultureNotRegistered()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
			{
				localization.AddCulture(CultureInfo.InvariantCulture, culture =>
					culture.AddComponent<TestModel, ITestModelLocalizationComponent, InvariantTestModelLocalizationComponent>());
			});

			services.Configure<RequestLocalizationOptions>(o => o.DefaultRequestCulture = new RequestCulture(CultureInfo.GetCultureInfo("en")));

			var provider = services.BuildServiceProvider();

			provider.GetRequiredService<ILocalizer>();

			var options = provider.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
			
			Assert.Equal(CultureInfo.InvariantCulture, options.DefaultRequestCulture.Culture);
		}
	}
}