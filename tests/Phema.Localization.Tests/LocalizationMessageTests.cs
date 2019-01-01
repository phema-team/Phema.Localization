using System;
using System.Globalization;
using Xunit;

namespace Phema.Localization.Tests
{
	public class LocalizationMessageTests
	{
		[Fact]
		public void CreateLocalizationMessage()
		{
			var message = new LocalizationTemplate("template");
			
			Assert.Equal("template", message.Template);
		}
		
		[Fact]
		public void LocalizationMessageImplicitCast()
		{
			var message = new LocalizationTemplate("template");
			
			Assert.Equal("template", message.GetMessage(CultureInfo.InvariantCulture, Array.Empty<object>()));
		}
		
		[Fact]
		public void LocalizationMessage_OneParameter()
		{
			var message = new LocalizationTemplate<int>("template {0}");
			
			Assert.Equal("template 10", message.GetMessage(CultureInfo.InvariantCulture, new object[]{10}));
		}
		
		[Fact]
		public void LocalizationMessage_TwoParameters()
		{
			var message = new LocalizationTemplate<int, int>("template {0},{1}");
			
			Assert.Equal("template 10,11", message.GetMessage(CultureInfo.InvariantCulture, new object[]{10, 11}));
		}
		
		[Fact]
		public void LocalizationMessage_ThreeParameters()
		{
			var message = new LocalizationTemplate<int, int, int>("template {0},{1},{2}");
			
			Assert.Equal("template 10,11,12", message.GetMessage(CultureInfo.InvariantCulture, new object[]{10, 11, 12}));
		}
	}
}