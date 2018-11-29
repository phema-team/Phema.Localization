using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Phema.Localization.AspNetCore.Tests")]

namespace Phema.Localization
{
	public interface ILocalizationComponent<TModel> : ILocalizationComponent
	{
	}
}