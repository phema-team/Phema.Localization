using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizationTemplate
	{
		string Template { get; }
		
		string GetMessage(CultureInfo cultureInfo, object[] arguments);
	}
	
	public sealed class LocalizationTemplate : ILocalizationTemplate
	{
		public LocalizationTemplate(string template)
		{
			Template = template;
		}

		public string Template { get; }

		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			return arguments == null
				? Template
				: string.Format(cultureInfo, Template, arguments);
		}
	}
}