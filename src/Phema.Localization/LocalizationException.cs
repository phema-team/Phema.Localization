using System;
using System.Globalization;

namespace Phema.Localization
{
	public sealed class LocalizationException : Exception
	{
		public LocalizationException(CultureInfo cultureInfo)
			: base($"{cultureInfo}")
		{
			CultureInfo = cultureInfo;
		}
		
		public LocalizationException(CultureInfo cultureInfo, Type component)
			: base($"{cultureInfo}:{component.Name}")
		{
			CultureInfo = cultureInfo;
			Component = component;
		}
		
		public CultureInfo CultureInfo { get; }
		public Type Component { get; }
	}
}