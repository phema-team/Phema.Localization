using System;
using System.Collections.Generic;
using System.Globalization;

namespace Phema.Localization
{
	/// <summary>
	/// Используется для конфигурации культур приложения
	/// </summary>
	public interface ILocalizationConfiguration
	{
		/// <summary>
		/// Добавляет новые культуры
		/// </summary>
		/// <param name="cultureInfos">Список добавляемых культур</param>
		/// <param name="culture">Конфигурация заданных культур</param>
		ILocalizationConfiguration AddCultures(IEnumerable<CultureInfo> cultureInfos, Action<ICultureConfiguration> culture);
	}
}