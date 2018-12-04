namespace Phema.Localization
{
	public static class CultureConfigurationExtensions
	{
		public static ICultureConfiguration AddComponent<TModel, TComponent, TLanguageComponent>(this ICultureConfiguration configuration)
			where TComponent : ILocalizationComponent<TModel>
			where TLanguageComponent : class, TComponent
		{
			return configuration.AddComponent<TComponent, TLanguageComponent>();
		}
	}
}