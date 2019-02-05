namespace Phema.Localization
{
	/// <summary>
	/// Используется для конфигурации компонентов локализации
	/// </summary>
	public interface ICultureConfiguration
	{
		/// <summary>
		/// Добавляет в заданную культуру компоненты локализации
		/// </summary>
		/// <typeparam name="TComponent">Базовый компонент</typeparam>
		/// <typeparam name="TLanguageComponent">Компонент под конкретную культуру</typeparam>
		ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent
			where TLanguageComponent : class, TComponent;
	}
}