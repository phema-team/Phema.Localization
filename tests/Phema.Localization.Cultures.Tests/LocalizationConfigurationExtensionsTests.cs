using System.Globalization;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Xunit;

namespace Phema.Localization.Cultures.Tests
{
	public class LocalizationConfigurationExtensionsTests
	{
		private class TestModel {}
		private interface ITestModelLocalizationComponent : ILocalizationComponent<TestModel> {}
		private class TestModelLocalizationComponent : ITestModelLocalizationComponent {}
		
		
		[Fact]
		public void TestInvariantCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddInvariantCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo(""), cultureInfo);
		}

		[Fact]
		public void TestAfarCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAfarCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("aa"), cultureInfo);
		}

		[Fact]
		public void TestAfrikaansCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAfrikaansCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("af"), cultureInfo);
		}

		[Fact]
		public void TestAghemCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAghemCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("agq"), cultureInfo);
		}

		[Fact]
		public void TestAkanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAkanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ak"), cultureInfo);
		}

		[Fact]
		public void TestAmharicCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAmharicCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("am"), cultureInfo);
		}

		[Fact]
		public void TestArabicCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddArabicCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ar"), cultureInfo);
		}

		[Fact]
		public void TestMapudungunCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMapudungunCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("arn"), cultureInfo);
		}

		[Fact]
		public void TestAssameseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAssameseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("as"), cultureInfo);
		}

		[Fact]
		public void TestAsuCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAsuCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("asa"), cultureInfo);
		}

		[Fact]
		public void TestAsturianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAsturianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ast"), cultureInfo);
		}

		[Fact]
		public void TestAzerbaijaniCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAzerbaijaniCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("az"), cultureInfo);
		}

		[Fact]
		public void TestBashkirCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBashkirCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ba"), cultureInfo);
		}

		[Fact]
		public void TestBasaaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBasaaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bas"), cultureInfo);
		}

		[Fact]
		public void TestBelarusianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBelarusianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("be"), cultureInfo);
		}

		[Fact]
		public void TestBembaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBembaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bem"), cultureInfo);
		}

		[Fact]
		public void TestBenaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBenaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bez"), cultureInfo);
		}

		[Fact]
		public void TestBulgarianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBulgarianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bg"), cultureInfo);
		}

		[Fact]
		public void TestEdoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEdoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bin"), cultureInfo);
		}

		[Fact]
		public void TestBamanankanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBamanankanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bm"), cultureInfo);
		}

		[Fact]
		public void TestBanglaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBanglaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bn"), cultureInfo);
		}

		[Fact]
		public void TestTibetanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTibetanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bo"), cultureInfo);
		}

		[Fact]
		public void TestBretonCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBretonCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("br"), cultureInfo);
		}

		[Fact]
		public void TestBodoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBodoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("brx"), cultureInfo);
		}

		[Fact]
		public void TestBosnianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBosnianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("bs"), cultureInfo);
		}

		[Fact]
		public void TestBlinCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBlinCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("byn"), cultureInfo);
		}

		[Fact]
		public void TestCatalanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCatalanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ca"), cultureInfo);
		}

		[Fact]
		public void TestChechenCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddChechenCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ce"), cultureInfo);
		}

		[Fact]
		public void TestChigaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddChigaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("cgg"), cultureInfo);
		}

		[Fact]
		public void TestCherokeeCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCherokeeCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("chr"), cultureInfo);
		}

		[Fact]
		public void TestCorsicanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCorsicanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("co"), cultureInfo);
		}

		[Fact]
		public void TestCzechCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCzechCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("cs"), cultureInfo);
		}

		[Fact]
		public void TestChurchSlavicCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddChurchSlavicCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("cu"), cultureInfo);
		}

		[Fact]
		public void TestWelshCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddWelshCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("cy"), cultureInfo);
		}

		[Fact]
		public void TestDanishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddDanishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("da"), cultureInfo);
		}

		[Fact]
		public void TestTaitaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTaitaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dav"), cultureInfo);
		}

		[Fact]
		public void TestGermanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGermanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("de"), cultureInfo);
		}

		[Fact]
		public void TestZarmaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddZarmaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dje"), cultureInfo);
		}

		[Fact]
		public void TestLowerSorbianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLowerSorbianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dsb"), cultureInfo);
		}

		[Fact]
		public void TestDualaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddDualaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dua"), cultureInfo);
		}

		[Fact]
		public void TestDivehiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddDivehiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dv"), cultureInfo);
		}

		[Fact]
		public void TestJolaFonyiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddJolaFonyiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dyo"), cultureInfo);
		}

		[Fact]
		public void TestDzongkhaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddDzongkhaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("dz"), cultureInfo);
		}

		[Fact]
		public void TestEmbuCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEmbuCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ebu"), cultureInfo);
		}

		[Fact]
		public void TestEweCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEweCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ee"), cultureInfo);
		}

		[Fact]
		public void TestGreekCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGreekCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("el"), cultureInfo);
		}

		[Fact]
		public void TestEnglishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEnglishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("en"), cultureInfo);
		}

		[Fact]
		public void TestEsperantoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEsperantoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("eo"), cultureInfo);
		}

		[Fact]
		public void TestSpanishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSpanishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("es"), cultureInfo);
		}

		[Fact]
		public void TestEstonianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEstonianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("et"), cultureInfo);
		}

		[Fact]
		public void TestBasqueCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBasqueCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("eu"), cultureInfo);
		}

		[Fact]
		public void TestEwondoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddEwondoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ewo"), cultureInfo);
		}

		[Fact]
		public void TestPersianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPersianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fa"), cultureInfo);
		}

		[Fact]
		public void TestFulahCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddFulahCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ff"), cultureInfo);
		}

		[Fact]
		public void TestFinnishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddFinnishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fi"), cultureInfo);
		}

		[Fact]
		public void TestFilipinoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddFilipinoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fil"), cultureInfo);
		}

		[Fact]
		public void TestFaroeseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddFaroeseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fo"), cultureInfo);
		}

		[Fact]
		public void TestFrenchCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddFrenchCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fr"), cultureInfo);
		}

		[Fact]
		public void TestFriulianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddFriulianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fur"), cultureInfo);
		}

		[Fact]
		public void TestWesternFrisianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddWesternFrisianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("fy"), cultureInfo);
		}

		[Fact]
		public void TestIrishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddIrishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ga"), cultureInfo);
		}

		[Fact]
		public void TestScottishGaelicCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddScottishGaelicCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("gd"), cultureInfo);
		}

		[Fact]
		public void TestGalicianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGalicianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("gl"), cultureInfo);
		}

		[Fact]
		public void TestGuaraniCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGuaraniCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("gn"), cultureInfo);
		}

		[Fact]
		public void TestSwissGermanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSwissGermanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("gsw"), cultureInfo);
		}

		[Fact]
		public void TestGujaratiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGujaratiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("gu"), cultureInfo);
		}

		[Fact]
		public void TestGusiiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGusiiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("guz"), cultureInfo);
		}

		[Fact]
		public void TestManxCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddManxCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("gv"), cultureInfo);
		}

		[Fact]
		public void TestHausaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddHausaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ha"), cultureInfo);
		}

		[Fact]
		public void TestHawaiianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddHawaiianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("haw"), cultureInfo);
		}

		[Fact]
		public void TestHebrewCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddHebrewCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("he"), cultureInfo);
		}

		[Fact]
		public void TestHindiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddHindiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("hi"), cultureInfo);
		}

		[Fact]
		public void TestCroatianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCroatianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("hr"), cultureInfo);
		}

		[Fact]
		public void TestUpperSorbianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddUpperSorbianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("hsb"), cultureInfo);
		}

		[Fact]
		public void TestHungarianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddHungarianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("hu"), cultureInfo);
		}

		[Fact]
		public void TestArmenianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddArmenianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("hy"), cultureInfo);
		}

		[Fact]
		public void TestInterlinguaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddInterlinguaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ia"), cultureInfo);
		}

		[Fact]
		public void TestIbibioCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddIbibioCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ibb"), cultureInfo);
		}

		[Fact]
		public void TestIndonesianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddIndonesianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("id"), cultureInfo);
		}

		[Fact]
		public void TestIgboCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddIgboCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ig"), cultureInfo);
		}

		[Fact]
		public void TestYiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddYiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ii"), cultureInfo);
		}

		[Fact]
		public void TestIcelandicCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddIcelandicCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("is"), cultureInfo);
		}

		[Fact]
		public void TestItalianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddItalianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("it"), cultureInfo);
		}

		[Fact]
		public void TestInuktitutCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddInuktitutCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("iu"), cultureInfo);
		}

		[Fact]
		public void TestJapaneseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddJapaneseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ja"), cultureInfo);
		}

		[Fact]
		public void TestNgombaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNgombaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("jgo"), cultureInfo);
		}

		[Fact]
		public void TestMachameCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMachameCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("jmc"), cultureInfo);
		}

		[Fact]
		public void TestJavaneseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddJavaneseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("jv"), cultureInfo);
		}

		[Fact]
		public void TestGeorgianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGeorgianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ka"), cultureInfo);
		}

		[Fact]
		public void TestKabyleCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKabyleCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kab"), cultureInfo);
		}

		[Fact]
		public void TestKambaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKambaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kam"), cultureInfo);
		}

		[Fact]
		public void TestMakondeCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMakondeCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kde"), cultureInfo);
		}

		[Fact]
		public void TestKabuverdianuCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKabuverdianuCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kea"), cultureInfo);
		}

		[Fact]
		public void TestKoyraChiiniCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKoyraChiiniCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("khq"), cultureInfo);
		}

		[Fact]
		public void TestKikuyuCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKikuyuCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ki"), cultureInfo);
		}

		[Fact]
		public void TestKazakhCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKazakhCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kk"), cultureInfo);
		}

		[Fact]
		public void TestKakoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKakoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kkj"), cultureInfo);
		}

		[Fact]
		public void TestGreenlandicCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGreenlandicCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kl"), cultureInfo);
		}

		[Fact]
		public void TestKalenjinCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKalenjinCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kln"), cultureInfo);
		}

		[Fact]
		public void TestKhmerCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKhmerCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("km"), cultureInfo);
		}

		[Fact]
		public void TestKannadaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKannadaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kn"), cultureInfo);
		}

		[Fact]
		public void TestKoreanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKoreanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ko"), cultureInfo);
		}

		[Fact]
		public void TestKonkaniCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKonkaniCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kok"), cultureInfo);
		}

		[Fact]
		public void TestKanuriCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKanuriCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kr"), cultureInfo);
		}

		[Fact]
		public void TestKashmiriCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKashmiriCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ks"), cultureInfo);
		}

		[Fact]
		public void TestShambalaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddShambalaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ksb"), cultureInfo);
		}

		[Fact]
		public void TestBafiaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBafiaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ksf"), cultureInfo);
		}

		[Fact]
		public void TestColognianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddColognianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ksh"), cultureInfo);
		}

		[Fact]
		public void TestCentralKurdishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCentralKurdishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ku"), cultureInfo);
		}

		[Fact]
		public void TestCornishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCornishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("kw"), cultureInfo);
		}

		[Fact]
		public void TestKyrgyzCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKyrgyzCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ky"), cultureInfo);
		}

		[Fact]
		public void TestLatinCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLatinCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("la"), cultureInfo);
		}

		[Fact]
		public void TestLangiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLangiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lag"), cultureInfo);
		}

		[Fact]
		public void TestLuxembourgishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLuxembourgishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lb"), cultureInfo);
		}

		[Fact]
		public void TestGandaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddGandaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lg"), cultureInfo);
		}

		[Fact]
		public void TestLakotaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLakotaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lkt"), cultureInfo);
		}

		[Fact]
		public void TestLingalaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLingalaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ln"), cultureInfo);
		}

		[Fact]
		public void TestLaoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLaoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lo"), cultureInfo);
		}

		[Fact]
		public void TestNorthernLuriCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNorthernLuriCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lrc"), cultureInfo);
		}

		[Fact]
		public void TestLithuanianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLithuanianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lt"), cultureInfo);
		}

		[Fact]
		public void TestLubaKatangaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLubaKatangaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lu"), cultureInfo);
		}

		[Fact]
		public void TestLuoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLuoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("luo"), cultureInfo);
		}

		[Fact]
		public void TestLuyiaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLuyiaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("luy"), cultureInfo);
		}

		[Fact]
		public void TestLatvianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLatvianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("lv"), cultureInfo);
		}

		[Fact]
		public void TestMasaiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMasaiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mas"), cultureInfo);
		}

		[Fact]
		public void TestMeruCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMeruCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mer"), cultureInfo);
		}

		[Fact]
		public void TestMorisyenCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMorisyenCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mfe"), cultureInfo);
		}

		[Fact]
		public void TestMalagasyCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMalagasyCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mg"), cultureInfo);
		}

		[Fact]
		public void TestMakhuwaMeettoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMakhuwaMeettoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mgh"), cultureInfo);
		}

		[Fact]
		public void TestMetaʼCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMetaʼCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mgo"), cultureInfo);
		}

		[Fact]
		public void TestMaoriCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMaoriCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mi"), cultureInfo);
		}

		[Fact]
		public void TestMacedonianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMacedonianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mk"), cultureInfo);
		}

		[Fact]
		public void TestMalayalamCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMalayalamCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ml"), cultureInfo);
		}

		[Fact]
		public void TestMongolianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMongolianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mn"), cultureInfo);
		}

		[Fact]
		public void TestManipuriCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddManipuriCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mni"), cultureInfo);
		}

		[Fact]
		public void TestMohawkCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMohawkCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("moh"), cultureInfo);
		}

		[Fact]
		public void TestMarathiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMarathiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mr"), cultureInfo);
		}

		[Fact]
		public void TestMalayCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMalayCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ms"), cultureInfo);
		}

		[Fact]
		public void TestMalteseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMalteseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mt"), cultureInfo);
		}

		[Fact]
		public void TestMundangCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMundangCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mua"), cultureInfo);
		}

		[Fact]
		public void TestBurmeseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddBurmeseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("my"), cultureInfo);
		}

		[Fact]
		public void TestMazanderaniCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddMazanderaniCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("mzn"), cultureInfo);
		}

		[Fact]
		public void TestNamaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNamaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("naq"), cultureInfo);
		}

		[Fact]
		public void TestNorwegianBokmålCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNorwegianBokmålCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nb"), cultureInfo);
		}

		[Fact]
		public void TestNorthNdebeleCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNorthNdebeleCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nd"), cultureInfo);
		}

		[Fact]
		public void TestLowGermanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddLowGermanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nds"), cultureInfo);
		}

		[Fact]
		public void TestNepaliCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNepaliCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ne"), cultureInfo);
		}

		[Fact]
		public void TestDutchCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddDutchCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nl"), cultureInfo);
		}

		[Fact]
		public void TestKwasioCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKwasioCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nmg"), cultureInfo);
		}

		[Fact]
		public void TestNorwegianNynorskCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNorwegianNynorskCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nn"), cultureInfo);
		}

		[Fact]
		public void TestNgiemboonCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNgiemboonCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nnh"), cultureInfo);
		}

		[Fact]
		public void TestNorwegianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNorwegianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("no"), cultureInfo);
		}

		[Fact]
		public void TestSouthNdebeleCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSouthNdebeleCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nr"), cultureInfo);
		}

		[Fact]
		public void TestNuerCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNuerCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nus"), cultureInfo);
		}

		[Fact]
		public void TestNyankoleCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNyankoleCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("nyn"), cultureInfo);
		}

		[Fact]
		public void TestOccitanCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddOccitanCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("oc"), cultureInfo);
		}

		[Fact]
		public void TestOromoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddOromoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("om"), cultureInfo);
		}

		[Fact]
		public void TestOdiaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddOdiaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("or"), cultureInfo);
		}

		[Fact]
		public void TestOsseticCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddOsseticCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("os"), cultureInfo);
		}

		[Fact]
		public void TestPunjabiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPunjabiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("pa"), cultureInfo);
		}

		[Fact]
		public void TestPapiamentoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPapiamentoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("pap"), cultureInfo);
		}

		[Fact]
		public void TestPolishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPolishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("pl"), cultureInfo);
		}

		[Fact]
		public void TestPrussianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPrussianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("prg"), cultureInfo);
		}

		[Fact]
		public void TestDariCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddDariCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("prs"), cultureInfo);
		}

		[Fact]
		public void TestPashtoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPashtoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ps"), cultureInfo);
		}

		[Fact]
		public void TestPortugueseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddPortugueseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("pt"), cultureInfo);
		}

		[Fact]
		public void TestQuechuaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddQuechuaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("quz"), cultureInfo);
		}

		[Fact]
		public void TestRomanshCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddRomanshCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("rm"), cultureInfo);
		}

		[Fact]
		public void TestRundiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddRundiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("rn"), cultureInfo);
		}

		[Fact]
		public void TestRomanianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddRomanianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ro"), cultureInfo);
		}

		[Fact]
		public void TestRomboCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddRomboCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("rof"), cultureInfo);
		}

		[Fact]
		public void TestRussianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddRussianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ru"), cultureInfo);
		}

		[Fact]
		public void TestKinyarwandaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKinyarwandaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("rw"), cultureInfo);
		}

		[Fact]
		public void TestRwaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddRwaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("rwk"), cultureInfo);
		}

		[Fact]
		public void TestSanskritCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSanskritCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sa"), cultureInfo);
		}

		[Fact]
		public void TestSakhaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSakhaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sah"), cultureInfo);
		}

		[Fact]
		public void TestSamburuCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSamburuCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("saq"), cultureInfo);
		}

		[Fact]
		public void TestSanguCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSanguCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sbp"), cultureInfo);
		}

		[Fact]
		public void TestSindhiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSindhiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sd"), cultureInfo);
		}

		[Fact]
		public void TestNorthernSamiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddNorthernSamiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("se"), cultureInfo);
		}

		[Fact]
		public void TestSenaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSenaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("seh"), cultureInfo);
		}

		[Fact]
		public void TestKoyraboroSenniCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKoyraboroSenniCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ses"), cultureInfo);
		}

		[Fact]
		public void TestSangoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSangoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sg"), cultureInfo);
		}

		[Fact]
		public void TestTachelhitCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTachelhitCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("shi"), cultureInfo);
		}

		[Fact]
		public void TestSinhalaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSinhalaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("si"), cultureInfo);
		}

		[Fact]
		public void TestSlovakCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSlovakCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sk"), cultureInfo);
		}

		[Fact]
		public void TestSlovenianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSlovenianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sl"), cultureInfo);
		}

		[Fact]
		public void TestSamiSouthernCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSamiSouthernCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sma"), cultureInfo);
		}

		[Fact]
		public void TestSamiLuleCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSamiLuleCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("smj"), cultureInfo);
		}

		[Fact]
		public void TestSamiInariCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSamiInariCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("smn"), cultureInfo);
		}

		[Fact]
		public void TestSamiSkoltCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSamiSkoltCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sms"), cultureInfo);
		}

		[Fact]
		public void TestShonaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddShonaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sn"), cultureInfo);
		}

		[Fact]
		public void TestSomaliCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSomaliCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("so"), cultureInfo);
		}

		[Fact]
		public void TestAlbanianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddAlbanianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sq"), cultureInfo);
		}

		[Fact]
		public void TestSerbianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSerbianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sr"), cultureInfo);
		}

		[Fact]
		public void TestsiSwatiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddsiSwatiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ss"), cultureInfo);
		}

		[Fact]
		public void TestSahoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSahoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ssy"), cultureInfo);
		}

		[Fact]
		public void TestSesothoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSesothoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("st"), cultureInfo);
		}

		[Fact]
		public void TestSwedishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSwedishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sv"), cultureInfo);
		}

		[Fact]
		public void TestKiswahiliCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddKiswahiliCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("sw"), cultureInfo);
		}

		[Fact]
		public void TestSyriacCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSyriacCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("syr"), cultureInfo);
		}

		[Fact]
		public void TestTamilCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTamilCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ta"), cultureInfo);
		}

		[Fact]
		public void TestTeluguCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTeluguCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("te"), cultureInfo);
		}

		[Fact]
		public void TestTesoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTesoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("teo"), cultureInfo);
		}

		[Fact]
		public void TestTajikCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTajikCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tg"), cultureInfo);
		}

		[Fact]
		public void TestThaiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddThaiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("th"), cultureInfo);
		}

		[Fact]
		public void TestTigrinyaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTigrinyaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ti"), cultureInfo);
		}

		[Fact]
		public void TestTigreCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTigreCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tig"), cultureInfo);
		}

		[Fact]
		public void TestTurkmenCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTurkmenCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tk"), cultureInfo);
		}

		[Fact]
		public void TestSetswanaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSetswanaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tn"), cultureInfo);
		}

		[Fact]
		public void TestTonganCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTonganCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("to"), cultureInfo);
		}

		[Fact]
		public void TestTurkishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTurkishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tr"), cultureInfo);
		}

		[Fact]
		public void TestTsongaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTsongaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ts"), cultureInfo);
		}

		[Fact]
		public void TestTatarCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTatarCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tt"), cultureInfo);
		}

		[Fact]
		public void TestTasawaqCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddTasawaqCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("twq"), cultureInfo);
		}

		[Fact]
		public void TestCentralAtlasTamazightCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddCentralAtlasTamazightCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("tzm"), cultureInfo);
		}

		[Fact]
		public void TestUyghurCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddUyghurCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ug"), cultureInfo);
		}

		[Fact]
		public void TestUkrainianCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddUkrainianCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("uk"), cultureInfo);
		}

		[Fact]
		public void TestUrduCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddUrduCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ur"), cultureInfo);
		}

		[Fact]
		public void TestUzbekCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddUzbekCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("uz"), cultureInfo);
		}

		[Fact]
		public void TestVaiCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddVaiCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("vai"), cultureInfo);
		}

		[Fact]
		public void TestVendaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddVendaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("ve"), cultureInfo);
		}

		[Fact]
		public void TestVietnameseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddVietnameseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("vi"), cultureInfo);
		}

		[Fact]
		public void TestVolapükCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddVolapükCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("vo"), cultureInfo);
		}

		[Fact]
		public void TestVunjoCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddVunjoCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("vun"), cultureInfo);
		}

		[Fact]
		public void TestWalserCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddWalserCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("wae"), cultureInfo);
		}

		[Fact]
		public void TestWolayttaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddWolayttaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("wal"), cultureInfo);
		}

		[Fact]
		public void TestWolofCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddWolofCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("wo"), cultureInfo);
		}

		[Fact]
		public void TestisiXhosaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddisiXhosaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("xh"), cultureInfo);
		}

		[Fact]
		public void TestSogaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddSogaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("xog"), cultureInfo);
		}

		[Fact]
		public void TestYangbenCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddYangbenCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("yav"), cultureInfo);
		}

		[Fact]
		public void TestYiddishCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddYiddishCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("yi"), cultureInfo);
		}

		[Fact]
		public void TestYorubaCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddYorubaCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("yo"), cultureInfo);
		}

		[Fact]
		public void TestStandardMoroccanTamazightCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddStandardMoroccanTamazightCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("zgh"), cultureInfo);
		}

		[Fact]
		public void TestChineseCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddChineseCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("zh"), cultureInfo);
		}

		[Fact]
		public void TestisiZuluCulture()
		{
			var services = new ServiceCollection();

			services.AddPhemaLocalization(localization =>
				localization.AddisiZuluCulture(culture => culture.AddComponent<ITestModelLocalizationComponent, TestModelLocalizationComponent>()));

			var provider = services.BuildServiceProvider();

			var options = provider.GetRequiredService<IOptions<LocalizationOptions>>().Value;

			var (cultureInfo, _) = options.Localization.Single();

			Assert.Equal(CultureInfo.GetCultureInfo("zu"), cultureInfo);
		}
	}
}