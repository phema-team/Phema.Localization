using System;
using System.Globalization;

namespace Phema.Localization
{
	/// <inheritdoc cref="ILocalizationTemplate"/>
	public sealed class LocalizationTemplate : ILocalizationTemplate
	{
		private readonly string template;
		
		public LocalizationTemplate(string template)
		{
			this.template = template;
		}

		/// <inheritdoc cref="ILocalizationTemplate.GetMessage"/>
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments == null)
				throw new ArgumentNullException(nameof(arguments));
			if (arguments.Length != 0)
				throw new ArgumentException(nameof(arguments));
			
			return string.Format(cultureInfo, template, arguments);
		}
	}
	
	/// <inheritdoc cref="ILocalizationTemplate"/>
	public sealed class LocalizationTemplate<TArgument> : ILocalizationTemplate
	{
		private readonly string template;
		
		public LocalizationTemplate(string template)
		{
			this.template = template;
		}
		
		/// <inheritdoc cref="ILocalizationTemplate.GetMessage"/>
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments == null)
				throw new ArgumentNullException(nameof(arguments));
			
			if (arguments.Length != 1)
				throw new ArgumentException(nameof(arguments));
			
			return string.Format(cultureInfo, template, arguments);
		}
	}
	
	/// <inheritdoc cref="ILocalizationTemplate"/>
	public sealed class LocalizationTemplate<TArgument1, TArgument2> : ILocalizationTemplate
	{
		private readonly string template;
		
		public LocalizationTemplate(string template)
		{
			this.template = template;
		}
		
		/// <inheritdoc cref="ILocalizationTemplate.GetMessage"/>
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments == null)
				throw new ArgumentNullException(nameof(arguments));
			
			if (arguments.Length != 2)
				throw new ArgumentException(nameof(arguments));
			
			return string.Format(cultureInfo, template, arguments);
		}
	}
	
	/// <inheritdoc cref="ILocalizationTemplate"/>
	public sealed class LocalizationTemplate<TArgument1, TArgument2, TArgument3> : ILocalizationTemplate
	{
		private readonly string template;
		
		public LocalizationTemplate(string template)
		{
			this.template = template;
		}
		
		/// <inheritdoc cref="ILocalizationTemplate.GetMessage"/>
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments == null)
				throw new ArgumentNullException(nameof(arguments));
			
			if (arguments.Length != 3)
				throw new ArgumentException(nameof(arguments));
			
			return string.Format(cultureInfo, template, arguments);
		}
	}
}