namespace Phema.Localization
{
	public sealed class LocalizationMessage
	{
		public LocalizationMessage(string template)
		{
			Template = template;
		}

		public string Template { get; }

		public static implicit operator string(LocalizationMessage message)
		{
			return message.Template;
		}
	}
}