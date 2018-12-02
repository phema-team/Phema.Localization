using System.Linq;
using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class LocalizationPostConfigureOptions : IPostConfigureOptions<LocalizationOptions>
	{
		public void PostConfigure(string name, LocalizationOptions options)
		{
			if (options.CultureInfo == null || !options.Localization.ContainsKey(options.CultureInfo))
			{
				if (options.Localization.Any())
				{
					options.CultureInfo = options.Localization.First().Key;
				}
				else
				{
					throw new LocalizationException(options.CultureInfo);
				}
			}
		}
	}
}