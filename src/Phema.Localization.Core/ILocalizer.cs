using System;

namespace Phema.Localization
{
	/// <summary>
	/// Используется для локализации 
	/// </summary>
	public interface ILocalizer
	{
		/// <summary>
		/// Выбирает из компонента нужный шаблон и с заданной культурой подставляет параметры
		/// </summary>
		/// <param name="selector">Выбирает шаблон из компонента</param>
		/// <param name="arguments">Аргументы для подстановки</param>
		/// <typeparam name="TComponent">Локализационный компонент</typeparam>
		/// <returns></returns>
		string Localize<TComponent>(Func<TComponent, ILocalizationTemplate> selector, object[] arguments)
			where TComponent : ILocalizationComponent;
	}
}