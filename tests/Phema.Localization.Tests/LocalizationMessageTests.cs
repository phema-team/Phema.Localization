using Xunit;

namespace Phema.Localization.Tests
{
	public class LocalizationMessageTests
	{
		[Fact]
		public void CreateLocalizationMessage()
		{
			var message = new LocalizationMessage("template");
			
			Assert.Equal("template", message.Template);
		}
		
		[Fact]
		public void LocalizationMessageImplicitCast()
		{
			var message = new LocalizationMessage("template");
			
			Assert.Equal("template", message);
		}
	}
}