﻿using System;

namespace Phema.Localization
{
	public interface ILocalizer
	{
		LocalizationMessage Localize<TComponent>(Func<TComponent, ILocalizationTemplate> selector, object[] arguments)
			where TComponent : ILocalizationComponent;
	}
}