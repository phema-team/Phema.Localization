using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;

namespace Phema.Localization
{
	public interface ILocalizationConfiguration
	{
		void AddCultures(IEnumerable<CultureInfo> cultures, Action<ICultureConfiguration> configuration);
	}
	
	internal sealed class LocalizationConfiguration : ILocalizationConfiguration
	{
		private readonly IServiceCollection services;

		public LocalizationConfiguration(IServiceCollection services)
		{
			this.services = services;
		}

		public void AddCultures(IEnumerable<CultureInfo> cultures, Action<ICultureConfiguration> configuration)
		{
			configuration(new CultureConfiguration(cultures, services));
		}
	}
}