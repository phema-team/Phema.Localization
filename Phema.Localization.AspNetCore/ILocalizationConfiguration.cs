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
	
	internal class LocalizationConfiguration : ILocalizationConfiguration
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
	
	public interface ICultureConfiguration
	{
		ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent
			where TLanguageComponent : class, TComponent;
	}

	internal class CultureConfiguration : ICultureConfiguration
	{
		private readonly IServiceCollection services;
		private readonly IEnumerable<CultureInfo> cultures;

		public CultureConfiguration(IEnumerable<CultureInfo> cultures, IServiceCollection services)
		{
			this.cultures = cultures;
			this.services = services;
		}
		
		public ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent
			where TLanguageComponent : class, TComponent
		{
			services.AddSingleton<TLanguageComponent>();
			
			services.Configure<LocalizationOptions>(options =>
			{
				foreach (var culture in cultures)
				{
					if (!options.Localization.TryGetValue(culture, out var map))
					{
						options.Localization.Add(culture, map = new Dictionary<Type, Func<IServiceProvider, ILocalizationComponent>>());
					}
					
					map.Add(typeof(TComponent), sp => sp.GetRequiredService<TLanguageComponent>());
				}
			});

			return this;
		}
	}
	
}