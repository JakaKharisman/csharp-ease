using Xunit;

namespace Ease.Tests
{
	public class EasingExpoTest
	{
		[Theory]
		[InlineData(0.0, 0.0, 0.001)]
		[InlineData(1.0, 1.0, 0.001)]
		public void EaseIn_Interpolate_ReturnsExpectedResults(double input, double expected, double tolerance)
		{
			IEasingFunction function = Easing.Expo.ToFunction(EasingMode.In);
			double result = function.Interpolate(input);
			Assert.Equal(expected, result, tolerance);
		}

		[Theory]
		[InlineData(0.0, 0.0, 0.001)]
		[InlineData(1.0, 1.0, 0.001)]
		public void EaseOut_Interpolate_ReturnsExpectedResults(double input, double expected, double tolerance)
		{
			IEasingFunction function = Easing.Expo.ToFunction(EasingMode.Out);
			double result = function.Interpolate(input);
			Assert.Equal(expected, result, tolerance);
		}

		[Theory]
		[InlineData(0.0, 0.0, 0.001)]
		[InlineData(0.5, 0.5, 0.001)]
		[InlineData(1.0, 1.0, 0.001)]
		public void EaseInOut_Interpolate_ReturnsExpectedResults(double input, double expected, double tolerance)
		{
			IEasingFunction function = Easing.Expo.ToFunction(EasingMode.InOut);
			double result = function.Interpolate(input);
			Assert.Equal(expected, result, tolerance);
		}
	}
}