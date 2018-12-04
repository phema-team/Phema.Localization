﻿using System;
using System.Globalization;

namespace Phema.Localization
{
	public sealed class LocalizationTemplate : ILocalizationTemplate
	{
		public LocalizationTemplate(string template)
		{
			Template = template;
		}

		public string Template { get; }

		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			return arguments == null
				? Template
				: string.Format(cultureInfo, Template, arguments);
		}
	}
	
	public sealed class LocalizationTemplate<TArgument> : ILocalizationTemplate
	{
		public LocalizationTemplate(string template)
		{
			Template = template;
		}
		
		public string Template { get; }
		
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments?.Length != 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			
			return string.Format(cultureInfo, Template, arguments);
		}
	}
	
	public sealed class LocalizationTemplate<TArgument1, TArgument2> : ILocalizationTemplate
	{
		public LocalizationTemplate(string template)
		{
			Template = template;
		}
		
		public string Template { get; }
		
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments?.Length != 2)
			{
				throw new ArgumentOutOfRangeException();
			}
			
			return string.Format(cultureInfo, Template, arguments);
		}
	}
	
	public sealed class LocalizationTemplate<TArgument1, TArgument2, TArgument3> : ILocalizationTemplate
	{
		public LocalizationTemplate(string template)
		{
			Template = template;
		}
		
		public string Template { get; }
		
		public string GetMessage(CultureInfo cultureInfo, object[] arguments)
		{
			if (arguments?.Length != 3)
			{
				throw new ArgumentOutOfRangeException();
			}
			
			return string.Format(cultureInfo, Template, arguments);
		}
	}
}