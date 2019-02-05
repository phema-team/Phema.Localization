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
			return configuration.AddCulture(CultureInfo.GetCultureInfo(""), culture);
		}

		public static ILocalizationConfiguration AddAfarCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("aa"), culture);
		}

		public static ILocalizationConfiguration AddAfrikaansCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("af"), culture);
		}

		public static ILocalizationConfiguration AddAghemCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("agq"), culture);
		}

		public static ILocalizationConfiguration AddAkanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ak"), culture);
		}

		public static ILocalizationConfiguration AddAmharicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("am"), culture);
		}

		public static ILocalizationConfiguration AddArabicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ar"), culture);
		}

		public static ILocalizationConfiguration AddMapudungunCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("arn"), culture);
		}

		public static ILocalizationConfiguration AddAssameseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("as"), culture);
		}

		public static ILocalizationConfiguration AddAsuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("asa"), culture);
		}

		public static ILocalizationConfiguration AddAsturianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ast"), culture);
		}

		public static ILocalizationConfiguration AddAzerbaijaniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("az"), culture);
		}

		public static ILocalizationConfiguration AddBashkirCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ba"), culture);
		}

		public static ILocalizationConfiguration AddBasaaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bas"), culture);
		}

		public static ILocalizationConfiguration AddBelarusianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("be"), culture);
		}

		public static ILocalizationConfiguration AddBembaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bem"), culture);
		}

		public static ILocalizationConfiguration AddBenaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bez"), culture);
		}

		public static ILocalizationConfiguration AddBulgarianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bg"), culture);
		}

		public static ILocalizationConfiguration AddEdoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bin"), culture);
		}

		public static ILocalizationConfiguration AddBamanankanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bm"), culture);
		}

		public static ILocalizationConfiguration AddBanglaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bn"), culture);
		}

		public static ILocalizationConfiguration AddTibetanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bo"), culture);
		}

		public static ILocalizationConfiguration AddBretonCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("br"), culture);
		}

		public static ILocalizationConfiguration AddBodoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("brx"), culture);
		}

		public static ILocalizationConfiguration AddBosnianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("bs"), culture);
		}

		public static ILocalizationConfiguration AddBlinCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("byn"), culture);
		}

		public static ILocalizationConfiguration AddCatalanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ca"), culture);
		}

		public static ILocalizationConfiguration AddChechenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ce"), culture);
		}

		public static ILocalizationConfiguration AddChigaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("cgg"), culture);
		}

		public static ILocalizationConfiguration AddCherokeeCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("chr"), culture);
		}

		public static ILocalizationConfiguration AddCorsicanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("co"), culture);
		}

		public static ILocalizationConfiguration AddCzechCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("cs"), culture);
		}

		public static ILocalizationConfiguration AddChurchSlavicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("cu"), culture);
		}

		public static ILocalizationConfiguration AddWelshCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("cy"), culture);
		}

		public static ILocalizationConfiguration AddDanishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("da"), culture);
		}

		public static ILocalizationConfiguration AddTaitaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dav"), culture);
		}

		public static ILocalizationConfiguration AddGermanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("de"), culture);
		}

		public static ILocalizationConfiguration AddZarmaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dje"), culture);
		}

		public static ILocalizationConfiguration AddLowerSorbianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dsb"), culture);
		}

		public static ILocalizationConfiguration AddDualaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dua"), culture);
		}

		public static ILocalizationConfiguration AddDivehiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dv"), culture);
		}

		public static ILocalizationConfiguration AddJolaFonyiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dyo"), culture);
		}

		public static ILocalizationConfiguration AddDzongkhaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("dz"), culture);
		}

		public static ILocalizationConfiguration AddEmbuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ebu"), culture);
		}

		public static ILocalizationConfiguration AddEweCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ee"), culture);
		}

		public static ILocalizationConfiguration AddGreekCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("el"), culture);
		}

		public static ILocalizationConfiguration AddEnglishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("en"), culture);
		}

		public static ILocalizationConfiguration AddEsperantoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("eo"), culture);
		}

		public static ILocalizationConfiguration AddSpanishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("es"), culture);
		}

		public static ILocalizationConfiguration AddEstonianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("et"), culture);
		}

		public static ILocalizationConfiguration AddBasqueCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("eu"), culture);
		}

		public static ILocalizationConfiguration AddEwondoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ewo"), culture);
		}

		public static ILocalizationConfiguration AddPersianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fa"), culture);
		}

		public static ILocalizationConfiguration AddFulahCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ff"), culture);
		}

		public static ILocalizationConfiguration AddFinnishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fi"), culture);
		}

		public static ILocalizationConfiguration AddFilipinoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fil"), culture);
		}

		public static ILocalizationConfiguration AddFaroeseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fo"), culture);
		}

		public static ILocalizationConfiguration AddFrenchCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fr"), culture);
		}

		public static ILocalizationConfiguration AddFriulianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fur"), culture);
		}

		public static ILocalizationConfiguration AddWesternFrisianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("fy"), culture);
		}

		public static ILocalizationConfiguration AddIrishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ga"), culture);
		}

		public static ILocalizationConfiguration AddScottishGaelicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("gd"), culture);
		}

		public static ILocalizationConfiguration AddGalicianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("gl"), culture);
		}

		public static ILocalizationConfiguration AddGuaraniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("gn"), culture);
		}

		public static ILocalizationConfiguration AddSwissGermanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("gsw"), culture);
		}

		public static ILocalizationConfiguration AddGujaratiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("gu"), culture);
		}

		public static ILocalizationConfiguration AddGusiiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("guz"), culture);
		}

		public static ILocalizationConfiguration AddManxCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("gv"), culture);
		}

		public static ILocalizationConfiguration AddHausaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ha"), culture);
		}

		public static ILocalizationConfiguration AddHawaiianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("haw"), culture);
		}

		public static ILocalizationConfiguration AddHebrewCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("he"), culture);
		}

		public static ILocalizationConfiguration AddHindiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("hi"), culture);
		}

		public static ILocalizationConfiguration AddCroatianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("hr"), culture);
		}

		public static ILocalizationConfiguration AddUpperSorbianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("hsb"), culture);
		}

		public static ILocalizationConfiguration AddHungarianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("hu"), culture);
		}

		public static ILocalizationConfiguration AddArmenianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("hy"), culture);
		}

		public static ILocalizationConfiguration AddInterlinguaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ia"), culture);
		}

		public static ILocalizationConfiguration AddIbibioCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ibb"), culture);
		}

		public static ILocalizationConfiguration AddIndonesianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("id"), culture);
		}

		public static ILocalizationConfiguration AddIgboCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ig"), culture);
		}

		public static ILocalizationConfiguration AddYiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ii"), culture);
		}

		public static ILocalizationConfiguration AddIcelandicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("is"), culture);
		}

		public static ILocalizationConfiguration AddItalianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("it"), culture);
		}

		public static ILocalizationConfiguration AddInuktitutCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("iu"), culture);
		}

		public static ILocalizationConfiguration AddJapaneseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ja"), culture);
		}

		public static ILocalizationConfiguration AddNgombaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("jgo"), culture);
		}

		public static ILocalizationConfiguration AddMachameCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("jmc"), culture);
		}

		public static ILocalizationConfiguration AddJavaneseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("jv"), culture);
		}

		public static ILocalizationConfiguration AddGeorgianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ka"), culture);
		}

		public static ILocalizationConfiguration AddKabyleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kab"), culture);
		}

		public static ILocalizationConfiguration AddKambaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kam"), culture);
		}

		public static ILocalizationConfiguration AddMakondeCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kde"), culture);
		}

		public static ILocalizationConfiguration AddKabuverdianuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kea"), culture);
		}

		public static ILocalizationConfiguration AddKoyraChiiniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("khq"), culture);
		}

		public static ILocalizationConfiguration AddKikuyuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ki"), culture);
		}

		public static ILocalizationConfiguration AddKazakhCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kk"), culture);
		}

		public static ILocalizationConfiguration AddKakoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kkj"), culture);
		}

		public static ILocalizationConfiguration AddGreenlandicCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kl"), culture);
		}

		public static ILocalizationConfiguration AddKalenjinCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kln"), culture);
		}

		public static ILocalizationConfiguration AddKhmerCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("km"), culture);
		}

		public static ILocalizationConfiguration AddKannadaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kn"), culture);
		}

		public static ILocalizationConfiguration AddKoreanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ko"), culture);
		}

		public static ILocalizationConfiguration AddKonkaniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kok"), culture);
		}

		public static ILocalizationConfiguration AddKanuriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kr"), culture);
		}

		public static ILocalizationConfiguration AddKashmiriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ks"), culture);
		}

		public static ILocalizationConfiguration AddShambalaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ksb"), culture);
		}

		public static ILocalizationConfiguration AddBafiaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ksf"), culture);
		}

		public static ILocalizationConfiguration AddColognianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ksh"), culture);
		}

		public static ILocalizationConfiguration AddCentralKurdishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ku"), culture);
		}

		public static ILocalizationConfiguration AddCornishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("kw"), culture);
		}

		public static ILocalizationConfiguration AddKyrgyzCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ky"), culture);
		}

		public static ILocalizationConfiguration AddLatinCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("la"), culture);
		}

		public static ILocalizationConfiguration AddLangiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lag"), culture);
		}

		public static ILocalizationConfiguration AddLuxembourgishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lb"), culture);
		}

		public static ILocalizationConfiguration AddGandaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lg"), culture);
		}

		public static ILocalizationConfiguration AddLakotaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lkt"), culture);
		}

		public static ILocalizationConfiguration AddLingalaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ln"), culture);
		}

		public static ILocalizationConfiguration AddLaoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lo"), culture);
		}

		public static ILocalizationConfiguration AddNorthernLuriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lrc"), culture);
		}

		public static ILocalizationConfiguration AddLithuanianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lt"), culture);
		}

		public static ILocalizationConfiguration AddLubaKatangaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lu"), culture);
		}

		public static ILocalizationConfiguration AddLuoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("luo"), culture);
		}

		public static ILocalizationConfiguration AddLuyiaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("luy"), culture);
		}

		public static ILocalizationConfiguration AddLatvianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("lv"), culture);
		}

		public static ILocalizationConfiguration AddMasaiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mas"), culture);
		}

		public static ILocalizationConfiguration AddMeruCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mer"), culture);
		}

		public static ILocalizationConfiguration AddMorisyenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mfe"), culture);
		}

		public static ILocalizationConfiguration AddMalagasyCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mg"), culture);
		}

		public static ILocalizationConfiguration AddMakhuwaMeettoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mgh"), culture);
		}

		public static ILocalizationConfiguration AddMetaʼCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mgo"), culture);
		}

		public static ILocalizationConfiguration AddMaoriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mi"), culture);
		}

		public static ILocalizationConfiguration AddMacedonianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mk"), culture);
		}

		public static ILocalizationConfiguration AddMalayalamCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ml"), culture);
		}

		public static ILocalizationConfiguration AddMongolianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mn"), culture);
		}

		public static ILocalizationConfiguration AddManipuriCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mni"), culture);
		}

		public static ILocalizationConfiguration AddMohawkCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("moh"), culture);
		}

		public static ILocalizationConfiguration AddMarathiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mr"), culture);
		}

		public static ILocalizationConfiguration AddMalayCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ms"), culture);
		}

		public static ILocalizationConfiguration AddMalteseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mt"), culture);
		}

		public static ILocalizationConfiguration AddMundangCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mua"), culture);
		}

		public static ILocalizationConfiguration AddBurmeseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("my"), culture);
		}

		public static ILocalizationConfiguration AddMazanderaniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("mzn"), culture);
		}

		public static ILocalizationConfiguration AddNamaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("naq"), culture);
		}

		public static ILocalizationConfiguration AddNorwegianBokmålCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nb"), culture);
		}

		public static ILocalizationConfiguration AddNorthNdebeleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nd"), culture);
		}

		public static ILocalizationConfiguration AddLowGermanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nds"), culture);
		}

		public static ILocalizationConfiguration AddNepaliCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ne"), culture);
		}

		public static ILocalizationConfiguration AddDutchCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nl"), culture);
		}

		public static ILocalizationConfiguration AddKwasioCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nmg"), culture);
		}

		public static ILocalizationConfiguration AddNorwegianNynorskCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nn"), culture);
		}

		public static ILocalizationConfiguration AddNgiemboonCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nnh"), culture);
		}

		public static ILocalizationConfiguration AddNorwegianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("no"), culture);
		}

		public static ILocalizationConfiguration AddSouthNdebeleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nr"), culture);
		}

		public static ILocalizationConfiguration AddNuerCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nus"), culture);
		}

		public static ILocalizationConfiguration AddNyankoleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("nyn"), culture);
		}

		public static ILocalizationConfiguration AddOccitanCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("oc"), culture);
		}

		public static ILocalizationConfiguration AddOromoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("om"), culture);
		}

		public static ILocalizationConfiguration AddOdiaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("or"), culture);
		}

		public static ILocalizationConfiguration AddOsseticCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("os"), culture);
		}

		public static ILocalizationConfiguration AddPunjabiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("pa"), culture);
		}

		public static ILocalizationConfiguration AddPapiamentoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("pap"), culture);
		}

		public static ILocalizationConfiguration AddPolishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("pl"), culture);
		}

		public static ILocalizationConfiguration AddPrussianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("prg"), culture);
		}

		public static ILocalizationConfiguration AddDariCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("prs"), culture);
		}

		public static ILocalizationConfiguration AddPashtoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ps"), culture);
		}

		public static ILocalizationConfiguration AddPortugueseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("pt"), culture);
		}

		public static ILocalizationConfiguration AddQuechuaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("quz"), culture);
		}

		public static ILocalizationConfiguration AddRomanshCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("rm"), culture);
		}

		public static ILocalizationConfiguration AddRundiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("rn"), culture);
		}

		public static ILocalizationConfiguration AddRomanianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ro"), culture);
		}

		public static ILocalizationConfiguration AddRomboCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("rof"), culture);
		}

		public static ILocalizationConfiguration AddRussianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ru"), culture);
		}

		public static ILocalizationConfiguration AddKinyarwandaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("rw"), culture);
		}

		public static ILocalizationConfiguration AddRwaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("rwk"), culture);
		}

		public static ILocalizationConfiguration AddSanskritCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sa"), culture);
		}

		public static ILocalizationConfiguration AddSakhaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sah"), culture);
		}

		public static ILocalizationConfiguration AddSamburuCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("saq"), culture);
		}

		public static ILocalizationConfiguration AddSanguCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sbp"), culture);
		}

		public static ILocalizationConfiguration AddSindhiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sd"), culture);
		}

		public static ILocalizationConfiguration AddNorthernSamiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("se"), culture);
		}

		public static ILocalizationConfiguration AddSenaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("seh"), culture);
		}

		public static ILocalizationConfiguration AddKoyraboroSenniCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ses"), culture);
		}

		public static ILocalizationConfiguration AddSangoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sg"), culture);
		}

		public static ILocalizationConfiguration AddTachelhitCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("shi"), culture);
		}

		public static ILocalizationConfiguration AddSinhalaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("si"), culture);
		}

		public static ILocalizationConfiguration AddSlovakCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sk"), culture);
		}

		public static ILocalizationConfiguration AddSlovenianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sl"), culture);
		}

		public static ILocalizationConfiguration AddSamiSouthernCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sma"), culture);
		}

		public static ILocalizationConfiguration AddSamiLuleCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("smj"), culture);
		}

		public static ILocalizationConfiguration AddSamiInariCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("smn"), culture);
		}

		public static ILocalizationConfiguration AddSamiSkoltCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sms"), culture);
		}

		public static ILocalizationConfiguration AddShonaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sn"), culture);
		}

		public static ILocalizationConfiguration AddSomaliCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("so"), culture);
		}

		public static ILocalizationConfiguration AddAlbanianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sq"), culture);
		}

		public static ILocalizationConfiguration AddSerbianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sr"), culture);
		}

		public static ILocalizationConfiguration AddsiSwatiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ss"), culture);
		}

		public static ILocalizationConfiguration AddSahoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ssy"), culture);
		}

		public static ILocalizationConfiguration AddSesothoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("st"), culture);
		}

		public static ILocalizationConfiguration AddSwedishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sv"), culture);
		}

		public static ILocalizationConfiguration AddKiswahiliCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("sw"), culture);
		}

		public static ILocalizationConfiguration AddSyriacCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("syr"), culture);
		}

		public static ILocalizationConfiguration AddTamilCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ta"), culture);
		}

		public static ILocalizationConfiguration AddTeluguCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("te"), culture);
		}

		public static ILocalizationConfiguration AddTesoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("teo"), culture);
		}

		public static ILocalizationConfiguration AddTajikCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tg"), culture);
		}

		public static ILocalizationConfiguration AddThaiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("th"), culture);
		}

		public static ILocalizationConfiguration AddTigrinyaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ti"), culture);
		}

		public static ILocalizationConfiguration AddTigreCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tig"), culture);
		}

		public static ILocalizationConfiguration AddTurkmenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tk"), culture);
		}

		public static ILocalizationConfiguration AddSetswanaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tn"), culture);
		}

		public static ILocalizationConfiguration AddTonganCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("to"), culture);
		}

		public static ILocalizationConfiguration AddTurkishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tr"), culture);
		}

		public static ILocalizationConfiguration AddTsongaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ts"), culture);
		}

		public static ILocalizationConfiguration AddTatarCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tt"), culture);
		}

		public static ILocalizationConfiguration AddTasawaqCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("twq"), culture);
		}

		public static ILocalizationConfiguration AddCentralAtlasTamazightCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("tzm"), culture);
		}

		public static ILocalizationConfiguration AddUyghurCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ug"), culture);
		}

		public static ILocalizationConfiguration AddUkrainianCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("uk"), culture);
		}

		public static ILocalizationConfiguration AddUrduCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ur"), culture);
		}

		public static ILocalizationConfiguration AddUzbekCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("uz"), culture);
		}

		public static ILocalizationConfiguration AddVaiCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("vai"), culture);
		}

		public static ILocalizationConfiguration AddVendaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("ve"), culture);
		}

		public static ILocalizationConfiguration AddVietnameseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("vi"), culture);
		}

		public static ILocalizationConfiguration AddVolapükCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("vo"), culture);
		}

		public static ILocalizationConfiguration AddVunjoCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("vun"), culture);
		}

		public static ILocalizationConfiguration AddWalserCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("wae"), culture);
		}

		public static ILocalizationConfiguration AddWolayttaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("wal"), culture);
		}

		public static ILocalizationConfiguration AddWolofCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("wo"), culture);
		}

		public static ILocalizationConfiguration AddisiXhosaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("xh"), culture);
		}

		public static ILocalizationConfiguration AddSogaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("xog"), culture);
		}

		public static ILocalizationConfiguration AddYangbenCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("yav"), culture);
		}

		public static ILocalizationConfiguration AddYiddishCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("yi"), culture);
		}

		public static ILocalizationConfiguration AddYorubaCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("yo"), culture);
		}

		public static ILocalizationConfiguration AddStandardMoroccanTamazightCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("zgh"), culture);
		}

		public static ILocalizationConfiguration AddChineseCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("zh"), culture);
		}

		public static ILocalizationConfiguration AddisiZuluCulture(
		this ILocalizationConfiguration configuration,
		Action<ICultureConfiguration> culture)
		{
			return configuration.AddCulture(CultureInfo.GetCultureInfo("zu"), culture);
		}
	}
}