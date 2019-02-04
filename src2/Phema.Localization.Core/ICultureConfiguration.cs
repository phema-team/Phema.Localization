namespace Phema.Localization
{
	public interface ICultureConfiguration
	{
		ICultureConfiguration AddComponent<TComponent, TLanguageComponent>()
			where TComponent : ILocalizationComponent
			where TLanguageComponent : class, TComponent;
	}
}