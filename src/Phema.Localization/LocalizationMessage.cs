namespace Phema.Localization
{
	public class LocalizationMessage
	{
		private readonly string template;

		public LocalizationMessage(string template)
		{
			this.template = template;
		}

		public static implicit operator string(LocalizationMessage localizationMessage)
		{
			return localizationMessage.template;
		}
	}
}