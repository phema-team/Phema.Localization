using System;
using System.Globalization;

namespace Phema.Localization
{
	public sealed class LocalizationException : Exception
	{
		public LocalizationException(CultureInfo culture, Type component)
			: base($"{culture}:{component.Name}")
		{
			Culture = culture;
			Component = component;
		}
		
		public CultureInfo Culture { get; }
		public Type Component { get; }
	}
}