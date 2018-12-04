using System;
using System.Linq;
using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class LocalizationPostConfigureOptions : IPostConfigureOptions<LocalizationOptions>
	{
		public void PostConfigure(string name, LocalizationOptions options)
		{
			if (options.CultureInfo == null && !options.Localization.Any())
			{
				throw new InvalidOperationException("No cultures registered");
			}

			var hasAnyCulture = options.CultureInfo == null && options.Localization.Any();
			var hasInvalidCulture = options.CultureInfo != null && !options.Localization.ContainsKey(options.CultureInfo); 
			
			if (hasAnyCulture || hasInvalidCulture)
			{
				options.CultureInfo = options.Localization.First().Key;
			}
		}
	}
}