using System;

namespace Ease.Functions
{
	public class ElasticEasingFunction : EasingFunction
	{
		const double P = 0.3;

		public ElasticEasingFunction(EasingMode mode) : base(Easing.Elastic, mode)
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
			return 1 - Out(1 - time);
		}

		public static double Out(double time)
		{
			return Math.Pow(2, -10 * time) * Math.Sin((time - P / 4) * (2 * Math.PI) / P) + 1;
		}

		public static double InOut(double time)
		{
			if (time < 0.5) return In(time * 2) / 2;
			return 1 - In((1 - time) * 2) / 2;
		}
	}
}
