using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Phema.Localization
{
	internal sealed class CultureConfiguration : ICultureConfiguration
	{
		private readonly IServiceCollection services;
		private readonly IEnumerable<CultureInfo> cultureInfos;

		public CultureConfiguration(IServiceCollection services, IEnumerable<CultureInfo> cultureInfos)
		{
			this.services = services;
			this.cultureInfos = cultureInfos;
		}

		public ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent 
			where TLanguageComponent : class, TComponent
		{
			services.TryAddSingleton<TLanguageComponent>();

			services.Configure<PhemaLocalizationOptions>(options =>
			{
				foreach (var cultureInfo in cultureInfos)
				{
					if (!options.Components.TryGetValue(cultureInfo, out var components))
					{
						options.Components.Add(cultureInfo, components = new Dictionary<Type, Func<IServiceProvider, ILocalizationComponent>>());
					}
					
					components.Add(typeof(TComponent), sp => sp.GetRequiredService<TLanguageComponent>());
				}
			});
			
			return this;
		}
	}
}