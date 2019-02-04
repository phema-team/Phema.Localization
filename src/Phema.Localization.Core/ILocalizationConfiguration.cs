using System;
using System.Collections.Generic;
using System.Globalization;

namespace Phema.Localization
{
	public interface ILocalizationConfiguration
	{
		ILocalizationConfiguration AddCultures(IEnumerable<CultureInfo> cultureInfos, Action<ICultureConfiguration> culture);
	}
}