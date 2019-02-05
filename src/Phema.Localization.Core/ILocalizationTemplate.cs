using System.Globalization;

namespace Phema.Localization
{
	/// <summary>
	/// Локализационный шаблон
	/// </summary>
	public interface ILocalizationTemplate
	{
		/// <summary>
		/// Метод для подстановки параметров в локализационный шаблон
		/// </summary>
		/// <param name="cultureInfo">Используемая культура в сообщении</param>
		/// <param name="arguments">Аргументы для подстановки</param>
		/// <returns></returns>
		string GetMessage(CultureInfo cultureInfo, object[] arguments);
	}
}