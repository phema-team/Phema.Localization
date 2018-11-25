using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Phema.Localization.Tests")]

namespace Phema.Localization
{
	public interface ILocalizationComponent<TModel> : ILocalizationComponent
	{
	}
}