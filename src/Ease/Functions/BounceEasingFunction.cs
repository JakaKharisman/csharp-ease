namespace Ease.Functions
{
	public class BounceEasingFunction : EasingFunction
	{
		const double DIV = 2.75;
		const double MULTIPLIER = 7.5625;

		public BounceEasingFunction(EasingMode mode) : base(Easing.Bounce, mode) { }

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
			if (time < 1 / DIV) return MULTIPLIER * time * time;
			if (time < 2 / DIV)
			{
				time -= 1.5 / DIV;
				return MULTIPLIER * time * time + 0.75;
			}
			if (time < 2.5 / DIV)
			{
				time -= 2.25 / DIV;
				return MULTIPLIER * time * time + 0.9375;
			}
			time -= 2.625 / DIV;
			return MULTIPLIER * time * time + 0.984375;
		}

		public static double InOut(double time)
		{
			if (time < 0.5) return In(time * 2) * 0.5;
			return 1 - In((1 - time) * 2) * 0.5;
		}
	}
}
