namespace Phema.Localization
{
	public sealed class LocalizationMessage
	{
		private readonly string message;

		public LocalizationMessage(string message)
		{
			this.message = message;
		}

		public static implicit operator string(LocalizationMessage message)
		{
			return message.message;
		}
	}
}