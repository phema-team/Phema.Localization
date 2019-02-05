using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Phema.Localization
{
	internal sealed class LocalizationConfiguration : ILocalizationConfiguration
	{
		private readonly IServiceCollection services;

		public LocalizationConfiguration(IServiceCollection services)
		{
			this.services = services;
		}

		public ILocalizationConfiguration AddCultures(IEnumerable<CultureInfo> cultureInfos, Action<ICultureConfiguration> culture)
		{
			services.Configure<RequestLocalizationOptions>(options =>
			{
				foreach (var cultureInfo in cultureInfos)
				{
					options.SupportedCultures.Add(cultureInfo);
					options.SupportedUICultures.Add(cultureInfo);
				}
			});
			
			culture.Invoke(new CultureConfiguration(services, cultureInfos));
			
			return this;
		}
	}
}