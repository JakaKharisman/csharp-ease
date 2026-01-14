using System;
using System.Collections.Generic;
using Xunit;

namespace Ease.Tests
{
	public class CalculationTest
	{
		private const double PRECISION = 1e-6;

		[Theory]
		[InlineData(0.0)]
		[InlineData(0.5)]
		[InlineData(1.0)]
		public void Calculation_DoubleToFloat_MatchExpectedValues(double input)
		{
			float inputF = (float)input;

			Easing[] easings = Enum.GetValues<Easing>();
			EasingMode[] modes = Enum.GetValues<EasingMode>();
			foreach (Easing easing in easings)
			{
				foreach (EasingMode mode in modes)
				{
					double expected = easing.Interpolate(mode, input);
					float result = easing.InterpolateF(mode, inputF);

					Assert.True(Math.Abs(expected - result) < PRECISION, $"Mismatch for {easing}.{mode} at input {input}");
				}
			}
		}
	}
}