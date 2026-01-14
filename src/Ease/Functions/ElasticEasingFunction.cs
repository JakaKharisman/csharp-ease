using System;

namespace Ease.Functions
{
	public class ElasticEasingFunction : EasingFunction
	{
		const double P = 0.3;
		const double P_OVER_4 = P / 4;
		const double TAU_OVER_P = Math.Tau / P;


		public ElasticEasingFunction(EasingMode mode) : base(mode)
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
			if (time == 0) return 0;
			if (time == 1) return 1;
			return Math.Pow(2, -10 * time) * Math.Sin((time - P_OVER_4) * TAU_OVER_P) + 1;
		}

		public static double InOut(double time)
		{
			if (time < 0.5) return In(time * 2) * 0.5;
			return 1 - In((1 - time) * 2) * 0.5;
		}
	}
}
