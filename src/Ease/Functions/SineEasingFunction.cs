using System;

namespace Ease.Functions
{
	public class SineEasingFunction : EasingFunction
	{
		public SineEasingFunction(EasingMode mode) : base(Easing.Sine, mode)
		{

		}

		public override double Interpolate(double time)
		{
			return Mode switch
			{
				EasingMode.In => In(time),
				EasingMode.Out => Out(time),
				_ => InOut(time),
			};
		}

		public static double In(double time)
		{
			return 1 - Math.Cos(time * Math.PI * 0.5);
		}

		public static double Out(double time)
		{
			return Math.Sin(time * Math.PI * 0.5);
		}

		public static double InOut(double time)
		{
			return (Math.Cos(time * Math.PI) - 1) * -0.5;
		}
	}
}
