using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class LocalizationPostConfigureOptions : IPostConfigureOptions<LocalizationOptions>
	{
		public void PostConfigure(string name, LocalizationOptions options)
		{
			if (!options.Localization.ContainsKey(options.CultureInfo))
			{
				throw new LocalizationException(options.CultureInfo);
			}
		}
	}
}