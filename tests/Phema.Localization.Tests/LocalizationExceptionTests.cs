using System.Globalization;
using System.Threading.Tasks;
using Xunit;

namespace Phema.Localization.Tests
{
	public class LocalizationExceptionTests
	{
		[Fact]
		public async Task LocalizationException()
		{
			var exception = await Assert.ThrowsAsync<LocalizationException>(
				() => throw new LocalizationException(CultureInfo.InvariantCulture));
			
			Assert.Null(exception.Component);
			Assert.Equal(CultureInfo.InvariantCulture, exception.CultureInfo);
		}
		
		[Fact]
		public async Task LocalizationExceptionPassComponent()
		{
			var exception = await Assert.ThrowsAsync<LocalizationException>(
				() => throw new LocalizationException(CultureInfo.InvariantCulture, typeof(LocalizationExceptionTests)));
			
			Assert.Equal(typeof(LocalizationExceptionTests), exception.Component);
			Assert.Equal(CultureInfo.InvariantCulture, exception.CultureInfo);
		}
	}
}