using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizationTemplate
	{
		string Template { get; }
		
		string GetMessage(CultureInfo cultureInfo, object[] arguments);
	}
}