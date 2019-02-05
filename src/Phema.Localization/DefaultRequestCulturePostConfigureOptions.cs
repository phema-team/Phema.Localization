using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;

namespace Phema.Localization
{
	internal sealed class DefaultRequestCulturePostConfigureOptions : IPostConfigureOptions<RequestLocalizationOptions>
	{
		public void PostConfigure(string name, RequestLocalizationOptions options)
		{
			options.DefaultRequestCulture = new RequestCulture(
				options.SupportedCultures.First(),
				options.SupportedUICultures.First());
		}
	}
}