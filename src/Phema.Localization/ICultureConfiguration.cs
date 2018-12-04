using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Phema.Localization.Tests")]

namespace Phema.Localization
{
	public interface ICultureConfiguration
	{
		ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent
			where TLanguageComponent : class, TComponent;
	}
	
	internal class CultureConfiguration : ICultureConfiguration
	{
		private readonly IServiceCollection services;
		private readonly IEnumerable<CultureInfo> cultureInfos;

		public CultureConfiguration(IEnumerable<CultureInfo> cultureInfos, IServiceCollection services)
		{
			this.cultureInfos = cultureInfos;
			this.services = services;
		}
		
		public ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent
			where TLanguageComponent : class, TComponent
		{
			services.AddSingleton<TLanguageComponent>();
			
			services.Configure<LocalizationOptions>(options =>
			{
				foreach (var cultureInfo in cultureInfos)
				{
					if (!options.Localization.TryGetValue(cultureInfo, out var map))
					{
						options.Localization.Add(cultureInfo, map = new Dictionary<Type, Func<IServiceProvider, ILocalizationComponent>>());
					}
					
					map.Add(typeof(TComponent), sp => sp.GetRequiredService<TLanguageComponent>());
				}
			});

			return this;
		}
	}
}