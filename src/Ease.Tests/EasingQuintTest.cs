namespace Ease.Tests
{
	public class EasingQuintTest
	{
		[Theory]
		[InlineData(0.0, 0.0, 4)]
		[InlineData(1.0, 1.0, 4)]
		public void EaseIn_Interpolate_ReturnsExpectedResults(double input, double expected, int precision)
		{
			IEasingFunction function = Easing.Quint.ToFunction(EasingMode.In);
			double result = function.Interpolate(input);
			Assert.Equal(expected, result, precision);
		}

		[Theory]
		[InlineData(0.0, 0.0, 4)]
		[InlineData(1.0, 1.0, 4)]
		public void EaseOut_Interpolate_ReturnsExpectedResults(double input, double expected, int precision)
		{
			IEasingFunction function = Easing.Quint.ToFunction(EasingMode.Out);
			double result = function.Interpolate(input);
			Assert.Equal(expected, result, precision);
		}

		[Theory]
		[InlineData(0.0, 0.0, 4)]
		[InlineData(0.5, 0.5, 4)]
		[InlineData(1.0, 1.0, 4)]
		public void EaseInOut_Interpolate_ReturnsExpectedResults(double input, double expected, int precision)
		{
			IEasingFunction function = Easing.Quint.ToFunction(EasingMode.InOut);
			double result = function.Interpolate(input);
			Assert.Equal(expected, result, precision);
		}
	}
}