using System;
using System.Globalization;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Xunit;

namespace Phema.Localization.Tests
{
	public class LocalizerModel
	{
		public string Name { get; set; }
	}
	
	public class PersonModel
	{
		public string Address { get; set; }
	}

	public interface ILocalizerModelComponent : ILocalizationComponent<LocalizerModel>
	{
		LocalizationTemplate NameMustBeSet { get; }
	}
	
	public interface IPersonModelComponent : ILocalizationComponent<PersonModel>
	{
		LocalizationTemplate AddressMustBeSet { get; }
	}
	
	public class RussianPersonModelComponent : IPersonModelComponent
	{
		public RussianPersonModelComponent()
		{
			AddressMustBeSet = new LocalizationTemplate("Адрес должен быть задан");
		}
		
		public LocalizationTemplate AddressMustBeSet { get; }
	}
	
	public class RussianLocalizerModelComponent : ILocalizerModelComponent
	{
		public RussianLocalizerModelComponent()
		{
			NameMustBeSet = new LocalizationTemplate("Имя должно быть задано");
		}
		
		public LocalizationTemplate NameMustBeSet { get; }
	}
	
	public class EnglishLocalizerModelComponent : ILocalizerModelComponent
	{
		public EnglishLocalizerModelComponent()
		{
			NameMustBeSet = new LocalizationTemplate("Name must be set");
		}
		
		public LocalizationTemplate NameMustBeSet { get; }
	}
	
	public class LocalizerTests
	{
		[Fact]
		public void Ru_NotResolvableCultureFallbacksToDefault()
		{
			var provider = ConfigureForCulture("ru");
			var localizer = provider.GetRequiredService<ILocalizer>();

			var nameMustBeSet = localizer.Localize<ILocalizerModelComponent>(c => c.NameMustBeSet);
			Assert.Equal("Имя должно быть задано", nameMustBeSet);

			var addressMustBeSet = localizer.Localize<IPersonModelComponent>(c => c.AddressMustBeSet);
			Assert.Equal("Адрес должен быть задан", addressMustBeSet);
		}
		
		[Fact]
		public void En_NotResolvableCultureFallbacksToDefault()
		{
			var provider = ConfigureForCulture("en");
			var localizer = provider.GetRequiredService<ILocalizer>();

			var nameMustBeSet = localizer.Localize<ILocalizerModelComponent>(c => c.NameMustBeSet);
			Assert.Equal("Name must be set", nameMustBeSet);

			var addressMustBeSet = localizer.Localize<IPersonModelComponent>(c => c.AddressMustBeSet);
			Assert.Equal("Адрес должен быть задан", addressMustBeSet);
		}

		[Fact]
		public void Fr_NotResolvableCultureFallbacksToDefault()
		{
			var provider = ConfigureForCulture("fr");
			var localizer = provider.GetRequiredService<ILocalizer>();

			var nameMustBeSet = localizer.Localize<ILocalizerModelComponent>(c => c.NameMustBeSet);
			Assert.Equal("Имя должно быть задано", nameMustBeSet);

			var addressMustBeSet = localizer.Localize<IPersonModelComponent>(c => c.AddressMustBeSet);
			Assert.Equal("Адрес должен быть задан", addressMustBeSet);
		}

		private IServiceProvider ConfigureForCulture(string cultureInfo)
		{
			return new ServiceCollection()
				.AddPhemaLocalization(configuration =>
				{
					configuration.AddCulture(CultureInfo.GetCultureInfo("ru"), culture =>
					{
						culture.AddComponent<LocalizerModel, ILocalizerModelComponent, RussianLocalizerModelComponent>();
						culture.AddComponent<PersonModel, IPersonModelComponent, RussianPersonModelComponent>();
					});
					
					configuration.AddCulture(CultureInfo.GetCultureInfo("en"), culture =>
					{
						culture.AddComponent<LocalizerModel, ILocalizerModelComponent, EnglishLocalizerModelComponent>();
					});
				})
				.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(sp => new HttpContextAccessor
				{
					HttpContext = new DefaultHttpContext
					{
						Request =
						{
							Headers =
							{
								[HeaderNames.AcceptLanguage] = cultureInfo
							}
						}
					}
				})
				.BuildServiceProvider();
		}
	}
}