using System;
using System.Collections.Generic;
using System.Globalization;

namespace Phema.Localization
{
	internal sealed class PhemaLocalizationOptions
	{
		public PhemaLocalizationOptions()
		{
			Components = new Dictionary<CultureInfo, IDictionary<Type, Func<IServiceProvider, ILocalizationComponent>>>();
		}
		
		public IDictionary<CultureInfo, IDictionary<Type, Func<IServiceProvider, ILocalizationComponent>>> Components { get; }
	}
}