using System;
using System.Globalization;

namespace Phema.Localization
{
	public static class LocalizationConfigurationExtensions
	{
		public static ILocalizationConfiguration AddInvariantCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo(""), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAfarCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("aa"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAfrikaansCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("af"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAghemCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("agq"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAkanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ak"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAmharicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("am"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddArabicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ar"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMapudungunCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("arn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAssameseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("as"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAsuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("asa"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAsturianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ast"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAzerbaijaniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("az"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBashkirCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ba"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBasaaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bas"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBelarusianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("be"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBembaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bem"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBenaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bez"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBulgarianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEdoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bin"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBamanankanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bm"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBanglaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTibetanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBretonCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("br"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBodoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("brx"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBosnianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bs"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBlinCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("byn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCatalanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ca"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddChechenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ce"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddChigaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cgg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCherokeeCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("chr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCorsicanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("co"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCzechCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cs"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddChurchSlavicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddWelshCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cy"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddDanishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("da"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTaitaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dav"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGermanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("de"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddZarmaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dje"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLowerSorbianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dsb"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddDualaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dua"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddDivehiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dv"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddJolaFonyiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dyo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddDzongkhaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dz"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEmbuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ebu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEweCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ee"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGreekCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("el"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEnglishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("en"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEsperantoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("eo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSpanishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("es"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEstonianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("et"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBasqueCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("eu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddEwondoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ewo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPersianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fa"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddFulahCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ff"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddFinnishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fi"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddFilipinoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fil"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddFaroeseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddFrenchCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddFriulianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fur"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddWesternFrisianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fy"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddIrishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ga"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddScottishGaelicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gd"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGalicianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gl"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGuaraniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSwissGermanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gsw"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGujaratiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGusiiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("guz"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddManxCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gv"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddHausaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ha"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddHawaiianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("haw"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddHebrewCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("he"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddHindiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hi"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCroatianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddUpperSorbianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hsb"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddHungarianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddArmenianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hy"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddInterlinguaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ia"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddIbibioCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ibb"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddIndonesianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("id"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddIgboCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ig"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddYiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ii"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddIcelandicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("is"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddItalianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("it"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddInuktitutCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("iu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddJapaneseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ja"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNgombaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("jgo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMachameCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("jmc"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddJavaneseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("jv"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGeorgianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ka"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKabyleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kab"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKambaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kam"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMakondeCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kde"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKabuverdianuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kea"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKoyraChiiniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("khq"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKikuyuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ki"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKazakhCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kk"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKakoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kkj"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGreenlandicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kl"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKalenjinCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kln"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKhmerCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("km"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKannadaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKoreanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ko"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKonkaniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kok"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKanuriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKashmiriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ks"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddShambalaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ksb"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBafiaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ksf"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddColognianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ksh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCentralKurdishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ku"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCornishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kw"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKyrgyzCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ky"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLatinCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("la"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLangiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lag"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLuxembourgishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lb"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddGandaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLakotaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lkt"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLingalaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ln"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLaoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNorthernLuriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lrc"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLithuanianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lt"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLubaKatangaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lu"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLuoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("luo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLuyiaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("luy"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLatvianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lv"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMasaiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mas"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMeruCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mer"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMorisyenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mfe"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMalagasyCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMakhuwaMeettoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mgh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMetaʼCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mgo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMaoriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mi"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMacedonianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mk"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMalayalamCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ml"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMongolianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddManipuriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mni"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMohawkCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("moh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMarathiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMalayCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ms"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMalteseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mt"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMundangCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mua"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddBurmeseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("my"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddMazanderaniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mzn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNamaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("naq"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNorwegianBokmålCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nb"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNorthNdebeleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nd"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddLowGermanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nds"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNepaliCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ne"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddDutchCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nl"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKwasioCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nmg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNorwegianNynorskCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNgiemboonCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nnh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNorwegianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("no"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSouthNdebeleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNuerCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nus"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNyankoleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nyn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddOccitanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("oc"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddOromoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("om"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddOdiaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("or"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddOsseticCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("os"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPunjabiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pa"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPapiamentoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pap"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPolishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pl"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPrussianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("prg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddDariCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("prs"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPashtoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ps"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddPortugueseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pt"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddQuechuaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("quz"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddRomanshCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rm"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddRundiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddRomanianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ro"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddRomboCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rof"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddRussianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ru"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKinyarwandaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rw"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddRwaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rwk"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSanskritCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sa"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSakhaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sah"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSamburuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("saq"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSanguCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sbp"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSindhiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sd"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddNorthernSamiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("se"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSenaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("seh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKoyraboroSenniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ses"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSangoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTachelhitCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("shi"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSinhalaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("si"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSlovakCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sk"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSlovenianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sl"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSamiSouthernCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sma"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSamiLuleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("smj"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSamiInariCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("smn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSamiSkoltCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sms"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddShonaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSomaliCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("so"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddAlbanianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sq"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSerbianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddsiSwatiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ss"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSahoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ssy"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSesothoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("st"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSwedishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sv"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddKiswahiliCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sw"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSyriacCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("syr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTamilCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ta"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTeluguCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("te"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTesoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("teo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTajikCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tg"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddThaiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("th"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTigrinyaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ti"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTigreCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tig"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTurkmenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tk"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSetswanaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tn"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTonganCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("to"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTurkishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tr"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTsongaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ts"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTatarCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tt"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddTasawaqCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("twq"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddCentralAtlasTamazightCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tzm"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddUyghurCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ug"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddUkrainianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("uk"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddUrduCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ur"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddUzbekCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("uz"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddVaiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vai"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddVendaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ve"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddVietnameseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vi"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddVolapükCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddVunjoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vun"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddWalserCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("wae"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddWolayttaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("wal"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddWolofCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("wo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddisiXhosaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("xh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddSogaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("xog"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddYangbenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("yav"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddYiddishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("yi"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddYorubaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("yo"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddStandardMoroccanTamazightCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("zgh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddChineseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("zh"), culture);
			return configuration;
		}

		public static ILocalizationConfiguration AddisiZuluCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("zu"), culture);
			return configuration;
		}
	}
}