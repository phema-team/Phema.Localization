using System;
using System.Linq;
using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class LocalizationPostConfigureOptions : IPostConfigureOptions<LocalizationOptions>
	{
		public void PostConfigure(string name, LocalizationOptions options)
		{
			var hasAnyCulture = options.CultureInfo == null;
			var hasAnyLocalization = options.Localization.Any();
			
			if (hasAnyCulture && !hasAnyLocalization)
			{
				throw new InvalidOperationException("No cultures registered");
			}

			var hasInvalidCulture = !hasAnyCulture && !options.Localization.ContainsKey(options.CultureInfo); 
			
			if (hasAnyLocalization && (hasAnyCulture || hasInvalidCulture))
			{
				options.CultureInfo = options.Localization.First().Key;
			}
		}
	}
}