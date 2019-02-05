namespace Phema.Localization
{
	/// <summary>
	/// Нетипизированный компонент, содержащий один и более <see cref="ILocalizationTemplate"/> для локализации
	/// </summary>
	public interface ILocalizationComponent
	{
	}
	
	/// <summary>
	/// Типизированный <see cref="TModel"/> компонент, содержащий один и более <see cref="ILocalizationTemplate"/> для локализации
	/// </summary>
	/// <typeparam name="TModel">Модель, которая будет использовать этот компонент</typeparam>
	public interface ILocalizationComponent<TModel> : ILocalizationComponent
	{
	}
}