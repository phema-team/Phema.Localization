using System;
using System.Collections.Generic;
using System.Globalization;

namespace Phema.Localization
{
	public sealed class LocalizationOptions
	{
		public LocalizationOptions()
		{
			CultureInfo = CultureInfo.InvariantCulture;
			Localization = new Dictionary<CultureInfo, IDictionary<Type, Func<IServiceProvider, ILocalizationComponent>>>();
		}

		public CultureInfo CultureInfo { get; set; }
		
		internal Dictionary<CultureInfo, IDictionary<Type, Func<IServiceProvider, ILocalizationComponent>>> Localization { get; }
	}
}