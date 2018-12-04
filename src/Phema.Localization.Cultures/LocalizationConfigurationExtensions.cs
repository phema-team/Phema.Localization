using System;
using System.Globalization;

namespace Phema.Localization
{
	public static class LocalizationConfigurationExtensions
	{
		public static void AddInvariantCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo(""), action);
		}

		public static void AddAfarCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("aa"), action);
		}

		public static void AddAfrikaansCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("af"), action);
		}

		public static void AddAghemCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("agq"), action);
		}

		public static void AddAkanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ak"), action);
		}

		public static void AddAmharicCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("am"), action);
		}

		public static void AddArabicCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ar"), action);
		}

		public static void AddMapudungunCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("arn"), action);
		}

		public static void AddAssameseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("as"), action);
		}

		public static void AddAsuCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("asa"), action);
		}

		public static void AddAsturianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ast"), action);
		}

		public static void AddAzerbaijaniCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("az"), action);
		}

		public static void AddBashkirCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ba"), action);
		}

		public static void AddBasaaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bas"), action);
		}

		public static void AddBelarusianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("be"), action);
		}

		public static void AddBembaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bem"), action);
		}

		public static void AddBenaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bez"), action);
		}

		public static void AddBulgarianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bg"), action);
		}

		public static void AddEdoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bin"), action);
		}

		public static void AddBamanankanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bm"), action);
		}

		public static void AddBanglaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bn"), action);
		}

		public static void AddTibetanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bo"), action);
		}

		public static void AddBretonCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("br"), action);
		}

		public static void AddBodoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("brx"), action);
		}

		public static void AddBosnianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("bs"), action);
		}

		public static void AddBlinCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("byn"), action);
		}

		public static void AddCatalanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ca"), action);
		}

		public static void AddChechenCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ce"), action);
		}

		public static void AddChigaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cgg"), action);
		}

		public static void AddCherokeeCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("chr"), action);
		}

		public static void AddCorsicanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("co"), action);
		}

		public static void AddCzechCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cs"), action);
		}

		public static void AddChurchSlavicCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cu"), action);
		}

		public static void AddWelshCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("cy"), action);
		}

		public static void AddDanishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("da"), action);
		}

		public static void AddTaitaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dav"), action);
		}

		public static void AddGermanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("de"), action);
		}

		public static void AddZarmaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dje"), action);
		}

		public static void AddLowerSorbianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dsb"), action);
		}

		public static void AddDualaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dua"), action);
		}

		public static void AddDivehiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dv"), action);
		}

		public static void AddJolaFonyiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dyo"), action);
		}

		public static void AddDzongkhaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("dz"), action);
		}

		public static void AddEmbuCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ebu"), action);
		}

		public static void AddEweCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ee"), action);
		}

		public static void AddGreekCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("el"), action);
		}

		public static void AddEnglishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("en"), action);
		}

		public static void AddEsperantoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("eo"), action);
		}

		public static void AddSpanishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("es"), action);
		}

		public static void AddEstonianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("et"), action);
		}

		public static void AddBasqueCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("eu"), action);
		}

		public static void AddEwondoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ewo"), action);
		}

		public static void AddPersianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fa"), action);
		}

		public static void AddFulahCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ff"), action);
		}

		public static void AddFinnishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fi"), action);
		}

		public static void AddFilipinoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fil"), action);
		}

		public static void AddFaroeseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fo"), action);
		}

		public static void AddFrenchCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fr"), action);
		}

		public static void AddFriulianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fur"), action);
		}

		public static void AddWesternFrisianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("fy"), action);
		}

		public static void AddIrishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ga"), action);
		}

		public static void AddScottishGaelicCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gd"), action);
		}

		public static void AddGalicianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gl"), action);
		}

		public static void AddGuaraniCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gn"), action);
		}

		public static void AddSwissGermanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gsw"), action);
		}

		public static void AddGujaratiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gu"), action);
		}

		public static void AddGusiiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("guz"), action);
		}

		public static void AddManxCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("gv"), action);
		}

		public static void AddHausaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ha"), action);
		}

		public static void AddHawaiianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("haw"), action);
		}

		public static void AddHebrewCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("he"), action);
		}

		public static void AddHindiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hi"), action);
		}

		public static void AddCroatianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hr"), action);
		}

		public static void AddUpperSorbianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hsb"), action);
		}

		public static void AddHungarianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hu"), action);
		}

		public static void AddArmenianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("hy"), action);
		}

		public static void AddInterlinguaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ia"), action);
		}

		public static void AddIbibioCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ibb"), action);
		}

		public static void AddIndonesianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("id"), action);
		}

		public static void AddIgboCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ig"), action);
		}

		public static void AddYiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ii"), action);
		}

		public static void AddIcelandicCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("is"), action);
		}

		public static void AddItalianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("it"), action);
		}

		public static void AddInuktitutCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("iu"), action);
		}

		public static void AddJapaneseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ja"), action);
		}

		public static void AddNgombaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("jgo"), action);
		}

		public static void AddMachameCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("jmc"), action);
		}

		public static void AddJavaneseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("jv"), action);
		}

		public static void AddGeorgianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ka"), action);
		}

		public static void AddKabyleCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kab"), action);
		}

		public static void AddKambaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kam"), action);
		}

		public static void AddMakondeCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kde"), action);
		}

		public static void AddKabuverdianuCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kea"), action);
		}

		public static void AddKoyraChiiniCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("khq"), action);
		}

		public static void AddKikuyuCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ki"), action);
		}

		public static void AddKazakhCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kk"), action);
		}

		public static void AddKakoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kkj"), action);
		}

		public static void AddGreenlandicCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kl"), action);
		}

		public static void AddKalenjinCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kln"), action);
		}

		public static void AddKhmerCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("km"), action);
		}

		public static void AddKannadaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kn"), action);
		}

		public static void AddKoreanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ko"), action);
		}

		public static void AddKonkaniCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kok"), action);
		}

		public static void AddKanuriCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kr"), action);
		}

		public static void AddKashmiriCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ks"), action);
		}

		public static void AddShambalaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ksb"), action);
		}

		public static void AddBafiaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ksf"), action);
		}

		public static void AddColognianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ksh"), action);
		}

		public static void AddCentralKurdishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ku"), action);
		}

		public static void AddCornishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("kw"), action);
		}

		public static void AddKyrgyzCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ky"), action);
		}

		public static void AddLatinCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("la"), action);
		}

		public static void AddLangiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lag"), action);
		}

		public static void AddLuxembourgishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lb"), action);
		}

		public static void AddGandaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lg"), action);
		}

		public static void AddLakotaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lkt"), action);
		}

		public static void AddLingalaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ln"), action);
		}

		public static void AddLaoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lo"), action);
		}

		public static void AddNorthernLuriCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lrc"), action);
		}

		public static void AddLithuanianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lt"), action);
		}

		public static void AddLubaKatangaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lu"), action);
		}

		public static void AddLuoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("luo"), action);
		}

		public static void AddLuyiaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("luy"), action);
		}

		public static void AddLatvianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("lv"), action);
		}

		public static void AddMasaiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mas"), action);
		}

		public static void AddMeruCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mer"), action);
		}

		public static void AddMorisyenCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mfe"), action);
		}

		public static void AddMalagasyCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mg"), action);
		}

		public static void AddMakhuwaMeettoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mgh"), action);
		}

		public static void AddMetaʼCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mgo"), action);
		}

		public static void AddMaoriCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mi"), action);
		}

		public static void AddMacedonianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mk"), action);
		}

		public static void AddMalayalamCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ml"), action);
		}

		public static void AddMongolianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mn"), action);
		}

		public static void AddManipuriCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mni"), action);
		}

		public static void AddMohawkCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("moh"), action);
		}

		public static void AddMarathiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mr"), action);
		}

		public static void AddMalayCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ms"), action);
		}

		public static void AddMalteseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mt"), action);
		}

		public static void AddMundangCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mua"), action);
		}

		public static void AddBurmeseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("my"), action);
		}

		public static void AddMazanderaniCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("mzn"), action);
		}

		public static void AddNamaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("naq"), action);
		}

		public static void AddNorwegianBokmålCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nb"), action);
		}

		public static void AddNorthNdebeleCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nd"), action);
		}

		public static void AddLowGermanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nds"), action);
		}

		public static void AddNepaliCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ne"), action);
		}

		public static void AddDutchCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nl"), action);
		}

		public static void AddKwasioCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nmg"), action);
		}

		public static void AddNorwegianNynorskCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nn"), action);
		}

		public static void AddNgiemboonCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nnh"), action);
		}

		public static void AddNorwegianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("no"), action);
		}

		public static void AddSouthNdebeleCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nr"), action);
		}

		public static void AddNuerCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nus"), action);
		}

		public static void AddNyankoleCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("nyn"), action);
		}

		public static void AddOccitanCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("oc"), action);
		}

		public static void AddOromoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("om"), action);
		}

		public static void AddOdiaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("or"), action);
		}

		public static void AddOsseticCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("os"), action);
		}

		public static void AddPunjabiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pa"), action);
		}

		public static void AddPapiamentoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pap"), action);
		}

		public static void AddPolishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pl"), action);
		}

		public static void AddPrussianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("prg"), action);
		}

		public static void AddDariCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("prs"), action);
		}

		public static void AddPashtoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ps"), action);
		}

		public static void AddPortugueseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("pt"), action);
		}

		public static void AddQuechuaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("quz"), action);
		}

		public static void AddRomanshCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rm"), action);
		}

		public static void AddRundiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rn"), action);
		}

		public static void AddRomanianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ro"), action);
		}

		public static void AddRomboCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rof"), action);
		}

		public static void AddRussianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ru"), action);
		}

		public static void AddKinyarwandaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rw"), action);
		}

		public static void AddRwaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("rwk"), action);
		}

		public static void AddSanskritCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sa"), action);
		}

		public static void AddSakhaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sah"), action);
		}

		public static void AddSamburuCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("saq"), action);
		}

		public static void AddSanguCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sbp"), action);
		}

		public static void AddSindhiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sd"), action);
		}

		public static void AddNorthernSamiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("se"), action);
		}

		public static void AddSenaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("seh"), action);
		}

		public static void AddKoyraboroSenniCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ses"), action);
		}

		public static void AddSangoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sg"), action);
		}

		public static void AddTachelhitCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("shi"), action);
		}

		public static void AddSinhalaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("si"), action);
		}

		public static void AddSlovakCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sk"), action);
		}

		public static void AddSlovenianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sl"), action);
		}

		public static void AddSamiSouthernCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sma"), action);
		}

		public static void AddSamiLuleCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("smj"), action);
		}

		public static void AddSamiInariCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("smn"), action);
		}

		public static void AddSamiSkoltCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sms"), action);
		}

		public static void AddShonaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sn"), action);
		}

		public static void AddSomaliCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("so"), action);
		}

		public static void AddAlbanianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sq"), action);
		}

		public static void AddSerbianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sr"), action);
		}

		public static void AddsiSwatiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ss"), action);
		}

		public static void AddSahoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ssy"), action);
		}

		public static void AddSesothoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("st"), action);
		}

		public static void AddSwedishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sv"), action);
		}

		public static void AddKiswahiliCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("sw"), action);
		}

		public static void AddSyriacCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("syr"), action);
		}

		public static void AddTamilCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ta"), action);
		}

		public static void AddTeluguCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("te"), action);
		}

		public static void AddTesoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("teo"), action);
		}

		public static void AddTajikCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tg"), action);
		}

		public static void AddThaiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("th"), action);
		}

		public static void AddTigrinyaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ti"), action);
		}

		public static void AddTigreCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tig"), action);
		}

		public static void AddTurkmenCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tk"), action);
		}

		public static void AddSetswanaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tn"), action);
		}

		public static void AddTonganCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("to"), action);
		}

		public static void AddTurkishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tr"), action);
		}

		public static void AddTsongaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ts"), action);
		}

		public static void AddTatarCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tt"), action);
		}

		public static void AddTasawaqCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("twq"), action);
		}

		public static void AddCentralAtlasTamazightCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("tzm"), action);
		}

		public static void AddUyghurCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ug"), action);
		}

		public static void AddUkrainianCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("uk"), action);
		}

		public static void AddUrduCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ur"), action);
		}

		public static void AddUzbekCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("uz"), action);
		}

		public static void AddVaiCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vai"), action);
		}

		public static void AddVendaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("ve"), action);
		}

		public static void AddVietnameseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vi"), action);
		}

		public static void AddVolapükCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vo"), action);
		}

		public static void AddVunjoCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("vun"), action);
		}

		public static void AddWalserCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("wae"), action);
		}

		public static void AddWolayttaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("wal"), action);
		}

		public static void AddWolofCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("wo"), action);
		}

		public static void AddisiXhosaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("xh"), action);
		}

		public static void AddSogaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("xog"), action);
		}

		public static void AddYangbenCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("yav"), action);
		}

		public static void AddYiddishCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("yi"), action);
		}

		public static void AddYorubaCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("yo"), action);
		}

		public static void AddStandardMoroccanTamazightCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("zgh"), action);
		}

		public static void AddChineseCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("zh"), action);
		}

		public static void AddisiZuluCulture(
			this ILocalizationConfiguration configuration,
			Action<ICultureConfiguration> action)
		{
			configuration.AddCulture(CultureInfo.GetCultureInfo("zu"), action);
		}
	}
}