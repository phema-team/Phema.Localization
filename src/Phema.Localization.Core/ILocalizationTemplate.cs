using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizationTemplate
	{
		string GetMessage(CultureInfo cultureInfo, object[] arguments);
	}
}