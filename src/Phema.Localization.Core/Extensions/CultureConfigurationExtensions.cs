namespace Phema.Localization
{
	public static class CultureConfigurationExtensions
	{
		/// <summary>
		/// Добавляет в заданную культуру компоненты локализации
		/// </summary>
		/// <typeparam name="TModel">Модель для локализации</typeparam>
		/// <typeparam name="TComponent">Базовый компонент</typeparam>
		/// <typeparam name="TLanguageComponent">Компонент под конкретную культуру</typeparam>
		public static ICultureConfiguration AddComponent<TModel, TComponent, TLanguageComponent>(this ICultureConfiguration configuration)
			where TComponent : ILocalizationComponent<TModel>
			where TLanguageComponent : class, TComponent
		{
			return configuration.AddComponent<TComponent, TLanguageComponent>();
		}
	}
}